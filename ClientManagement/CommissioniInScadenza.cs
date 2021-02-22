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
    public partial class CommissioniInScadenza : UserControl
    {
        public CommissioniInScadenza()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CommissioniInScadenza_Load(object sender, EventArgs e)
        {
            foreach (Cliente cl in ListaClienti.clienti)
                foreach (Commissione cm in cl.Commissioni) 
                {
                    //lstCommissioniScadenza.Items.Add(cm.Descrizione);
                    lstCommissioniScadenza.Items.Add(cm);
                }
                    

        }
    }
}
