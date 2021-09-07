using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class CommissioniTotali : UserControl
    {
        private readonly HandlerCommissioniTotali handler;

        public CommissioniTotali()
        {
            InitializeComponent();
            handler = new HandlerCommissioniTotali();

            //ci mettiamo in ascolto dell'evento
            //l'evento viene generato quando si aggiunge una nuova commissione
            CommissionManager.OnClienteCommissioniCambia += CommissioniTotali_OnListaCambia;
        }

        private void CommissioniTotali_OnListaCambia(object sender, Dictionary<int, List<Commissione>> clienteCommissioni)
        {
            handler.AggiornaListView(lstCommissioniScadenza);
          
        }

        private void CommissioniTotali_Load(object sender, EventArgs e)
        {
            handler.AggiornaListView(lstCommissioniScadenza);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            try
            {
                handler.MostraPopUp(lstCommissioniScadenza, this, "visualizza");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                handler.MostraPopUp(lstCommissioniScadenza, this, "modifica");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare la commissione?", "Eliminare", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    handler.Elimina(lstCommissioniScadenza);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
