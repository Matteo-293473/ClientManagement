using System.Windows.Forms;

namespace ClientManagement.Contatti
{
    public partial class Contatti : UserControl
    {
        // classe che unisce le due form AggiungiContatto e ListaContatti
        public Contatti()
        {
            InitializeComponent();
            listaContatti1.BringToFront();
        }

    }
}
