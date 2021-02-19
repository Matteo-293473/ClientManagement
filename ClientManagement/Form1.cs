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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            PnlSideMenu.Height = btnHome.Height;
            PnlSideMenu.Top = btnHome.Top;
            PnlSideMenu.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnRiduciAIcona_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PnlSideMenu.Height = btnHome.Height;
            PnlSideMenu.Top = btnHome.Top;
            PnlSideMenu.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void PnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PctBoxLogo_Click(object sender, EventArgs e)
        {

        }


        private void BtnRubrica_Click(object sender, EventArgs e)
        {
            PnlSideMenu.Height = btnRubrica.Height;
            PnlSideMenu.Top = btnRubrica.Top;
            PnlSideMenu.Left = btnRubrica.Left;
            btnRubrica.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnCommissioni_Click(object sender, EventArgs e)
        {
            PnlSideMenu.Height = btnCommissioni.Height;
            PnlSideMenu.Top = btnCommissioni.Top;
            PnlSideMenu.Left = btnCommissioni.Left;
            btnCommissioni.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void BtnScadenze_Click(object sender, EventArgs e)
        {
            PnlSideMenu.Height = btnScadenze.Height;
            PnlSideMenu.Top = btnScadenze.Top;
            PnlSideMenu.Left = btnScadenze.Left;
            btnScadenze.BackColor = Color.FromArgb(46, 51, 73);
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
    }
}
