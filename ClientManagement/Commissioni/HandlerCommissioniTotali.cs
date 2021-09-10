using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement
{
    class HandlerCommissioniTotali : HandlerCommissioni
    {
        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {

            Composite.Composite clientiCommissioni = new Composite.Composite();

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            foreach (var i in DatiLocali.ClienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {
                    // aggiungo le due "foglie" al composite
                    clientiCommissioni.Add(DatiLocali.Clienti[i.Key]);
                    clientiCommissioni.Add(cm);

                    var lst = new ListViewItem(clientiCommissioni.ToArrayString())
                    {
                        // imposto il colore di background in base a
                        // se la commissione è stata completata o meno
                        BackColor = cm.TaskCompletato ? Color.Aquamarine : Color.PaleVioletRed
                    };


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
