using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.PopUp.VisualizzaCommissione;

namespace ClientManagement
{
    class EditorCommissioniInScadenza : HandlerCommissioni
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
            string[] arr = new string[8]; //era 7

            foreach (var i in CommissionManager.ClienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (var cm in temp.Where(cm => cm.TaskCompletato == false && cm.Scadenza < nextSunday))
                {
                    ListViewItem lst;
                    lst = new ListViewItem();
                    //lst.SubItems.Add(clienteCommissioniExtensions.ToListViewCliente(CommissionManager.Clienti[i.Key]));
                    //lst.SubItems.Add(clienteCommissioniExtensions.ToListViewCommissione(cm));

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
