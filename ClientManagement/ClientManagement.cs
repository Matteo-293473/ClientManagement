using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class ClientManagement : Form
    {

        private HandlerClientManagement editor;
        public ClientManagement()
        {
            InitializeComponent();
            editor = new HandlerClientManagement(btnHome, btnRubrica, btnCommissioni, btnScadenze, pnlSideMenu);
            pnlSideMenu.Height = btnHome.Height;
            pnlSideMenu.Top = btnHome.Top;
            pnlSideMenu.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
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
            //pnlSideMenu.Height = btnHome.Height;
            //pnlSideMenu.Top = btnHome.Top;
            //pnlSideMenu.Left = btnHome.Left;
            //btnHome.BackColor = Color.FromArgb(46, 51, 73);
            editor.ColoreSelezionato(btnHome, pnlSideMenu);

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
            editor.ColoreSelezionato(btnRubrica, pnlSideMenu);
            contatti1.BringToFront();
        }

        private void BtnCommissioni_Click(object sender, EventArgs e)
        {
            editor.ColoreSelezionato(btnCommissioni, pnlSideMenu);
        }


        private void BtnScadenze_Click(object sender, EventArgs e)
        {
            editor.ColoreSelezionato(btnScadenze, pnlSideMenu);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnRubrica_Leave(object sender, EventArgs e)
        {
            btnRubrica.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnCommissioni_Leave(object sender, EventArgs e)
        {
            btnCommissioni.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnScadenze_Leave(object sender, EventArgs e)
        {
            btnScadenze.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void contatti1_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
