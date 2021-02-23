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
    public partial class CommissioniInScadenza : UserControl
    {
        private EditorCommissioniInScadenza editor;
        public CommissioniInScadenza()
        {
            InitializeComponent();
            editor = new EditorCommissioniInScadenza();
            //ci mettiamo in ascolto di qualche evento
            //l'evento viene generato quando si aggiunge una nuova commissione
            ListaClienti.OnListaCambia += Commissioni_OnListaCambia;
        }

        private void Commissioni_OnListaCambia(object sender, List<Cliente> list)
        {
            editor.AggiornaListView(lstCommissioniScadenza);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CommissioniInScadenza_Load(object sender, EventArgs e)
        {

            editor.AggiornaListView(lstCommissioniScadenza);

        }

        
    }
}
