using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class CommissioniInScadenza : UserControl
    {
        private EditorCommissioniInScadenza editor;
       
        public CommissioniInScadenza()
        {
            InitializeComponent();
            editor = new EditorCommissioniInScadenza();
            //ci mettiamo in ascolto di qualche evento
            //l'evento viene generato quando si aggiunge una nuova commissione
            ListaClienti.OnListaCambia += Commissioni_OnListaCambia;
            
        }

        private void Commissioni_OnListaCambia(object sender, List<Cliente> list)
        {
            editor.AggiornaListView(lstCommissioniScadenza);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CommissioniInScadenza_Load(object sender, EventArgs e)
        {

            editor.AggiornaListView(lstCommissioniScadenza);

        }

        private void btnNuovaCommission_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void txtCommissioniScadenza_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formPopup = new ModificaDati();
            formPopup.Show(this);
        }
    }
}
