using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
                if (!editor.ControllaValiditaInput())
                    throw new Exception();
                //Cliente = new Cliente(txtNome,txtCognome,txtEmail,txt)
                //Entry entry = new Entry();

                Commissione cm = new Commissione(txtDescrizioneCommissione.Text, dtpScadenza.Value);
                Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, cmbEmail.Text, cm);
                ListaClienti.AggiungiAllaLista(cl);
                // passiamo la nostra entry tra UserControl attraverso eventi
                //InviaEntry?.Invoke(this, entry);
                editor.ResetFields();
            }
            catch(Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Input errati " + err.Message);
            }
            
        }

        private void txtNumeroTelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            editor.ControllaNumeroTelefono(e);
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
    }
}
