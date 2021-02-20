using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            commissioniInScadenza1.BringToFront();
            btnIndietro.Hide();
        }

        private void BtnNuovaCommissione(object sender, EventArgs e)
        {
            btnNuovaCommission.Hide();
            btnIndietro.Show();
            aggiungiCommissione1.BringToFront();
        }

        private void home11_Load(object sender, EventArgs e)
        {

        }

        private void aggiungiCommissione1_Load(object sender, EventArgs e)
        {

        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            btnIndietro.Hide();
            btnNuovaCommission.Show();
            commissioniInScadenza1.BringToFront();
        }
    }
}
