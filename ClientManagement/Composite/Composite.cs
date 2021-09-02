using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Composite
{
    class Composite : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent leaf)
        {
            components.Add(leaf);
        }

        public ListViewItem ToListView()
        {
            ListViewItem lstItem = new ListViewItem();
            foreach (var component in components)
            {
                //lstItem. component.ToListView();
            }

            return new ListViewItem(/*inserisci elemento*/);
        }

        public static ListViewItem ToListViewCommissione(IComponent commissione)
        {

            //string[] row = { commissione.Descrizione, commissione.Scadenza.ToString().Substring(0, 10), commissione.TaskCompletato ? "Sì" : "No", commissione.IdCommissione.ToString() };
            return new ListViewItem();
        }
    }
}
