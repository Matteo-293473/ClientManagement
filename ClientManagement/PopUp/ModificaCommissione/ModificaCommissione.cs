using System;
using System.Windows.Forms;
using ClientManagement.Extensions;

namespace ClientManagement.PopUp.ModificaCommissione
{
    public partial class ModificaCommissione : Form
    {
        private readonly EditorModificaCommissione editorModificaCommissione;
        public ModificaCommissione(int idCommissione)
        {
            InitializeComponent();
            editorModificaCommissione = new EditorModificaCommissione(txtDescrizioneCommissione, dtpScadenza,cbxTask);
            editorModificaCommissione.CaricaDati(idCommissione);
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {

            try
            {
                // controllo input
                Controllo.ControlloInputCommissione(txtDescrizioneCommissione.Text, dtpScadenza.Value, editorModificaCommissione.DtScadenzaOld);

                // funzione che aggiorna la commissione all'interno del dizionario
                editorModificaCommissione.AggiornaCommissione();

                // ripuliamo i campi
                editorModificaCommissione.ResetFields();

                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Input errati: " + err.Message);
            }

        }
    }
}
