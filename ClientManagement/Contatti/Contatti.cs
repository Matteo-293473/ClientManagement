using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class Contatti : UserControl
    {
        private EditorContatti editor;
        public Contatti()
        {
            InitializeComponent();
            CommissionManager.OnClienteCommissioniCambia += Clienti_OnListaCambia;
            editor = new EditorContatti();

        }

        private void Clienti_OnListaCambia(object sender, Dictionary<Cliente, List<Commissione>> clienteCommissioni)
        {
            editor.AggiornaListaContatti(lstContatti);
        }

        private void Contatti_Load(object sender, EventArgs e)
        {
            editor.AggiornaListaContatti(lstContatti);
        }
    }
}
