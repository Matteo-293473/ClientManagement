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
    public partial class ModificaDati : Form
    {
        public ModificaDati(string nome, string cognome, string email, string numeroTelefono, string scadenza, string descrizione)
        {
            InitializeComponent();
            txtNome.Text = nome;
            txtCognome.Text = cognome;
            cmbEmail.Text = email;
            txtNumeroTelefono.Text = numeroTelefono;
            dtpScadenza.Text = scadenza;
            txtDescrizioneCommissione.Text = descrizione;

            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }

        private void ModificaDati_Load(object sender, EventArgs e)
        {
            
        }
    }
}
