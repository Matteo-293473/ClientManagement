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
        public static Dictionary<Cliente, List<Commissione>> clienteCommissioni = new Dictionary<Cliente, List<Commissione>>();
        //private static List<Commissione> commissioni = new List<Commissione>();

        public static event EventHandler<Dictionary<Cliente, List<Commissione>>> OnClienteCommissioniCambia;


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

        //applichiamo l'overload
        public static void AggiungiEntry(Cliente cl)
        {
            List<Commissione> cm = new List<Commissione>();
            // aggiungo il cliente ma senza valore
            clienteCommissioni.Add(cl, cm);
            OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
        }


        public static void AggiungiEntry(Cliente cl, Commissione cm)
        {
            List<Commissione> commissioni = new List<Commissione>();

            if (clienteCommissioni.ContainsKey(cl))
            {
                
                // aggiungi cm alla lista delle commissioni del cliente
                //clienteCommissioni.Add(cl, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
            }


            else
            {
                
                commissioni.Add(cm);
                clienteCommissioni.Add(cl, commissioni);
                OnClienteCommissioniCambia?.Invoke(cl, clienteCommissioni); // aggiungo l'evento
            }
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
