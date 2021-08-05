using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Contatti;
using ClientManagement.Models;

namespace ClientManagement
{
    class EditorHandlerAggiungiCommissione : EditorAggiungiContatto
    {

        private TextBox txtDescrizioneCommissione;
        private DateTimePicker dtpScadenza;

        
        public string DescrizioneCommissione { get => txtDescrizioneCommissione.Text; }
        public DateTime Scadenza { get => dtpScadenza.Value; }


        public EditorHandlerAggiungiCommissione(TextBox txtNome, 
            TextBox txtCognome, 
            ComboBox cmbEmail, 
            TextBox txtNumeroTelefono, 
            TextBox txtDescrizioneCommissione, 
            DateTimePicker dtpScadenza) : base(txtNome,
            txtCognome,
            cmbEmail,
            txtNumeroTelefono)
        {
            this.txtDescrizioneCommissione = txtDescrizioneCommissione;
            this.dtpScadenza = dtpScadenza;
        }
        
        internal override void ResetFields() 
        {
            // richiamo il metodo della classe padre
            base.ResetFields();

            // estendo il codice
            txtDescrizioneCommissione.Text = "";
            dtpScadenza.ResetText();

        }



        internal override void ControllaValiditaInput()
        {
            base.ControllaValiditaInput();

            if (!txtCognome.Text.All(char.IsLetter))
                throw new Exception("Cognome non valido, ci sono caratteri errati");

            if (dtpScadenza.Value < DateTime.Now)  // controlliamo che non sia una data passata
                throw new Exception("La data non può essere una passata");
        }




        internal override void InserisciEntry()
        {
            // creazione della commissione cm e del cliente cl
            Commissione cm = new Commissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);
            Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, cmbEmail.Text);

            // aggiungo commissione e cliente al managerCommissioni al cliente
            CommissionManager.AggiungiEntry(cl, cm);
        }






        internal void CaricaCmbox(ComboBox cmb)
        {
            foreach (var i in Models.CommissionManager.clienteCommissioni)
            {

                cmb.Items.Add((CommissionManager.clienti[i.Key].Nome + " " + CommissionManager.clienti[i.Key].Cognome + " "+ CommissionManager.clienti[i.Key].Numero));

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
                    CommissionManager.clienti[i.Key].Nome == nomeCognomeNumeroSplit[0] &&
                    CommissionManager.clienti[i.Key].Cognome == nomeCognomeNumeroSplit[1] &&
                    CommissionManager.clienti[i.Key].Email == nomeCognomeNumeroSplit[2]))
                .Select(i => i.Key).First(); 
            // al fine di risolvere i problemi con gli omonimi, il cliente viene identificato
            // da tre campi che ne determinano una sorta di superchiave.
            
            // popolo i campi attraverso il cliente trovato
            txtNome.Text = CommissionManager.clienti[clienteFiltrato].Nome;
            txtCognome.Text = CommissionManager.clienti[clienteFiltrato].Cognome;
            cmbEmail.Text = CommissionManager.clienti[clienteFiltrato].Email;
            txtNumeroTelefono.Text = CommissionManager.clienti[clienteFiltrato].Numero;




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
