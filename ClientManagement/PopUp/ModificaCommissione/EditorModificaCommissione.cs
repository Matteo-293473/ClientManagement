using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.PopUpModifica
{
    class EditorModificaCommissione
    {
        private TextBox txtDescrizioneCommissione;
        private DateTimePicker dtpScadenza;
        private CheckBox cbxTask;
        private Commissione cm;

        public string DescrizioneCommissione { get => txtDescrizioneCommissione.Text; }
        public DateTime Scadenza { get => dtpScadenza.Value; }


        public EditorModificaCommissione(TextBox txtDescrizioneCommissione, DateTimePicker dtpScadenza,CheckBox cbxTask) 
        {
            this.txtDescrizioneCommissione = txtDescrizioneCommissione;
            this.dtpScadenza = dtpScadenza;
            this.cbxTask = cbxTask;
        }

        public void ResetFields()
        {
            txtDescrizioneCommissione.Text = "";
            dtpScadenza.ResetText();
            cbxTask.Checked = false;
        }

        public void CaricaDati(int idCommissione)
        {

            // Ci viene restituita la commissione selezionata
            this.cm = CommissionManager.RestituisciCommissione(idCommissione);
            
            txtDescrizioneCommissione.Text = cm.Descrizione;
            dtpScadenza.Value = cm.Scadenza;


        }

        public void AggiornaCommissione()
        {
            // aggiorno i campi
            cm.Descrizione = txtDescrizioneCommissione.Text;
            cm.Scadenza = dtpScadenza.Value;
            cm.TaskCompletato = cbxTask.Checked;
            CommissionManager.ModificaCommissione(cm);
        }

    }
}
