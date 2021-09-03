using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Database;

namespace ClientManagement.Models
{
    static class CommissionManager
    {
        // dizionari nei quali vengono archiviati i dati
        public static readonly Dictionary<int, List<Commissione>> ClienteCommissioni = new Dictionary<int, List<Commissione>>();
        public static readonly Dictionary<int, Cliente> Clienti = new Dictionary<int, Cliente>();

        // creiamo due eventi
        public static event EventHandler<Dictionary<int, List<Commissione>>> OnClienteCommissioniCambia;
        public static event EventHandler<Dictionary<int, Cliente>> OnClientiCambia;


        // facciamo iniziare il valore a 1 perché quando ritorna un valore non trovato il valore è 0
        private static int _value = 1;


        // usufruiamo dell'overload
        public static void AggiungiEntry(Cliente cl)
        {
            var c = RecuperaChiaveDaCliente(cl);

            if (Clienti.ContainsKey(c))
                throw new Exception("Il cliente è già presente");

            // aggiungo il cliente
            Clienti.Add(_value, cl);
            _value += 1;
            OnClientiCambia?.Invoke(cl, Clienti);

        }


        public static void AggiungiEntry(Cliente cl, Commissione cm)
        {
            var commissioni = new List<Commissione>();

            var c = RecuperaChiaveDaCliente(cl);

            if (ClienteCommissioni.ContainsKey(c))
            {
                // se il cliente è già presente e ha delle commissioni

                // aggiungi cm alla lista delle commissioni del cliente
                //ClienteCommissioni.Add(cl, commissioni);
                commissioni = ClienteCommissioni[c];
                commissioni.Add(cm);
                ClienteCommissioni[c] = commissioni;
                OnClienteCommissioniCambia?.Invoke(cl, ClienteCommissioni); // invoco l'evento
            }

            else if (Clienti.ContainsKey(c))
            {

                // se il cliente non esiste tra le commissioni ma esiste nella rubrica

                commissioni.Add(cm);
                ClienteCommissioni.Add(c, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, ClienteCommissioni); // invoco l'evento
            }
            else
            {
                // se il cliente non esiste nè tra le commissioni nè nella rubrica

                commissioni.Add(cm); // aggiungo la commissione
                Clienti.Add(_value, cl); // aggiungo il cliente nella rubrica
                OnClientiCambia?.Invoke(cl, Clienti); // invoco l'evento
                ClienteCommissioni.Add(_value, commissioni); // aggiungo la commissione associata al cliente
                OnClienteCommissioniCambia?.Invoke(cl, ClienteCommissioni); // invoco l'evento
                _value += 1; // aggiorno il valore
            }

        }



        // Per il confronto del cliente usiamo Nome Cognome e Numero come superchiave. Se questi 3 valori sono
        // uguali, significa che ci stiamo riferendo allo stesso cliente
        public static int RecuperaChiaveDaCliente(Cliente cl)
        {
            return Clienti.Where(s =>
                Clienti[s.Key].Nome == cl.Nome &&
                Clienti[s.Key].Cognome == cl.Cognome &&
                Clienti[s.Key].Numero == cl.Numero).Select(s => s.Key).FirstOrDefault();
            // nel caso in cui il cliente non si trova nella lista ClienteCommissioni, viene restituito il valore 0

        }


        public static void ModificaCommissione(Commissione commissione)
        {
            foreach (var cm in ClienteCommissioni.Values.SelectMany(listaCommissioni =>
                listaCommissioni.Where(cm => cm.IdCommissione == commissione.IdCommissione)))
            {
                cm.Scadenza = commissione.Scadenza;
                cm.Descrizione = commissione.Descrizione;
                OnClienteCommissioniCambia?.Invoke(ClienteCommissioni, ClienteCommissioni);
            }
        }

        

        public static Commissione RestituisciCommissione(int idCommissione)
        {
            return ClienteCommissioni.Values
                .SelectMany(listaCommissioni => listaCommissioni
                    .Where(cm => cm.IdCommissione == idCommissione))
                .FirstOrDefault(); // se la commissione non c'è, viene restituito null

        }


        internal static void ModificaCliente(Cliente cliente, int idCliente)
        {
            Clienti[idCliente].Nome = cliente.Nome;
            Clienti[idCliente].Cognome = cliente.Cognome;
            Clienti[idCliente].Email = cliente.Email;
            Clienti[idCliente].Numero = cliente.Numero;
            OnClientiCambia?.Invoke(cliente, Clienti);
            OnClienteCommissioniCambia?.Invoke(cliente, ClienteCommissioni);
        }


        public static Cliente RestituisciCliente(int idCliente) =>
            Clienti.Where(c => c.Key == idCliente)
                .Select(c => c.Value)
                .FirstOrDefault();


        // metodo che prende il db, salva Clienti commissioni e mostra il messaggio di salvataggio
        public static void Salva(IDatabase db)
        {
            db.SaveDataClienti(Clienti);
            db.SaveDataCommissioni(ClienteCommissioni);
            MessageBox.Show("Salvato con successo!");
        }

        // Caricamento dei dizionari attraverso i due dizionari ricavati dai file
        public static void Load(IDictionary<int, Cliente> clDictionary,
                                IDictionary<int, List<Commissione>> cmDictionary)
        {

            // trasformo i due IDictionary in Dictionary
            var newClDictionary = new Dictionary<int, Cliente>(clDictionary);
            var newCmDictionary = new Dictionary<int, List<Commissione>>(cmDictionary);

            // pulisco i due dizionari locali
            Clienti.Clear();
            ClienteCommissioni.Clear();

            // trasferiamo il dizionario clDictionary dei Clienti nel dizionario del programma
            foreach (var cl in newClDictionary)
                AggiungiEntry(cl.Value);
            

            // trasferiamo il dizionario cmDictionary delle commissioni nel dizionario del programma
            foreach (var listCm in newCmDictionary)
                foreach (var cm in listCm.Value) 
                    AggiungiEntry(Clienti[listCm.Key], cm);
            

            
        }

        
    }
}
