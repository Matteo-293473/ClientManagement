using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using System.Linq;

namespace ClientManagement
{
    class HandlerCommissioniTotali : HandlerCommissioni
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
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {

                    clientiCommissioni.Add(cm);
                    clientiCommissioni.Add(CommissionManager.Clienti[i.Key]);
                    lst = new ListViewItem(clientiCommissioni.ToArrayString());

                    lstCommissioniScadenza.Items.Add(lst);

                    clientiCommissioni.Clear();

                }
            }
        }
    }
}
