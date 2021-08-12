using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.PopUp.ModificaCliente
{
    class EditorModificaCliente
    {
        protected TextBox txtNome;
        protected TextBox txtCognome;
        protected TextBox txtEmail;
        protected TextBox txtNumeroTelefono;
        private Cliente cl;



        public EditorModificaCliente(TextBox txtNome, TextBox txtCognome, TextBox txtEmail, TextBox txtNumeroTelefono)
        {
            this.txtNome = txtNome;
            this.txtCognome = txtCognome;
            this.txtEmail = txtEmail;
            this.txtNumeroTelefono = txtNumeroTelefono;
        }


        public void CaricaDati(int idCliente)
        {

            // Ci viene restituito il cliente selezionato
            this.cl = CommissionManager.RestituisciCliente(idCliente);

            txtNome.Text = cl.Nome;
            txtCognome.Text = cl.Cognome;
            txtEmail.Text = cl.Email;
            txtNumeroTelefono.Text = cl.Numero;


        }

        internal void AggiornaCommissione(int idCliente)
        {
            //CommissionManager.ModificaCliente(idCliente);
        }
    }
}
