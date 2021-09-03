using System;
using System.Collections.Generic;
using System.Drawing;
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
                    // aggiungo le due "foglie" al composite
                    clientiCommissioni.Add(CommissionManager.Clienti[i.Key]);
                    clientiCommissioni.Add(cm);

                    lst = new ListViewItem(clientiCommissioni.ToArrayString());

                    lst.BackColor = cm.TaskCompletato ? Color.Aquamarine : Color.PaleVioletRed;

                    lstCommissioniScadenza.Items.Add(lst);

                    clientiCommissioni.Clear();

                }
            }

            // disponiamo gli elementi in ordine di data 
            lstCommissioniScadenza.ListViewItemSorter = new DateComparer(5);
            lstCommissioniScadenza.Sort();
        }
    }
}
