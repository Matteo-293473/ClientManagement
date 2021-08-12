using ClientManagement.Contatti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.PopUp.ModificaCliente
{
    
    public partial class ModificaCliente : Form
    {
        private EditorAggiungiContatto editorAggiungiContatti;
        private EditorModificaCliente editor;
        private int idCliente;
        public ModificaCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            editorAggiungiContatti = new EditorAggiungiContatto(txtNome, txtCognome, txtEmail, txtNumeroTelefono);
            editor.CaricaDati(idCliente);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            editor.AggiornaCommissione(idCliente);
            Close();
        }
    }
}
