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


        // Sfruttando l'override e il polimorfismo, estendiamo la funzione della classe base e
        // aggiungiamo un controllo anche alla commissione
        internal override void ControllaValiditaInput()
        {
            base.ControllaValiditaInput();
            Controllo.ControlloInputCommissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);

        }


        // Sfruttando l'override e il polimorfismo, riscriviamo il metodo riadattandolo anche alle commissioni
        internal override void InserisciEntry()
        {
            // Controllo i caratteri delle textBox nome e cognome
            CorreggiCaratteri();

            // creazione della commissione cm e del cliente cl 
            Commissione cm = new Commissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);
            Cliente cl = new Cliente(TxtNome.Text, TxtCognome.Text, TxtNumeroTelefono.Text, TxtEmail.Text);

            // aggiungo commissione e cliente al managerCommissioni al cliente
            DatiLocali.AggiungiEntry(cl, cm);
        }



        // Metodo semplice che carica la combo box alla compilazione automatica dei campi in base
        // al cliente scelto
        internal void CaricaCmbox(ComboBox cmb)
        {
            foreach (var i in DatiLocali.Clienti)
            {

                cmb.Items.Add((DatiLocali.Clienti[i.Key].Nome + " " + DatiLocali.Clienti[i.Key].Cognome + " " + DatiLocali.Clienti[i.Key].Numero));

            }
            
        }

        // Metodo che carica i campi in base all'elemento selezionato nella combo box
        internal void FillFields(string nomeCognomeNumero)
        {
            // prima resettiamo i campi
            ResetFields();

            string[] nomeCognomeNumeroSplit = nomeCognomeNumero.Split(' ');
            
            
            // popoliamo i campi 

            // seleziono la chiave che mi interessa attraverso una query, sfruttando la libreria LINQ
            var clienteFiltrato = DatiLocali.Clienti.Where(i => (
                    DatiLocali.Clienti[i.Key].Nome == nomeCognomeNumeroSplit[0] &&
                    DatiLocali.Clienti[i.Key].Cognome == nomeCognomeNumeroSplit[1] &&
                    DatiLocali.Clienti[i.Key].Numero == nomeCognomeNumeroSplit[2]))
                .Select(i => i.Key).First(); 
            // al fine di risolvere i problemi con gli omonimi, il cliente viene identificato
            // da tre campi che ne determinano una sorta di superchiave.
            
            // popolo i campi attraverso il cliente trovato
            TxtNome.Text = DatiLocali.Clienti[clienteFiltrato].Nome;
            TxtCognome.Text = DatiLocali.Clienti[clienteFiltrato].Cognome;
            TxtNumeroTelefono.Text = DatiLocali.Clienti[clienteFiltrato].Numero;
            TxtEmail.Text = DatiLocali.Clienti[clienteFiltrato].Email;

        }

    }
}
