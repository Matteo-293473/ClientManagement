using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Database;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement
{
    public partial class CommissioniInScadenza : UserControl, IObserver
    {

        private readonly HandlerCommissioniInScadenza handler;
        private readonly CommissionManager commissionManager;

        private readonly IDatabase db;

        public CommissioniInScadenza(IDatabase database)
        {
            InitializeComponent();

            db = database;

            handler = new HandlerCommissioniInScadenza();
            commissionManager = CommissionManager.GetInstance();

            //ci mettiamo in ascolto dell'evento
            commissionManager.AggiungiObserver(this);


        }


        // observable pattern
        public new void Update()
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
            commissionManager.Salva(db);
        }
    }
}
