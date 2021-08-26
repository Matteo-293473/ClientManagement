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

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[8];
            foreach (var i in Models.CommissionManager.clienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {

                    arr[0] = CommissionManager.clienti[i.Key].Nome;
                    arr[1] = CommissionManager.clienti[i.Key].Cognome;
                    arr[2] = CommissionManager.clienti[i.Key].Email;
                    arr[3] = CommissionManager.clienti[i.Key].Numero;
                    arr[4] = cm.Descrizione;
                    arr[5] = cm.Scadenza.ToString().Substring(0, 10); // mostriamo solo la data
                    arr[6] = cm.IdCommissione.ToString();
                    arr[7] = cm.TaskCompletato? "sì" : "no";
                    lst = new ListViewItem(arr);
                    lstCommissioniScadenza.Items.Add(lst);

                }
            }
        }
    }
}
