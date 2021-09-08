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

        private readonly TextBox txtDescrizioneCommissione;
        private readonly DateTimePicker dtpScadenza;



        public EditorHandlerAggiungiCommissione(TextBox txtNome, 
            TextBox txtCognome,
            TextBox txtNumeroTelefono,
            TextBox txtEmail, 
            TextBox txtDescrizioneCommissione, 
            DateTimePicker dtpScadenza) : base(txtNome,
            txtCognome,
            txtNumeroTelefono,
            txtEmail)
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
            Cliente cl = new Cliente(TxtNome.Text, TxtCognome.Text, TxtNumeroTelefono.Text, TxtEmail.Text);

            // aggiungo commissione e cliente al managerCommissioni al cliente
            commissionManager.AggiungiEntry(cl, cm);
        }




        internal void CaricaCmbox(ComboBox cmb)
        {
            foreach (var i in commissionManager.Clienti)
            {

                cmb.Items.Add((commissionManager.Clienti[i.Key].Nome + " " + commissionManager.Clienti[i.Key].Cognome + " " + commissionManager.Clienti[i.Key].Numero));

            }
            
        }

        internal void FillFields(string nomeCognomeNumero)
        {
            // prima resettiamo i campi
            ResetFields();

            string[] nomeCognomeNumeroSplit = nomeCognomeNumero.Split(' ');
            
            
            // popoliamo i campi 

            // seleziono la chiave che mi interessa
            var clienteFiltrato = commissionManager.Clienti.Where(i => (
                    commissionManager.Clienti[i.Key].Nome == nomeCognomeNumeroSplit[0] &&
                    commissionManager.Clienti[i.Key].Cognome == nomeCognomeNumeroSplit[1] &&
                    commissionManager.Clienti[i.Key].Numero == nomeCognomeNumeroSplit[2]))
                .Select(i => i.Key).First(); 
            // al fine di risolvere i problemi con gli omonimi, il cliente viene identificato
            // da tre campi che ne determinano una sorta di superchiave.
            
            // popolo i campi attraverso il cliente trovato
            TxtNome.Text = commissionManager.Clienti[clienteFiltrato].Nome;
            TxtCognome.Text = commissionManager.Clienti[clienteFiltrato].Cognome;
            TxtNumeroTelefono.Text = commissionManager.Clienti[clienteFiltrato].Numero;
            TxtEmail.Text = commissionManager.Clienti[clienteFiltrato].Email;

        }

    }
}
