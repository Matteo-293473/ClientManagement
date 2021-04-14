using System;
using System.Windows.Forms;

namespace ClientManagement
{
    class EditorCommissioniInScadenza
    {
        public EditorCommissioniInScadenza()
        {


        }

        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int)date.DayOfWeek);

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[6];
            foreach (Cliente cl in ListaClienti.clienti)
                foreach (Commissione cm in cl.Commissioni)
                {
                    arr[0] = cl.Nome;
                    arr[1] = cl.Cognome;
                    arr[2] = cl.Email;
                    arr[3] = cl.Numero;
                    arr[4] = cm.Descrizione;
                    arr[5] = cm.Scadenza.ToString();
                    lst = new ListViewItem(arr);

                    //se l'item non esiste allora lo inseriamo
                    if (cm.Scadenza < nextSunday)
                        lstCommissioniScadenza.Items.Add(lst);
                }

        }
    }
}
