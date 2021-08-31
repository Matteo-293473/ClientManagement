using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Models
{
    static class CommissionManager
    {
        // dizionari nei quali vengono archiviati i dati
        public static Dictionary<int, List<Commissione>> clienteCommissioni = new Dictionary<int, List<Commissione>>();
        public static Dictionary<int, Cliente> clienti = new Dictionary<int, Cliente>();

        // creiamo due eventi
        public static event EventHandler<Dictionary<int, List<Commissione>>> OnClienteCommissioniCambia;
        public static event EventHandler<Dictionary<int, Cliente>> OnClientiCambia;


        // facciamo iniziare il valore a 1 perché quando ritorna un valore non trovato il valore è 0
        private static int value = 1;


        // usufruiamo dell'overload
        public static void AggiungiEntry(Cliente cl)
        {
            var c = RecuperaChiaveCliente(cl);

            if (clienti.ContainsKey(c))
                throw new Exception("Il cliente è già presente");

            // aggiungo il cliente
            clienti.Add(value, cl);
            value += 1;
            OnClientiCambia?.Invoke(cl, clienti);

        }

        private static void AggiungiEntry(int cl, Commissione cm)
        {
            var commissioni = new List<Commissione>();
            if (clienteCommissioni.ContainsKey(cl))
            {
                // se il cliente è già presente e ha delle commissioni
                commissioni = clienteCommissioni[cl];
                commissioni.Add(cm);
                clienteCommissioni[cl] = commissioni;
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento

            }
            else if (clienti.ContainsKey(cl))
            {
                // se il cliente non esiste tra le commissioni ma esiste nella rubrica
                commissioni.Add(cm);
                clienteCommissioni.Add(cl, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento
            }

        }

        public static void AggiungiEntry(Cliente cl, Commissione cm)
        {
            var commissioni = new List<Commissione>();

            var c = RecuperaChiaveCliente(cl);

            if (clienteCommissioni.ContainsKey(c))
            {
                // se il cliente è già presente e ha delle commissioni

                // aggiungi cm alla lista delle commissioni del cliente
                //clienteCommissioni.Add(cl, commissioni);
                commissioni = clienteCommissioni[c];
                commissioni.Add(cm);
                clienteCommissioni[c] = commissioni;
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento
            }

            else if (clienti.ContainsKey(c))
            {

                // se il cliente non esiste tra le commissioni ma esiste nella rubrica

                commissioni.Add(cm);
                clienteCommissioni.Add(c, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento
            }
            else
            {
                // se il cliente non esiste nè tra le commissioni nè nella rubrica

                commissioni.Add(cm); // aggiungo la commissione
                clienti.Add(value, cl); // aggiungo il cliente nella rubrica
                OnClientiCambia?.Invoke(cl, clienti); // invoco l'evento
                clienteCommissioni.Add(value, commissioni); // aggiungo la commissione associata al cliente
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento
                value += 1; // aggiorno il valore
            }

        }



        // Per il confronto del cliente usiamo Nome Cognome e Numero come superchiave. Se questi 3 valori sono
        // uguali, significa che ci stiamo riferendo allo stesso cliente
        public static int RecuperaChiaveCliente(Cliente cl)
        {
            return clienti.Where(s =>
                clienti[s.Key].Nome == cl.Nome &&
                clienti[s.Key].Cognome == cl.Cognome &&
                clienti[s.Key].Numero == cl.Numero).Select(s => s.Key).FirstOrDefault();
            // nel caso in cui il cliente non si trova nella lista clienteCommissioni, viene restituito il valore 0

        }




        public static void ModificaCommissione(Commissione commissione)
        {
            foreach (var cm in clienteCommissioni.Values.SelectMany(listaCommissioni =>
                listaCommissioni.Where(cm => cm.IdCommissione == commissione.IdCommissione)))
            {
                cm.Scadenza = commissione.Scadenza;
                cm.Descrizione = commissione.Descrizione;
                OnClienteCommissioniCambia?.Invoke(clienteCommissioni, clienteCommissioni);
            }
        }

        public static Commissione RestituisciCommissione(int idCommissione)
        {
            return clienteCommissioni.Values
                .SelectMany(listaCommissioni => listaCommissioni
                    .Where(cm => cm.IdCommissione == idCommissione))
                .FirstOrDefault();
            // se la commissione non c'è, viene restituito null
        }


        internal static void ModificaCliente(Cliente cliente, int idCliente)
        {
            clienti[idCliente].Nome = cliente.Nome;
            clienti[idCliente].Cognome = cliente.Cognome;
            clienti[idCliente].Email = cliente.Email;
            clienti[idCliente].Numero = cliente.Numero;
            OnClientiCambia?.Invoke(cliente, clienti);
            OnClienteCommissioniCambia?.Invoke(cliente, clienteCommissioni);
        }


        public static Cliente RestituisciCliente(int idCliente) =>
            clienti.Where(c => c.Key == idCliente)
                .Select(c => c.Value)
                .FirstOrDefault();


        public static void Salva()
        {

        }

        public static void Load(IDictionary<int, Cliente> clDictionary,
                                IDictionary<int, List<Commissione>> cmDictionary)
        {
            var newClDictionary = new Dictionary<int, Cliente>(clDictionary);
            var newCmDictionary = new Dictionary<int, List<Commissione>>(cmDictionary);

            clienti.Clear();
            clienteCommissioni.Clear();

            // trasferiamo il dizionario clDictionary dei clienti nel dizionario del programma
            foreach (var cl in newClDictionary)
                AggiungiEntry(cl.Value);
            

            // trasferiamo il dizionario cmDictionary delle commissioni nel dizionario del programma
            foreach (var listCm in newCmDictionary)
                foreach (var cm in listCm.Value) 
                    AggiungiEntry(listCm.Key, cm);
            

            
        }

        
    }
}
