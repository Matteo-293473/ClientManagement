using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    class HandlerClientManagement
    {
        private Button btnHome;
        private Button btnRubrica;
        private Button btnCommissioni;
        private Button btnScadenze;
        private Panel  pnlSideMenu;

        public HandlerClientManagement(Button btnHome, Button btnRubrica, Button btnCommissioni, Button btnScadenze, Panel pnlSideMenu)
        {
            this.btnHome = btnHome;
            this.btnRubrica = btnRubrica;
            this.btnCommissioni = btnCommissioni;
            this.btnScadenze= btnScadenze;
            this.pnlSideMenu = pnlSideMenu;
        }

        internal void ColoreSelezionato(Button btn, Panel pnl)
        {
            // se viene selezionato abbiamo il colore più chiaro
            pnl.Height = btn.Height;
            pnl.Top = btn.Top;
            pnl.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);

        }

    }
}
