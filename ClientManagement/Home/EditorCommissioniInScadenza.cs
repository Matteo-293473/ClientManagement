using System;
using System.Collections.Generic;
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
            //lstCommissioniScadenza.Items.Clear();
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int) date.DayOfWeek);

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[7];

            foreach (var i in CommissionManager.clienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {
                    if (cm.TaskCompletato == false) // se è un task completato non lo inseriamo nella lista
                    {
                        arr[0] = CommissionManager.clienti[i.Key].Nome;
                        arr[1] = CommissionManager.clienti[i.Key].Cognome;
                        arr[2] = CommissionManager.clienti[i.Key].Email;
                        arr[3] = CommissionManager.clienti[i.Key].Numero;
                        arr[4] = cm.Descrizione;
                        arr[5] = cm.Scadenza.ToString().Substring(0, 10); // mostriamo solo la data
                        arr[6] = cm.IdCommissione.ToString();
                        lst = new ListViewItem(arr);

                        //se l'item non esiste allora lo inseriamo
                        if (cm.Scadenza < nextSunday)
                            lstCommissioniScadenza.Items.Add(lst);
                    }
                }
            }

        }
    }
}
