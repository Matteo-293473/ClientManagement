using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.Scadenze
{
    class HandlerListaCommissioniDaFare
    {
        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[8];
            foreach (var i in Models.CommissionManager.ClienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {
                    if (!cm.TaskCompletato)
                    {
                        arr[0] = CommissionManager.Clienti[i.Key].Nome;
                        arr[1] = CommissionManager.Clienti[i.Key].Cognome;
                        arr[2] = CommissionManager.Clienti[i.Key].Email;
                        arr[3] = CommissionManager.Clienti[i.Key].Numero;
                        arr[4] = cm.Descrizione;
                        arr[5] = cm.Scadenza.ToString().Substring(0, 10); // mostriamo solo la data
                        arr[6] = cm.IdCommissione.ToString();
                        arr[7] = "No";
                        lst = new ListViewItem(arr);
                        lstCommissioniScadenza.Items.Add(lst);
                    }
                }
            }
        }
    }
}
