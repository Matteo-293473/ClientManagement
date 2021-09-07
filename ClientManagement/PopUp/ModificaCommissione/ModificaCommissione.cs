using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.PopUpModifica;

namespace ClientManagement
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

        private void btnModifica_Click(object sender, EventArgs e)
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
