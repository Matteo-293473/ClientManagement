using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.Extensions
{
    public static class clienteCommissioniExtensions
    {
        // prendiamo il dizionario, scorporiamo ogni singola commissione e la inseriamo all'interno della listview
        public static ListViewItem ToListViewItem(Dictionary<Cliente, List<Commissione>> clienteCommissioni)
        {
            ListViewItem lstCommissioniScadenza = new ListViewItem();
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int)date.DayOfWeek);

            // inseriamo ogni commissione all'interno della tabella
            ListViewItem lst;
            string[] arr = new string[6];

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
                    arr[5] = cm.Scadenza.ToString();
                    lst = new ListViewItem(arr);

                    //se l'item non esiste allora lo inseriamo
                    if (cm.Scadenza < nextSunday) ;
                    //lstCommissioniScadenza.Items.Add(lst);

                }
            }
            return new ListViewItem();

        }


    }
}
