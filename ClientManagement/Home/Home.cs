using System;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Home : UserControl
    {
        // classe che unisce le due form aggiungiCommissione e CommissioniInScandenza
        public Home()
        {
            InitializeComponent();
            commissioniInScadenza1.BringToFront();
        }
    }
}
