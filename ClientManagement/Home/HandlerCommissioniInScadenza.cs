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

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            string[] arr = new string[7];

            foreach (var i in CommissionManager.ClienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (var cm in temp.Where(cm => cm.TaskCompletato == false && cm.Scadenza < nextSunday))
                {
                    ListViewItem lst;
                    lst = new ListViewItem();
                    //lst.SubItems.Add(clienteCommissioniExtensions.ToListViewCliente(CommissionManager.Clienti[i.Key]));
                    //lst.SubItems.Add(clienteCommissioniExtensions.ToListViewCommissione(cm));



                    // QUESTO SI PUO' CONVERTIRE CON UNA FUNZIONE
                    arr[0] = CommissionManager.Clienti[i.Key].Nome;
                    arr[1] = CommissionManager.Clienti[i.Key].Cognome;
                    arr[2] = CommissionManager.Clienti[i.Key].Email;
                    arr[3] = CommissionManager.Clienti[i.Key].Numero;
                    arr[4] = cm.Descrizione;
                    arr[5] = cm.Scadenza.ToString().Substring(0, 10); // mostriamo solo la data
                    arr[6] = cm.IdCommissione.ToString();
                    lst = new ListViewItem(arr);
                    lstCommissioniScadenza.Items.Add(lst);
                }
            }

        }
    }
}
