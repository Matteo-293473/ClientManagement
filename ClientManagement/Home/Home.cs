using System;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            commissioniInScadenza1.BringToFront();
        }

        private void BtnNuovaCommissione(object sender, EventArgs e)
        {
            //btnNuovaCommission.Hide();

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
            //btnNuovaCommission.Show();
            commissioniInScadenza1.BringToFront();
        }

        private void aggiungiCommissione1_Load_4(object sender, EventArgs e)
        {

        }
    }
}
