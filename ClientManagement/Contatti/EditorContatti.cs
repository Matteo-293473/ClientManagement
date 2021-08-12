using System;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    class EditorContatti
    {

        internal void AggiornaListaContatti(ListView lstContatti)
        {
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            // inseriamo ogni commissione all'interno della tabella
            lstContatti.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (var i in CommissionManager.clienti)
            {
                arr[0] = CommissionManager.clienti[i.Key].Nome;
                arr[1] = CommissionManager.clienti[i.Key].Cognome;
                arr[2] = CommissionManager.clienti[i.Key].Numero;
                arr[3] = CommissionManager.clienti[i.Key].Email;
                arr[4] = i.Key.ToString(); 
                lst = new ListViewItem(arr);
                //se l'item non esiste allora lo inseriamo
                //if (!lstCommissioniScadenza.Items.ContainsKey(cl.Numero.ToString()))
                lstContatti.Items.Add(lst);
            }

        }
    }
}

