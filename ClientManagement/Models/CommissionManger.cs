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

        public static void AggiungiClienteCommissione(Cliente cl, Commissione cm)
        {
            List<Commissione> commissioni = new List<Commissione>();

            if (clienteCommissioni.ContainsKey(cl))
            {
                
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
