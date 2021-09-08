using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement.Scadenze
{
    class HandlerListaCommissioniDaFare : HandlerCommissioni
    {
        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {
            Composite.Composite clientiCommissioni = new Composite.Composite();
            
            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[8];
            foreach (var i in commissionManager.ClienteCommissioni)
            {
                // prendiamo una lista di commissioni temporanea
                var temp = i.Value;
                foreach (var cm in temp)
                {
                    clientiCommissioni.Add(commissionManager.Clienti[i.Key]);
                    clientiCommissioni.Add(cm);

                    if (!cm.TaskCompletato)
                    {

                        lst = new ListViewItem(clientiCommissioni.ToArrayString());
                        lst.BackColor = Color.PaleVioletRed;
                        lstCommissioniScadenza.Items.Add(lst);
                    }

                    clientiCommissioni.Clear();
                }
            }

            // dispongo gli elementi in ordine di data
            lstCommissioniScadenza.ListViewItemSorter = new DateComparer(5);
            lstCommissioniScadenza.Sort();
        }
    }
}
