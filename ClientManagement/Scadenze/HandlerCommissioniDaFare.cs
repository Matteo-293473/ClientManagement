using System.Drawing;
using System.Windows.Forms;
using ClientManagement.Extensions;

namespace ClientManagement.Scadenze
{
    class HandlerCommissioniDaFare : HandlerCommissioni
    {
        public override void AggiornaListView(ListView lstCommissioniScadenza)
        {
            Composite.Composite clientiCommissioni = new Composite.Composite();
            
            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[8];
            foreach (var i in DatiLocali.ClienteCommissioni)
            {
                // prendiamo una lista di commissioni temporanea
                var temp = i.Value;
                foreach (var cm in temp)
                {
                    clientiCommissioni.Add(DatiLocali.Clienti[i.Key]);
                    clientiCommissioni.Add(cm);

                    if (!cm.TaskCompletato)
                    {

                        lst = new ListViewItem(clientiCommissioni.ToArrayString())
                        {
                            BackColor = Color.PaleVioletRed
                        };
                        lstCommissioniScadenza.Items.Add(lst);
                    }

                    clientiCommissioni.Clear();
                }
            }

            // dispongo gli elementi in ordine di data
            lstCommissioniScadenza.ListViewItemSorter = new DateComparer(5);
            lstCommissioniScadenza.Sort();
        }
    }
}
