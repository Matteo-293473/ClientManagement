using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Contatti
{
    class EditorAggiungiContatto
    {
        private TextBox txtNome;
        private TextBox txtCognome;
        private readonly ComboBox cmbEmail;
        private TextBox txtNumeroTelefono;
        private TextBox txtDescrizioneCommissione;
        private DateTimePicker dtpScadenza;

        public string Nome { get => txtNome.Text; }
        public string Cognome { get => txtCognome.Text; }
        public string Email { get => cmbEmail.Text; }
        public string NumeroTelefono { get => txtNumeroTelefono.Text; }

        public EditorAggiungiContatto()
        {


        }

        internal void AggiornaListView()
        {
            
             
           

        }
    }
}
