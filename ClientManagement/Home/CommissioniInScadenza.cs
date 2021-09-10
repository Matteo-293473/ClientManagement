using System;
using System.Windows.Forms;
using ClientManagement.Database;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement
{
    public partial class CommissioniInScadenza : UserControl, IObserver
    {

        private readonly HandlerCommissioniInScadenza handler;
        private readonly DatiLocali datiLocali;

        private readonly IDatabase db;

        public CommissioniInScadenza(IDatabase database)
        {
            InitializeComponent();

            db = database;

            handler = new HandlerCommissioniInScadenza();
            datiLocali = DatiLocali.GetInstance();

            //ci mettiamo in ascolto dell'evento
            datiLocali.AggiungiObserver(this);


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

        private void BtnNuovaCommission_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void BtnModifica_Click(object sender, EventArgs e)
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

        private void BtnVisualizza_Click(object sender, EventArgs e)
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

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            datiLocali.Salva(db);
        }
    }
}
