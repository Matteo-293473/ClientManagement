using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.PopUpModifica
{
    class EditorModificaDati
    {
        private TextBox txtDescrizioneCommissione;
        private DateTimePicker dtpScadenza;
        private Commissione cm;

        public string DescrizioneCommissione { get => txtDescrizioneCommissione.Text; }
        public DateTime Scadenza { get => dtpScadenza.Value; }


        public EditorModificaDati(TextBox txtDescrizioneCommissione, DateTimePicker dtpScadenza) 
        {
            this.txtDescrizioneCommissione = txtDescrizioneCommissione;
            this.dtpScadenza = dtpScadenza;
        }

        public void CaricaDati(int idCommissione)
        {

            // Ci viene restituita la commissione che selezionata
            this.cm = CommissionManager.RestituisciCommissione(idCommissione);
            
            txtDescrizioneCommissione.Text = cm.Descrizione;
            dtpScadenza.Value = cm.Scadenza;


        }

        public void AggiornaCommissione()
        {
           CommissionManager.ModificaCommissione(cm);
        }

    }
}
