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
        // diamo la visibilità anche alle classi derivate
        protected TextBox txtNome;
        protected TextBox txtCognome;
        protected readonly ComboBox cmbEmail;
        protected TextBox txtNumeroTelefono;

        public string Nome { get => txtNome.Text; }
        public string Cognome { get => txtCognome.Text; }
        public string Email { get => cmbEmail.Text; }
        public string NumeroTelefono { get => txtNumeroTelefono.Text; }

        public List<String> domini = new List<String>()
        {
                "gmail.com",
                "outlook.com",
                "live.com",
                "libero.it",
                "alice.it.com"
        };

        //OK
        public EditorAggiungiContatto(TextBox txtNome, TextBox txtCognome, ComboBox cmbEmail, TextBox txtNumeroTelefono)
        {
            this.txtNome = txtNome;
            this.txtCognome = txtCognome;
            this.cmbEmail = cmbEmail;
            this.txtNumeroTelefono = txtNumeroTelefono;
        }

        //OK
        internal virtual void ResetFields()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbEmail.Text = "";
            txtNumeroTelefono.Text = "";

        }

        internal void ControllaNumeri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        internal void ControllaCaratteri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        // OK
        internal virtual void ControllaValiditaInput()
        {
            // eliminiamo degli spazi e caratteri indesiderati alla fine dei nomi
            var nome = txtNome.Text.Split(' ');
            var cognome = txtCognome.Text.Split(' ');
            txtNome.Text = nome[0];
            txtCognome.Text = cognome[0];


            // controllo degli input
            if (!txtNumeroTelefono.Text.All(char.IsDigit))
                throw new Exception("Numero di telefono non valido");

            if (!txtNome.Text.All(char.IsLetter))
                throw new Exception("Nome non valido, ci sono caratteri errati");


            

        }



    }
}
