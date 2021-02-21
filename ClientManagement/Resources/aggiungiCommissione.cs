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
        private EditorHandler editor;
        public aggiungiCommissione()
        {
            InitializeComponent();
            editor = new EditorHandler(txtNome, txtCognome, txtEmail, txtNumeroTelefono, txtDescrizioneCommissione);

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
            editor.ResetFields();
        }
    }
}
