using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (Cliente cl in ListaClienti.clienti)
                foreach (Commissione cm in cl.Commissioni)
                {
                    arr[0] = cl.Nome;
                    arr[1] = cl.Cognome;
                    arr[2] = cl.Email;
                    arr[3] = cl.Numero;
                    arr[4] = cm.Descrizione;
                    lst = new ListViewItem(arr);
                    //se l'item non esiste allora lo inseriamo
                    //if (!lstCommissioniScadenza.Items.ContainsKey(cl.Numero.ToString()))
                    lstCommissioniScadenza.Items.Add(lst);
                }

        }
    }
}
