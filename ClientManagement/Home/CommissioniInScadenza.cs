using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Database;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class CommissioniInScadenza : UserControl
    {

        private readonly HandlerCommissioniInScadenza handler;

        private readonly IDatabase db;

        public CommissioniInScadenza(IDatabase database)
        {
            InitializeComponent();

            db = database;

            handler = new HandlerCommissioniInScadenza();

            //ci mettiamo in ascolto di qualche evento
            //l'evento viene generato quando si aggiunge una nuova commissione
            CommissionManager.OnClienteCommissioniCambia += Commissioni_OnListaCambia;
            
        }


        private void Commissioni_OnListaCambia(object sender, Dictionary<int, List<Commissione>> clienteCommissioni)
        {
            handler.AggiornaListView(lstCommissioniScadenza);
        }

        private void CommissioniInScadenza_Load(object sender, EventArgs e)
        {

            handler.AggiornaListView(lstCommissioniScadenza);

        }

        private void btnNuovaCommission_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                handler.MostraPopUp(lstCommissioniScadenza,this, "modifica");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            try
            {
                handler.MostraPopUp(lstCommissioniScadenza, this,"visualizza");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            CommissionManager.Salva(db);
        }
    }
}
