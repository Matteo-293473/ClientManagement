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
            var c = recuperaChaiveCliente(cl);

            if (clienti.ContainsKey(c))
                throw new Exception("Il cliente è già presente");

            // aggiungo il cliente
            clienti.Add(value, cl);
            value += 1;
            OnClientiCambia?.Invoke(cl, clienti);
            
        }


        public static void AggiungiEntry(Cliente cl, Commissione cm)
        {
            List<Commissione> commissioni = new List<Commissione>();

            var c = recuperaChaiveCliente(cl);

            if (clienteCommissioni.ContainsKey(c))
            {
                // se il cliente è giò presente e ha delle commissioni
                
                // aggiungi cm alla lista delle commissioni del cliente
                //clienteCommissioni.Add(cl, commissioni);
                commissioni = clienteCommissioni[c];
                commissioni.Add(cm);
                clienteCommissioni[c] = commissioni;
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento
            }
            
            else if(clienti.ContainsKey(c))
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
                OnClientiCambia?.Invoke(cl, clienti);  // invoco l'evento
                clienteCommissioni.Add(value, commissioni); // aggiungo la commissione associata al cliente
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // invoco l'evento
                value += 1; // aggiorno il valore
            }
            
        }


        
        // Per il confronto del cliente usiamo Nome Cognome e Numero come superchiave. Se questi 3 valori sono
        // uguali, significa che ci stiamo riferendo allo stesso cliente
        public static int recuperaChaiveCliente(Cliente cl)
        {
            return clienti.Where(s =>
                clienti[s.Key].Nome == cl.Nome &&
                clienti[s.Key].Cognome == cl.Cognome &&
                clienti[s.Key].Numero == cl.Numero).Select(s => s.Key).FirstOrDefault();
            // nel caso in cui il cliente non si trova nella lista clienteCommissioni, viene restituito il valore 0

        }




        public static void ModificaCommissione(Commissione commissione)
        {
            foreach (var listaCommissioni in CommissionManager.clienteCommissioni.Values)
            {
                foreach (var cm in listaCommissioni)
                {
                    if (cm.IdCommissione == commissione.IdCommissione)
                    {
                        cm.Scadenza = commissione.Scadenza;
                        cm.Descrizione = commissione.Descrizione;
                        OnClienteCommissioniCambia?.Invoke(clienteCommissioni, clienteCommissioni);
                    }

                }
            }
        }

        public static Commissione RestituisciCommissione(int idCommissione)
        {
            foreach (var listaCommissioni in clienteCommissioni.Values)
            {
                foreach (var cm in listaCommissioni)
                {
                    if (cm.IdCommissione == idCommissione)
                        return cm;
                    

                }
            }
            // se la commissione non c'è, viene restituito null
            return null;
        }


        internal static void ModificaCliente(Cliente cliente,int idCliente)
        {
            clienti[idCliente].Nome = cliente.Nome;
            clienti[idCliente].Cognome = cliente.Cognome;
            clienti[idCliente].Email = cliente.Email;
            clienti[idCliente].Numero = cliente.Numero;
            OnClientiCambia?.Invoke(cliente, clienti);
        }


        public static Cliente RestituisciCliente(int idCliente)
        {
            return clienti.Where(c => c.Key == idCliente)
                .Select(c => c.Value)
                .FirstOrDefault();
        }


    }
}
