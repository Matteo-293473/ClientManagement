using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    public static class ListaEntry
    {
        // sistemare con proprieta
        public static List<Entry> entries = new List<Entry>();

        public static void AggiungiAllaLista(Entry entry)
        {
            entries.Add(entry);
        }
    }
}
