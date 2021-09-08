using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement.Commissioni
{
    public partial class CommissioniTotali : UserControl, IObserver
    {
        private readonly HandlerCommissioniTotali handler;
        private readonly CommissionManager commissionManager;

        public CommissioniTotali()
        {
            InitializeComponent();
            handler = new HandlerCommissioniTotali();
            commissionManager = CommissionManager.GetInstance();

            //ci mettiamo in ascolto dell'evento
            commissionManager.AggiungiObserver(this);
        }

        public new void Update()
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
