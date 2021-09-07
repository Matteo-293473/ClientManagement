using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.PopUp.VisualizzaCommissione
{
    class HandlerVisualizzaCommissione
    {
        private readonly Label lblNome;
        private readonly Label lblCognome;
        private readonly Label lblEmail;
        private readonly Label lblNumeroTelefono;
        private readonly TextBox txtDescrizioneCommissione;
        private readonly Label lblDataScadenza;
        private readonly Label lblCompletato;


        public HandlerVisualizzaCommissione(
            Label txtNome,
            Label txtCognome,
            Label txtEmail,
            Label txtNumero,
            TextBox txtDescrizioneCommissione,
            Label dtpScadenza,
            Label cbxTask)
        {
            this.lblNome = txtNome;
            this.lblCognome = txtCognome;
            this.lblEmail= txtEmail;
            this.lblNumeroTelefono = txtNumero;
            this.txtDescrizioneCommissione = txtDescrizioneCommissione;
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
            this.txtDescrizioneCommissione.Text = cm.Descrizione;
            this.lblDataScadenza.Text = cm.Scadenza.ToString().Substring(0, 10);
            this.lblCompletato.Text = cm.TaskCompletato? "Sì" : "No";
            RegolaFont();
        }

        // nel caso in cui ci siano troppi caratteri a schermo viene abbassata la dimensione del font
        private void RegolaFont()
        {
            var i = lblEmail.Text.Length < 20 ? 10 : 8;
            lblEmail.Font = new Font("Microsoft YaHei", i, FontStyle.Bold);
        }
    }
}
