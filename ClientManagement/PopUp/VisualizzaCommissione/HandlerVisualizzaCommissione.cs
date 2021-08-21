using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.PopUp.VisualizzaCommissione
{
    class HandlerVisualizzaCommissione
    {
        private Label lblNome;
        private Label lblCognome;
        private Label lblEmail;
        private Label lblNumeroTelefono;
        private Label lblDescrizione;
        private Label lblDataScadenza;
        private Label lblCompletato;


        public HandlerVisualizzaCommissione(
            Label txtNome,
            Label txtCognome,
            Label txtEmail,
            Label txtNumero,
            Label txtDescrizioneCommissione,
            Label dtpScadenza,
            Label cbxTask)
        {
            this.lblNome = txtNome;
            this.lblCognome = txtCognome;
            this.lblEmail= txtEmail;
            this.lblNumeroTelefono = txtNumero;
            this.lblDescrizione = txtDescrizioneCommissione;
            this.lblDataScadenza = dtpScadenza;
            this.lblCompletato = cbxTask;
        }

        public void CaricaDati(int idCommissione, int idCliente)
        {
            // cerchiamo cliente e commissione
            Cliente cl = CommissionManager.RestituisciCliente(idCliente);
            Commissione cm = CommissionManager.RestituisciCommissione(idCommissione);

            // aggiorniamo i dati
            this.lblNome.Text = cl.Nome;
            this.lblCognome.Text = cl.Cognome;
            this.lblEmail.Text = cl.Email;
            this.lblNumeroTelefono.Text = cl.Numero;
            this.lblDescrizione.Text = cm.Descrizione;
            this.lblDataScadenza.Text = cm.Scadenza.ToString().Substring(0, 10);
            this.lblCompletato.Text = cm.TaskCompletato? "Sì" : "No";
        }
    }
}
