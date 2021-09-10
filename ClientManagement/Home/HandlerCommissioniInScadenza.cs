using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.PopUp.VisualizzaCommissione;

namespace ClientManagement
{
    class HandlerCommissioniInScadenza : HandlerCommissioni
    {
        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {
            // rimuoviamo gli elementi presenti
            // lstCommissioniScadenza.Items.Clear();
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int) date.DayOfWeek);

            Composite.Composite clientiCommissioni = new Composite.Composite();

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            string[] arr = new string[8]; 

            foreach (var i in DatiLocali.ClienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (var cm in temp.Where(cm => cm.TaskCompletato == false && cm.Scadenza < nextSunday))
                {
                    ListViewItem lst;
                    lst = new ListViewItem();
                    
                    clientiCommissioni.Add(DatiLocali.Clienti[i.Key]);
                    clientiCommissioni.Add(cm);
                    lst = new ListViewItem(clientiCommissioni.ToArrayString());

                    lst.BackColor = cm.TaskCompletato ? Color.Aquamarine : Color.PaleVioletRed;

                    lstCommissioniScadenza.Items.Add(lst);
                    
                    clientiCommissioni.Clear();
                }
            }

            // dispongo gli elementi in ordine di data
            lstCommissioniScadenza.ListViewItemSorter = new DateComparer(5);
            lstCommissioniScadenza.Sort();

        }
    }
}
