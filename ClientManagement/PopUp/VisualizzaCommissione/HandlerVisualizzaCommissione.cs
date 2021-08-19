using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.PopUp.VisualizzaCommissione
{
    class HandlerVisualizzaCommissione
    {
        private string nome;
        private string cognome;
        private string email;
        private string numeroTelefono;
        private string descrizione;
        private string dataScadenza;
        private string completato;


        public HandlerVisualizzaCommissione(
            TextBox txtNome,
            TextBox txtCognome,
            TextBox txtEmail,
            TextBox txtNumero,
            TextBox txtDescrizioneCommissione, 
            DateTimePicker dtpScadenza, 
            CheckBox cbxTask)
        {
            this.nome = txtNome.Text;
            this.cognome = txtCognome.Text;
            this.email = txtEmail.Text;
            this.numeroTelefono = txtNumero.Text;
            this.descrizione = txtDescrizioneCommissione.Text;
            this.dataScadenza = dtpScadenza.Value.ToString().Substring(0,10);
            this.completato = cbxTask.Checked ? "Sì" : "No";
        }
    }
}
