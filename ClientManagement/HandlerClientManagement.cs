using System.Drawing;
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

        internal void ColoreSelezione(Button btn, Panel pnl)
        {
            // se viene selezionato abbiamo il colore più chiaro
            pnl.Height = btn.Height;
            pnl.Top = btn.Top;
            pnl.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);

        }
        internal void ColoreDeselezione(Button btn)
        {
            btn.BackColor = Color.FromArgb(13, 8, 20);
        }
    }
}
