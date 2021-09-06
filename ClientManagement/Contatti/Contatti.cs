using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

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
