using System;
using System.Windows.Forms;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement.Commissioni
{
    public partial class CommissioniTotali : UserControl, IObserver
    {
        private readonly HandlerCommissioniTotali handler;

        public CommissioniTotali()
        {
            InitializeComponent();
            handler = new HandlerCommissioniTotali();
            var datiLocali = DatiLocali.GetInstance();

            //ci mettiamo in ascolto dell'evento
            datiLocali.AggiungiObserver(this);
        }

        // observer pattern
        public new void Update()
        {
            // uso del polimorfismo
            handler.AggiornaListView(lstCommissioniScadenza);
        }

        private void CommissioniTotali_Load(object sender, EventArgs e)
        {
            handler.AggiornaListView(lstCommissioniScadenza);
        }

        private void BtnVisualizza_Click(object sender, EventArgs e)
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


        private void BtnModifica_Click(object sender, EventArgs e)
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

        private void BtnElimina_Click(object sender, EventArgs e)
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
