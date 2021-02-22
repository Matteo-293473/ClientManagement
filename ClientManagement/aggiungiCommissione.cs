using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Resources
{

    public partial class aggiungiCommissione : UserControl
    {
        private EditorHandlerAggiungiCommissione editor;

        public aggiungiCommissione()
        {
            InitializeComponent();
            editor = new EditorHandlerAggiungiCommissione(txtNome, txtCognome, txtEmail, txtNumeroTelefono, txtDescrizioneCommissione);

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

                Commissione cm = new Commissione(txtDescrizioneCommissione.Text);
                Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, txtEmail.Text, cm);
                ListaClienti.AggiungiAllaLista(cl);
                // passiamo la nostra entry tra UserControl attraverso eventi
                //InviaEntry?.Invoke(this, entry);
                editor.ResetFields();
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Input errati");
            }
            
        }

        private void txtNumeroTelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            editor.ControllaNumeroTelefono(e);
        }

    }
}
