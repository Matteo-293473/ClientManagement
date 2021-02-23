using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Contatti : UserControl
    {
        private EditorContatti editor;
        public Contatti()
        {
            InitializeComponent();
            ListaClienti.OnListaCambia += Clienti_OnListaCambia;
            editor = new EditorContatti();

        }

        private void Clienti_OnListaCambia(object sender, List<Cliente> list)
        {
            editor.AggiornaListaContatti(lstContatti);
        }

        private void Contatti_Load(object sender, EventArgs e)
        {
            editor.AggiornaListaContatti(lstContatti);
        }
    }
}
