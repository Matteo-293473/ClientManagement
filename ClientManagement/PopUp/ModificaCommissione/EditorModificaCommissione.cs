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
        private readonly TextBox txtDescrizioneCommissione;
        private readonly DateTimePicker dtpScadenza;
        private readonly CheckBox cbxTask;
        private Commissione cm;
        private readonly CommissionManager commissionManager = CommissionManager.GetInstance();

        // nel caso in cui segniamo il task completo, potrebbe succedere che
        // non si possa modificare poiché la data è passata. La data quindi viene segnata
        // e viene aggiunta come eccezione 
        public DateTime DtScadenzaOld;


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
            this.cm = commissionManager.RestituisciCommissione(idCommissione);
            
            txtDescrizioneCommissione.Text = cm.Descrizione;
            dtpScadenza.Value = cm.Scadenza;
            DtScadenzaOld = cm.Scadenza;


        }

        public void AggiornaCommissione()
        {
            // aggiorno i campi
            cm.Descrizione = txtDescrizioneCommissione.Text;
            cm.Scadenza = dtpScadenza.Value;
            cm.TaskCompletato = cbxTask.Checked;
            commissionManager.ModificaCommissione(cm);
        }

    }
}
