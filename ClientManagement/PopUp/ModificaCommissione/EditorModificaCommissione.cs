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
            Commissione cm = CommissionManager.RestituisciCommissione(idCommissione);

            txtDescrizioneCommissione.Text = cm.Descrizione;
            dtpScadenza.Value = cm.Scadenza;


        }

        public void AggiornaCommissione(int idCommissione)
        {
           CommissionManager.ModificaCommissione(idCommissione,txtDescrizioneCommissione.Text, dtpScadenza.Value);
        }

    }
}
