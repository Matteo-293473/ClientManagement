using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Database;
using ClientManagement.Observer;

namespace ClientManagement.Models
{
    class DatiLocali : Subject, IObserver
    {
        // attributo per mantenere sempre la stessa istanza
        private static DatiLocali _instance;

        // dizionari nei quali vengono archiviati i dati
        public Dictionary<int, List<Commissione>> ClienteCommissioni { get; } = new Dictionary<int, List<Commissione>>();
        public Dictionary<int, Cliente> Clienti { get; } = new Dictionary<int, Cliente>();

        public static bool Salvato { get; private set; } = true;


        // Non vogliamo istanziare due volte datiLocali
        public static DatiLocali GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatiLocali();
            }

            return _instance;
        }

        // Qui applichiamo il pattern Singleton.
        private DatiLocali()
        {
            this.AggiungiObserver(this);
        }




        // se viene invocato significa che c'è stato un cambiamento che le nuove modifiche non sono state salvate
        public void Update()
        {
            Salvato = false;
        }

        // facciamo iniziare il valore a 1 perché quando ritorna un valore non trovato il valore è 0
        private static int _value = 1;


        // usufruiamo dell'overload
        public void AggiungiEntry(Cliente cl)
        {
            var c = RecuperaChiaveDaCliente(cl);

            if (Clienti.ContainsKey(c))
                throw new Exception("Il cliente è già presente");

            // aggiungo il cliente
            Clienti.Add(_value, cl);
            _value += 1;

            // notifico le modifiche
            NotificaObservers();

        }


        public void AggiungiEntry(Cliente cl, Commissione cm)
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
            }

            else if (Clienti.ContainsKey(c))
            {
                // se il cliente non esiste tra le commissioni ma esiste nella rubrica
                commissioni.Add(cm);
                ClienteCommissioni.Add(c, commissioni);
            }
            else
            {
                // se il cliente non esiste nè tra le commissioni nè nella rubrica
                commissioni.Add(cm); // aggiungo la commissione
                Clienti.Add(_value, cl); // aggiungo il cliente nella rubrica
                ClienteCommissioni.Add(_value, commissioni); // aggiungo la commissione associata al cliente
                _value += 1; // aggiorno il valore
            }

            // notifico le modifiche
            NotificaObservers();

        }



        // Per il confronto del cliente usiamo Nome Cognome e Numero come superchiave. Se questi 3 valori sono
        // uguali, significa che ci stiamo riferendo allo stesso cliente
        public int RecuperaChiaveDaCliente(Cliente cl)
        {
            return Clienti.Where(s =>
                Clienti[s.Key].Nome == cl.Nome &&
                Clienti[s.Key].Cognome == cl.Cognome &&
                Clienti[s.Key].Numero == cl.Numero).Select(s => s.Key).FirstOrDefault();
            // nel caso in cui il cliente non si trova nella lista ClienteCommissioni, viene restituito il valore 0

        }


        public void ModificaCommissione(Commissione commissione)
        {
            foreach (var cm in ClienteCommissioni.Values.SelectMany(listaCommissioni =>
                listaCommissioni.Where(cm => cm.IdCommissione == commissione.IdCommissione)))
            {
                cm.Scadenza = commissione.Scadenza;
                cm.Descrizione = commissione.Descrizione;

                // notifico le modifiche
                NotificaObservers();
            }
        }

        

        public Commissione RestituisciCommissione(int idCommissione)
        {
            return ClienteCommissioni.Values
                .SelectMany(listaCommissioni => listaCommissioni
                    .Where(cm => cm.IdCommissione == idCommissione))
                .FirstOrDefault(); // se la commissione non c'è, viene restituito null

        }


        internal void ModificaCliente(Cliente cliente, int idCliente)
        {
            Clienti[idCliente].Nome = cliente.Nome;
            Clienti[idCliente].Cognome = cliente.Cognome;
            Clienti[idCliente].Numero = cliente.Numero;
            Clienti[idCliente].Email = cliente.Email;

            // notifico le modifiche
            NotificaObservers();
        }


        // rimuoviamo la commissione selezionata
        public void EliminaCommissione(int idCommissione, int idCliente)
        {
            ClienteCommissioni[idCliente].RemoveAll((x => x.IdCommissione == idCommissione));

            // notifico le modifiche
            NotificaObservers();
        }

        // rimuoviamo il cliente e tutte le commissioni ad esso associate
        public void EliminaCliente(int idCliente)
        {
            ClienteCommissioni.Remove(idCliente);
            Clienti.Remove(idCliente);

            // notifico le modifiche
            NotificaObservers();

        }


        public Cliente RestituisciCliente(int idCliente) =>
            Clienti.Where(c => c.Key == idCliente)
                .Select(c => c.Value)
                .FirstOrDefault();


        // metodo che prende il db, salva Clienti commissioni e mostra il messaggio di salvataggio
        public void Salva(IDatabase db)
        {
            db.SaveDataClienti(Clienti);
            db.SaveDataCommissioni(ClienteCommissioni);
            MessageBox.Show("Salvato con successo!");
            Salvato = true;
        }

        // Caricamento dei dizionari attraverso i due dizionari ricavati dai file
        public void Load(IDictionary<int, Cliente> clDictionary,
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


            // Appena caricato il file non dobbiamo segnare che bisogna salvare
            Salvato = true;
        }
    }
}