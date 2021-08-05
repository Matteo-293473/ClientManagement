using ClientManagement.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientManagement.Resources
{

    public partial class aggiungiCommissione : UserControl
    {
        private EditorHandlerAggiungiCommissione editor;

        public aggiungiCommissione()
        {
            InitializeComponent();
            editor = new EditorHandlerAggiungiCommissione(txtNome, txtCognome, cmbEmail, txtNumeroTelefono, txtDescrizioneCommissione, dtpScadenza);
            //ListaClienti.OnListaCambia += Clienti_OnListaCambia;
            CommissionManager.OnClienteCommissioniCambia += AggiungiCommissione_OnListaCambia;
        }

        private void AggiungiCommissione_OnListaCambia(object sender, Dictionary<int, List<Commissione>> clienteCommissioni)
        {
            cmbCliente.Items.Clear();
            editor.CaricaCmbox(cmbCliente);
        }


        private void Appari_OnNuovaCommissione(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void txtNumeroTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            editor.ControllaNumeri(e);
        }

        private void txtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            editor.ControllaCaratteri(e);
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            editor.ControllaCaratteri(e);
        }

        private void aggiungiCommissione_Load(object sender, EventArgs e)
        {

        }

        private void btnIndietro_Click_1(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void cmbEmail_TextChanged(object sender, EventArgs e)
        {
            //----editor.SuggerisciEmail(e);
        }

        private void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void lblCognome_Click(object sender, EventArgs e)
        {

        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
