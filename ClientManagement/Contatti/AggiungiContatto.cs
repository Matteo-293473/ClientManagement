using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Contatti
{
    public partial class AggiungiContatto : UserControl
    {
        public AggiungiContatto()
        {
            InitializeComponent();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
