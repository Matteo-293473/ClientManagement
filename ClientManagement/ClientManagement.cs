using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Database;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class ClientManagement : Form
    {
        private HandlerClientManagement handler;
        private readonly IDatabase db;
        private readonly DatiLocali datiLocali;

        public ClientManagement(IDatabase database)
        {
            InitializeComponent();

            db = database;
            handler = new HandlerClientManagement();
            handler.ColoreSelezione(btnHome, pnlSideMenu);
            datiLocali = DatiLocali.GetInstance();


            LoadStorage();
        }


        private void LoadStorage()
        {
            var clienti = db.GetDataClienti();
            var commissioni = db.GetDataCommissioni();

            datiLocali.Load(clienti,commissioni);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

          home1.BringToFront();

        }



        private void BtnHome_Click(object sender, EventArgs e)
        {
            // se viene selezionato abbiamo il colore più chiaro
            handler.ColoreSelezione(btnHome, pnlSideMenu);

            // gestire meglio con tab control selectedTab
            home1.BringToFront();

        }

        private void PnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PctBoxLogo_Click(object sender, EventArgs e)
        {

        }


        private void BtnRubrica_Click(object sender, EventArgs e)
        {
            handler.ColoreSelezione(btnRubrica, pnlSideMenu);
            contatti1.BringToFront();
        }

        private void BtnCommissioni_Click(object sender, EventArgs e)
        {
            handler.ColoreSelezione(btnCommissioni, pnlSideMenu);
            commissioniTotali1.BringToFront();
        }


        private void BtnScadenze_Click(object sender, EventArgs e)
        {
            handler.ColoreSelezione(btnScadenze, pnlSideMenu);
            commissioniDaFare1.BringToFront();
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            handler.ColoreDeselezione(btnHome);
        }

        private void btnRubrica_Leave(object sender, EventArgs e)
        {
            handler.ColoreDeselezione(btnRubrica);
        }

        private void btnCommissioni_Leave(object sender, EventArgs e)
        {
            handler.ColoreDeselezione(btnCommissioni);
        }

        private void btnScadenze_Leave(object sender, EventArgs e)
        {
            handler.ColoreDeselezione(btnScadenze);
        }



        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            handler.ControllaSalvataggio(e);
        }
    }
}
