using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    class EditorContatti
    {

        internal void AggiornaListaContatti(ListView lstContatti)
        {
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            // inseriamo ogni commissione all'interno della tabella
            lstContatti.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (Cliente cl in ListaClienti.clienti)
                {
                    arr[0] = cl.Nome;
                    arr[1] = cl.Cognome;
                    arr[2] = cl.Email;
                    arr[3] = cl.Numero;
                    lst = new ListViewItem(arr);
                    //se l'item non esiste allora lo inseriamo
                    //if (!lstCommissioniScadenza.Items.ContainsKey(cl.Numero.ToString()))
                    lstContatti.Items.Add(lst);
                }

        }
    }
}
