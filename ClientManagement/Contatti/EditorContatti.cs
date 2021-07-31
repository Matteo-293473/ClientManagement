using System.Windows.Forms;
using ClientManagement.Models;

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
            foreach (var i in CommissionManager.clienteCommissioni)
            {
                arr[0] = i.Key.Nome;
                arr[1] = i.Key.Cognome;
                arr[2] = i.Key.Email;
                arr[3] = i.Key.Numero;
                lst = new ListViewItem(arr);
                //se l'item non esiste allora lo inseriamo
                //if (!lstCommissioniScadenza.Items.ContainsKey(cl.Numero.ToString()))
                lstContatti.Items.Add(lst);
            }

        }
    }
}

