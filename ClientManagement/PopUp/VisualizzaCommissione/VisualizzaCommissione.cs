using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.PopUp.VisualizzaCommissione
{
    public partial class VisualizzaCommissione : Form
    {
        public VisualizzaCommissione(int idCommissione,int idCliente)
        {
            InitializeComponent();
            var editor = new HandlerVisualizzaCommissione(lblTxtNome, lblTxtCognome, lblTxtEmail, lblTxtNumeroTel,txtDescrizioneCommissione,lblTxtScadenza, lblTxtCompletato);
            editor.CaricaDati(idCommissione,idCliente);
        }
    }
}
