using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.PopUpModifica;

namespace ClientManagement.PopUp.VisualizzaCommissione
{
    public partial class VisualizzaCommissione : Form
    {
        private HandlerVisualizzaCommissione editor;
        private int idCommissione;
        public VisualizzaCommissione(int idCommissione)
        {
            InitializeComponent();
            this.idCommissione = idCommissione;
            //editor = new HandlerVisualizzaCommissione(lblTextNome, lblTextCognome, lblTextEmail, txtNumeroTelefono);
            //editor.CaricaDati(idCommissione);

            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }
    }
}
