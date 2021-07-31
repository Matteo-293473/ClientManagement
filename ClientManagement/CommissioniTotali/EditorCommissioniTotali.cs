using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    class EditorCommissioniTotali
    {
        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[6];
            foreach (var i in Models.CommissionManager.clienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {

                    arr[0] = i.Key.Nome;
                    arr[1] = i.Key.Cognome;
                    arr[2] = i.Key.Email;
                    arr[3] = i.Key.Numero;
                    arr[4] = cm.Descrizione;
                    arr[5] = cm.Scadenza.ToString();
                    lst = new ListViewItem(arr);
                    lstCommissioniScadenza.Items.Add(lst);

                }
            }
        }
    }
}
