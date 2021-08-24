using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Extensions
{

    // Classe dedicata al controllo degli errori
    static class Controllo
    {
        // Controllo caratteri, utilizzato all'interno delle textbox

        public static void ControllaNumeri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void ControllaCaratteri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void ControllaSpazi(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        // Controllo sulla selezione dell'elemento nella ListView

        public static void ControlloListViewSelezione(ListView listView)
        {
            if (listView.Items.Count == 0)
                throw new Exception("Non sono presenti elementi");

            if (listView.SelectedItems.Count == 0)
                throw new Exception("Seleziona un elemento dalla lista");

            if (listView.SelectedItems.Count > 1)
                throw new Exception("Seleziona un solo elemento dalla lista");
        }
    }
}
