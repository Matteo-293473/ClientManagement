using System;
using System.Collections.Generic;

namespace ClientManagement
{
    public static class ListaClienti
    {
        // sistemare con proprieta
        public static List<Models.Cliente> clienti = new List<Models.Cliente>();
        public static event EventHandler<List<Models.Cliente>> OnListaCambia;
        public static void AggiungiAllaLista(Models.Cliente cl)
        {
            clienti.Add(cl);

            // se viene aggiunto un elemento alla lista viene segnalato 
            OnListaCambia?.Invoke(cl, clienti);
        }
    }
}
