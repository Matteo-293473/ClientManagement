using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.Contatti
{
    public partial class ListaContatti : UserControl
    {
        private EditorContatti editor;
        public ListaContatti()
        {
            InitializeComponent();
            // ci iscriviamo all'evento della lista clienti
            CommissionManager.OnClientiCambia += Clienti_OnListaCambia;
            editor = new EditorContatti();
        }

        private void Clienti_OnListaCambia(object sender, Dictionary<int, Cliente> clienti)
        {
            editor.AggiornaListaContatti(lstContatti);
        }

        private void Contatti_Load(object sender, EventArgs e)
        {
            editor.AggiornaListaContatti(lstContatti);
        }

        private void btnNuovoCliente_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
