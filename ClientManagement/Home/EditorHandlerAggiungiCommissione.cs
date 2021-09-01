using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Contatti;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement
{
    class EditorHandlerAggiungiCommissione : EditorHandlerAggiungiContatto
    {

        private TextBox txtDescrizioneCommissione;
        private DateTimePicker dtpScadenza;

        
        public string DescrizioneCommissione { get => txtDescrizioneCommissione.Text; }
        public DateTime Scadenza { get => dtpScadenza.Value; }


        public EditorHandlerAggiungiCommissione(TextBox txtNome, 
            TextBox txtCognome,
            TextBox txtEmail, 
            TextBox txtNumeroTelefono, 
            TextBox txtDescrizioneCommissione, 
            DateTimePicker dtpScadenza) : base(txtNome,
            txtCognome,
            txtEmail,
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
            Controllo.ControlloInputCommissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);

        }



        internal override void InserisciEntry()
        {
            // Controllo i caratteri delle textBox nome e cognome
            CorreggiCaratteri();

            // creazione della commissione cm e del cliente cl 
            Commissione cm = new Commissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);
            Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, txtEmail.Text);

            // aggiungo commissione e cliente al managerCommissioni al cliente
            CommissionManager.AggiungiEntry(cl, cm);
        }




        internal void CaricaCmbox(ComboBox cmb)
        {
            foreach (var i in CommissionManager.Clienti)
            {

                cmb.Items.Add((CommissionManager.Clienti[i.Key].Nome + " " + CommissionManager.Clienti[i.Key].Cognome + " " + CommissionManager.Clienti[i.Key].Numero));

            }
            
        }

        internal void FillFields(string nomeCognomeNumero)
        {
            // prima resettiamo i campi
            ResetFields();

            string[] nomeCognomeNumeroSplit = nomeCognomeNumero.Split(' ');
            
            
            // popoliamo i campi 

            // seleziono la chiave che mi interessa
            var clienteFiltrato = CommissionManager.Clienti.Where(i => (
                    CommissionManager.Clienti[i.Key].Nome == nomeCognomeNumeroSplit[0] &&
                    CommissionManager.Clienti[i.Key].Cognome == nomeCognomeNumeroSplit[1] &&
                    CommissionManager.Clienti[i.Key].Numero == nomeCognomeNumeroSplit[2]))
                .Select(i => i.Key).First(); 
            // al fine di risolvere i problemi con gli omonimi, il cliente viene identificato
            // da tre campi che ne determinano una sorta di superchiave.
            
            // popolo i campi attraverso il cliente trovato
            txtNome.Text = CommissionManager.Clienti[clienteFiltrato].Nome;
            txtCognome.Text = CommissionManager.Clienti[clienteFiltrato].Cognome;
            txtEmail.Text = CommissionManager.Clienti[clienteFiltrato].Email;
            txtNumeroTelefono.Text = CommissionManager.Clienti[clienteFiltrato].Numero;




        }

    }
}
