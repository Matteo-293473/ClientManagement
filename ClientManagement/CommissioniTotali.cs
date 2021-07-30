using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class CommissioniTotali : UserControl
    {
        private EditorCommissioniTotali editor;
        public CommissioniTotali()
        {
            InitializeComponent();
            editor = new EditorCommissioniTotali();
            //ci mettiamo in ascolto di qualche evento
            //l'evento viene generato quando si aggiunge una nuova commissione
            ListaClienti.OnListaCambia += CommissioniTotali_OnListaCambia;
        }

        private void CommissioniTotali_OnListaCambia(object sender, List<Models.Cliente> list)
        {
            editor.AggiornaListView(lstCommissioniScadenza);
        }

        private void CommissioniTotali_Load(object sender, EventArgs e)
        {
            editor.AggiornaListView(lstCommissioniScadenza);
        }
    }
}
