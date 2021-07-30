using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class ModificaDati : Form
    {
        public ModificaDati(Commissione commissione)
        {
            InitializeComponent();
            //txtNome.Text = cliente.Nome;
            //txtCognome.Text = cliente.Cognome;
            //cmbEmail.Text = cliente.Email;
            //txtNumeroTelefono.Text = cliente.Numero;
            //dtpScadenza.Value = cliente.Commissioni[numeroCommissione].Scadenza;
            //txtDescrizioneCommissione.Text = cliente.Commissioni[numeroCommissione].Descrizione;

            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }

        private void ModificaDati_Load(object sender, EventArgs e)
        {
            
        }
    }
}
