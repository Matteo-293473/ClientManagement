using System;
using System.Drawing;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    class HandlerClientManagement
    {


        public HandlerClientManagement()
        {

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

        internal void ControllaSalvataggio(FormClosingEventArgs e)
        {
            if (CommissionManager.Salvato == false)
            {
                DialogResult dialogResult = MessageBox.Show("Ci sono dati non salvati, uscire lo stesso?", "Uscire", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        }
    }
}
