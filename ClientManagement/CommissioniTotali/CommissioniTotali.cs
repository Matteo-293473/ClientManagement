using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Models;

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
            CommissionManager.OnClienteCommissioniCambia += CommissioniTotali_OnListaCambia;
        }

        private void CommissioniTotali_OnListaCambia(object sender, Dictionary<int, List<Commissione>> clienteCommissioni)
        {
            editor.AggiornaListView(lstCommissioniScadenza);
        }

        private void CommissioniTotali_Load(object sender, EventArgs e)
        {
            editor.AggiornaListView(lstCommissioniScadenza);
        }
    }
}
