using System;
using System.Collections.Generic;

namespace ClientManagement
{
    public static class ListaClienti
    {
        // sistemare con proprieta
        public static List<Cliente> clienti = new List<Cliente>();
        public static event EventHandler<List<Cliente>> OnListaCambia;
        public static void AggiungiAllaLista(Cliente cl)
        {
            clienti.Add(cl);

            // se viene aggiunto un elemento alla lista viene segnalato 
            OnListaCambia?.Invoke(cl, clienti);
        }
    }
}
