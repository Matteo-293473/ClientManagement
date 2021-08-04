using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Contatti;
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

        internal void ControllaNumeri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        internal void ControllaCaratteri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        internal void ControllaValiditaInput()
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


            if (!txtCognome.Text.All(char.IsLetter))
                throw new Exception("Cognome non valido, ci sono caratteri errati");

            if(dtpScadenza.Value < DateTime.Now)  // controlliamo che non sia una data passata
                throw new Exception("La data non può essere una passata");


        }


        internal void InserisciCommissioneCliente()
        {
            // creazione della commissione cm e del cliente cl
            Commissione cm = new Commissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);
            Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, cmbEmail.Text);

            // aggiungo commissione e cliente al managerCommissioni al cliente
            CommissionManager.AggiungiClienteCommissione(cl, cm);
        }








        internal void CaricaCmbox(ComboBox cmb)
        {
            foreach (var i in Models.CommissionManager.clienteCommissioni)
            {

                cmb.Items.Add((i.Key.Nome +" "+ i.Key.Cognome +" "+ i.Key.Numero ));

            }
            
        }


        internal void FillFields(string nomeCognomeNumero)
        {
            // prima resettiamo i campi
            ResetFields();

            string[] nomeCognomeNumeroSplit = nomeCognomeNumero.Split(' ');
            
            
            // popoliamo i campi 

            // seleziono la chiave che mi interessa
            var clienteFiltrato = CommissionManager.clienteCommissioni.Where(i => (
                i.Key.Nome == nomeCognomeNumeroSplit[0] &&
                i.Key.Cognome == nomeCognomeNumeroSplit[1] && 
                i.Key.Numero == nomeCognomeNumeroSplit[2]))
                .Select(i => i.Key).First(); 
            // al fine di risolvere i problemi con gli omonimi, il cliente viene identificato
            // da tre campi che ne determinano una sorta di superchiave.
            
            // popolo i campi attraverso il cliente ricavato
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
