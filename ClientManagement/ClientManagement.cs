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
        private HandlerClientManagement editor;
        public ClientManagement()
        {
            InitializeComponent();
            editor = new HandlerClientManagement();
            editor.ColoreSelezione(btnHome, pnlSideMenu);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

          home1.BringToFront();

        }



        private void btnRiduciAIcona_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            // se viene selezionato abbiamo il colore più chiaro
            editor.ColoreSelezione(btnHome, pnlSideMenu);

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
            editor.ColoreSelezione(btnRubrica, pnlSideMenu);
            contatti1.BringToFront();
        }

        private void BtnCommissioni_Click(object sender, EventArgs e)
        {
            editor.ColoreSelezione(btnCommissioni, pnlSideMenu);
            commissioniTotali1.BringToFront();
        }


        private void BtnScadenze_Click(object sender, EventArgs e)
        {
            editor.ColoreSelezione(btnScadenze, pnlSideMenu);
            listaCommissioniDaFare1.BringToFront();
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            editor.ColoreDeselezione(btnHome);
        }

        private void btnRubrica_Leave(object sender, EventArgs e)
        {
            editor.ColoreDeselezione(btnRubrica);
        }

        private void btnCommissioni_Leave(object sender, EventArgs e)
        {
            editor.ColoreDeselezione(btnCommissioni);
        }

        private void btnScadenze_Leave(object sender, EventArgs e)
        {
            editor.ColoreDeselezione(btnScadenze);
        }



        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void calendario1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
