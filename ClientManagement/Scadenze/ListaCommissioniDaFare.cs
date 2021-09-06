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

namespace ClientManagement.Scadenze
{
    public partial class ListaCommissioniDaFare : UserControl
    {
        private readonly HandlerListaCommissioniDaFare handler;
        public ListaCommissioniDaFare()
        {
            InitializeComponent();
            handler = new HandlerListaCommissioniDaFare();

            //ci mettiamo in ascolto dell'evento che viene generato quando si aggiunge una nuova commissione
            CommissionManager.OnClienteCommissioniCambia += CommissioniTotali_OnListaCambia;
        }

        private void CommissioniTotali_OnListaCambia(object sender, Dictionary<int, List<Commissione>> clienteCommissioni)
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
