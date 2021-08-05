using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Models
{
    static class CommissionManager
    {
        //private static CommissionManager instance = null;
        public static Dictionary<int, List<Commissione>> clienteCommissioni = new Dictionary<int, List<Commissione>>();

        public static Dictionary<int, Cliente> clienti = new Dictionary<int, Cliente>();
        
        //private static List<Commissione> commissioni = new List<Commissione>();


        public static event EventHandler<Dictionary<int, List<Commissione>>> OnClienteCommissioniCambia;

        public static event EventHandler<Dictionary<int, Cliente>> OnClientiCambia;

        //public static CommissionManager GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new CommissionManager();
        //    }

        //    return instance;
        //}


        //protected CommissionManager()
        //{

        //}
        private static int value = 0;

        //applichiamo l'overload
        public static void AggiungiEntry(Cliente cl)
        {

            // aggiungo il cliente
            clienti.Add(value,cl);
            value += 1;
            OnClientiCambia?.Invoke(cl, clienti);
            //OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
        }


        public static void AggiungiEntry(Cliente cl, Commissione cm)
        {
            List<Commissione> commissioni = new List<Commissione>();

            var c = confrontaChiave(cl);

            

            if (clienteCommissioni != null)
            {
                
                // aggiungi cm alla lista delle commissioni del cliente
                //clienteCommissioni.Add(cl, commissioni);
                commissioni = clienteCommissioni.Where(s => s.Key.Nome == cl.Nome && 
                                                            s.Key.Cognome == cl.Cognome && 
                                                            s.Key.Email == cl.Email)
                    .Select(s => s.Value)
                    .First();
                commissioni.Add(cm);
                clienti.Add(value, cl);
                clienteCommissioni[cl] = commissioni;
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
            }
            
            else
            {
                
                commissioni.Add(cm);
                clienti.Add(value, cl);
                OnClientiCambia?.Invoke(cl, clienti);
                clienteCommissioni.Add(value, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
                value += 1;
            }
            
        }


        // PROBLEMA 
        private static int confrontaChiave(Cliente cl)
        {
            return CommissionManager.clienteCommissioni.Where(s =>
                clienti[s.Key].Nome == cl.Nome &&
                clienti[s.Key].Cognome == cl.Cognome &&
                clienti[s.Key].Email == cl.Email).Select(s => s.Key).FirstOrDefault();

            //clienteCommissioni.ContainsKey(cl);

        }

        //public class MyClass
        //{
        //    //..attributi membro di istanza....
        //    private static MyClass _instance = null;

        //    protected MyClass()
        //    {
        //        //...inizializzazione istanza...
        //    }

        //    public static MyClass Instance
        //    {
        //        get
        //        {
        //            if (_instance == null) _instance = new MyClass();
        //            return _instance;
        //        }
        //    }

        //    //...eventuali metodi pubblici, privati e protetti di istanza....
        //}

    }
}
