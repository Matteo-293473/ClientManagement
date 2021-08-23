using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Extensions
{
    class ControlloListView
    {
        public void ControlloSelezione(ListView listView)
        {
            if (listView.Items.Count == 0)
                throw new Exception("non ci sono elementi da modificare");

            if (listView.SelectedItems.Count == 0)
                throw new Exception("seleziona un elemento dell lista");

            if (listView.SelectedItems.Count > 1)
                throw new Exception("seleziona un solo elemento dell lista");
        }
    }
}
