using ClientManagement.Contatti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Extensions;

namespace ClientManagement.PopUp.ModificaCliente
{
    
    public partial class ModificaCliente : Form
    {
        private readonly EditorHandlerAggiungiContatto editorAggiungiContatti;
        private readonly EditorModificaCliente editorModificaCliente;
        private readonly int idCliente;
        public ModificaCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            editorAggiungiContatti = new EditorHandlerAggiungiContatto(txtNome, txtCognome, txtNumeroTelefono, txtEmail);
            editorModificaCliente = new EditorModificaCliente(txtNome, txtCognome, txtNumeroTelefono, txtEmail);
            editorModificaCliente.CaricaDati(idCliente);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                // controllo input
                editorAggiungiContatti.ControllaValiditaInput();

                // richiamo la funzione che aggiorna la commissione
                editorModificaCliente.AggiornaCommissione(idCliente);

                // ripuliamo i campi
                editorAggiungiContatti.ResetFields();

                // chiudo la finestra
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Input errati: " + err.Message);
            }
            
        }


        // Piccolo controllo sui caratteri delle textBox
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void txtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaNumeri(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaSpazi(e);
        }
    }
}
