using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement.Scadenze
{
    public partial class ListaCommissioniDaFare : UserControl, IObserver
    {
        private readonly HandlerCommissioniDaFare handler;

        public ListaCommissioniDaFare()
        {
            InitializeComponent();
            handler = new HandlerCommissioniDaFare();
            var datiLocali = DatiLocali.GetInstance();

            //ci mettiamo in ascolto dell'evento
            datiLocali.AggiungiObserver(this);
        }

        public new void Update()
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
    }
}
