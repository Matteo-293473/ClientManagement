using ClientManagement.Models;
using System.Windows.Forms;

namespace ClientManagement.PopUp.ModificaCliente
{
    class EditorModificaCliente
    {
        private readonly TextBox txtNome;
        private readonly TextBox txtCognome;
        private readonly TextBox txtEmail;
        private readonly TextBox txtNumeroTelefono;
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
            // aggiorno i campi
            cl.Nome = txtNome.Text;
            cl.Cognome = txtCognome.Text;
            cl.Email = txtEmail.Text;
            cl.Numero = txtNumeroTelefono.Text;
            CommissionManager.ModificaCliente(cl, idCliente);
        }
    }
}
