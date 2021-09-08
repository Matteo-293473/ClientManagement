using ClientManagement.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Observer;

namespace ClientManagement.Resources
{
    public partial class AggiungiCommissione : UserControl, IObserver
    {
        private readonly EditorHandlerAggiungiCommissione editor;
        private readonly CommissionManager commissionManager  = CommissionManager.GetInstance();

        public AggiungiCommissione()
        {
            InitializeComponent();
            editor = new EditorHandlerAggiungiCommissione(txtNome, txtCognome, txtNumeroTelefono, txtEmail, txtDescrizioneCommissione, dtpScadenza);
            commissionManager.AggiungiObserver(this);
        }

        public new void Update()
        {
            cmbCliente.Items.Clear();
            editor.CaricaCmbox(cmbCliente);
        }

        private void btnAggiungiEntry_Click(object sender, EventArgs e)
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

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaNumeri(e);
        }

        private void txtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void btnIndietro_Click_1(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // passo l'item selezionato all'interno della comboBox
            editor.FillFields(cmbCliente.SelectedItem.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            editor.ResetFields();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaSpazi(e);
        }
    }
}
