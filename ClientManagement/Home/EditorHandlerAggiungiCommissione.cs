using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    class EditorHandlerAggiungiCommissione
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
        public string DescrizioneCommissione { get => txtDescrizioneCommissione.Text; }
        public DateTime Scadenza { get => dtpScadenza.Value; }

        public List<String> domini = new List<String>()
        {
                "gmail.com",
                "outlook.com",
                "live.com",
                "libero.it",
                "alice.it.com"
        };

        public EditorHandlerAggiungiCommissione(TextBox txtNome, TextBox txtCognome, ComboBox cmbEmail, TextBox txtNumeroTelefono, TextBox txtDescrizioneCommissione, DateTimePicker dtpScadenza)
        {
            this.txtNome = txtNome;
            this.txtCognome = txtCognome;
            this.cmbEmail = cmbEmail;
            this.txtNumeroTelefono = txtNumeroTelefono;
            this.txtDescrizioneCommissione = txtDescrizioneCommissione;
            this.dtpScadenza = dtpScadenza;
        }
        
        internal void ResetFields()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            cmbEmail.Text = "";
            txtNumeroTelefono.Text = "";
            txtDescrizioneCommissione.Text = "";
            dtpScadenza.ResetText();

        }

        internal void ControllaNumeroTelefono(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        internal void ControllaNome(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        internal bool ControllaValiditaInput()
        {
            // controllo degli input
            if ((txtNumeroTelefono.Text.All(char.IsDigit)) && 
                (txtNome.Text.All(char.IsLetter))          && 
                (txtCognome.Text.All(char.IsLetter))       &&
                (dtpScadenza.Value > DateTime.Now))  // controlliamo che non sia una data passata
                return true;
            else
                return false;
            
        }


        internal void CaricaCmbox(ComboBox cmb)
        {
            foreach (var i in Models.CommissionManager.clienteCommissioni)
            {

                cmb.Items.Add((i.Key.Nome +" "+ i.Key.Cognome));

            }
            
        }


        internal void FillFields(string nomeCognome)
        {
            // prima resettiamo i campi
            ResetFields();

            string[] nomeCognomeSplit = nomeCognome.Split(' ');
            
            // popoliamo i campi 
            var clienteFiltrato = CommissionManager.clienteCommissioni.Where(i => (
                i.Key.Nome == nomeCognomeSplit[0] &&
                i.Key.Cognome == nomeCognomeSplit[1]))
                .Select(i => i.Key).First(); //PROBLEMA NON FUNZIONA CON GLI OMONIMI
            
                txtNome.Text = clienteFiltrato.Nome;
                txtCognome.Text = clienteFiltrato.Cognome;
                cmbEmail.Text = clienteFiltrato.Email;
                txtNumeroTelefono.Text = clienteFiltrato.Numero;




        }

        //public void SuggerisciEmail(EventArgs e)
        //{
            
        //    cmbEmail.Items.Clear();
        //    cmbEmail.SelectionStart = cmbEmail.Text.Length;
        //    cmbEmail.DroppedDown = true;
            

        //    // se il testo all'interno non finisce con @ 
        //    if (!cmbEmail.Text.Contains("@"))
        //    {
        //        foreach (string dominio in domini)
        //        {
        //            cmbEmail.Items.Add(cmbEmail.Text + "@" + dominio);
        //        }
        //    }
        //}
    }
}
