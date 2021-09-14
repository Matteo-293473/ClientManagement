using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.Observer;
using System;
using System.Windows.Forms;

namespace ClientManagement.Resources
{
    public partial class AggiungiCommissione : UserControl, IObserver
    {
        private readonly EditorHandlerAggiungiCommissione editor;
        private readonly DatiLocali datiLocali = DatiLocali.GetInstance();

        public AggiungiCommissione()
        {
            InitializeComponent();
            editor = new EditorHandlerAggiungiCommissione(txtNome, txtCognome, txtNumeroTelefono, txtEmail, txtDescrizioneCommissione, dtpScadenza);
            datiLocali.AggiungiObserver(this);
        }

        // observer pattern
        public new void Update()
        {
            cmbCliente.Items.Clear();
            editor.CaricaCmbBox(cmbCliente);
        }

        private void BtnAggiungiEntry_Click(object sender, EventArgs e)
        {
            try
            {
                // controllo input 
                editor.ControllaValiditaInput();

                // funzione che crea una nuova commissione, nuovo cliente e l'associazione nel dizionario
                editor.InserisciEntry();

                // ripuliamo i campi
                editor.ResetFields();
            }
            catch (Exception err)
            {
                MessageBox.Show("Input errati: " + err.Message);
            }

        }

        private void TxtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaNumeri(e);
        }

        private void TxtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void BtnIndietro_Click_1(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void CmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // passo l'item selezionato all'interno della comboBox
            editor.FillFields(cmbCliente.SelectedItem.ToString());
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            editor.ResetFields();
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaSpazi(e);
        }
    }
}
