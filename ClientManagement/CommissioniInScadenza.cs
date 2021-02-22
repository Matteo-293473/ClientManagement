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

        public CommissioniInScadenza()
        {
            InitializeComponent();

            //ci mettiamo in ascolto di qualche evento
            //l'evento viene generato quando si aggiunge una nuova commissione
            ListaClienti.OnListaCambia += Commissioni_OnListaCambia;
        }

        private void Commissioni_OnListaCambia(object sender, List<Cliente> list)
        {
            lstCommissioniScadenza.Items.Clear();
            AggiornaListView();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CommissioniInScadenza_Load(object sender, EventArgs e)
        {

            AggiornaListView();

        }

        private void AggiornaListView()
        {
            // inseriamo ogni commissione all'interno della tabella
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (Cliente cl in ListaClienti.clienti)
                foreach (Commissione cm in cl.Commissioni)
                {
                    arr[0] = cl.Nome;
                    arr[1] = cl.Cognome;
                    arr[2] = cl.Email;
                    arr[3] = cl.Numero;
                    arr[4] = cm.Descrizione;
                    lst = new ListViewItem(arr);
                    lstCommissioniScadenza.Items.Add(lst);
                }

        }
    }
}
