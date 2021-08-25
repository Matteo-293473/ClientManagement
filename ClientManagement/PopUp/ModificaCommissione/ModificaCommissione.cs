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
        private EditorModificaCommissione editorModificaCommissione;
        private int idCommissione;
        public ModificaCommissione(int idCommissione)
        {
            InitializeComponent();
            this.idCommissione = idCommissione;
            editorModificaCommissione = new EditorModificaCommissione(txtDescrizioneCommissione, dtpScadenza,cbxTask);
            editorModificaCommissione.CaricaDati(idCommissione);

            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }

        private void ModificaDati_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            try
            {
                // controllo input
                Controllo.ControlloInputCommissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);

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

        private void cbxTask_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
