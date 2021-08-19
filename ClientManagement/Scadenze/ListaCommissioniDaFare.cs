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
        private HandlerCommissioniTotali handler;
        public ListaCommissioniDaFare()
        {
            InitializeComponent();
            handler = new HandlerCommissioniTotali();
            //ci mettiamo in ascolto di qualche evento
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
    }
}
