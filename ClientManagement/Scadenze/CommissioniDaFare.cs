using System;
using System.Windows.Forms;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement.Scadenze
{
    public partial class CommissioniDaFare : UserControl, IObserver
    {
        private readonly HandlerCommissioniDaFare handler;

        public CommissioniDaFare()
        {
            InitializeComponent();
            handler = new HandlerCommissioniDaFare();
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
    }
}
