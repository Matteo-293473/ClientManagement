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
            Composite.Composite clientiCommissioni = new Composite.Composite();
            
            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[8];
            foreach (var i in CommissionManager.ClienteCommissioni)
            {
                // prendiamo una lista di commissioni temporanea
                var temp = i.Value;
                foreach (var cm in temp)
                {
                    clientiCommissioni.Add(cm);
                    clientiCommissioni.Add(CommissionManager.Clienti[i.Key]);

                    if (!cm.TaskCompletato)
                    {

                        lst = new ListViewItem(clientiCommissioni.ToArrayString());
                        lstCommissioniScadenza.Items.Add(lst);
                    }

                    clientiCommissioni.Clear();
                }
            }
        }
    }
}
