using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    public static class ListaClienti
    {
        // sistemare con proprieta
        public static List<Cliente> clienti = new List<Cliente>();

        public static void AggiungiAllaLista(Cliente cl)
        {
            clienti.Add(cl);
        }
    }
}
