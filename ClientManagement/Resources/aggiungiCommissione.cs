using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Resources
{
    public partial class aggiungiCommissione : UserControl
    {
        public aggiungiCommissione()
        {
            InitializeComponent();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
