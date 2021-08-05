using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Database;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class CommissioniInScadenza : UserControl
    {
        //private IDictionary<Cliente, List<Commissione>> clienteCommissioni = new Dictionary<Cliente, List<Commissione>>();
        //private readonly IDatabase db;

        private readonly EditorCommissioniInScadenza editor;
       
        public CommissioniInScadenza()
        {
            InitializeComponent();

            //this.db = db;
            //LoadStorage();

            editor = new EditorCommissioniInScadenza();
            //ci mettiamo in ascolto di qualche evento
            //l'evento viene generato quando si aggiunge una nuova commissione

            CommissionManager.OnClienteCommissioniCambia += Commissioni_OnListaCambia;
            
        }


        //private void LoadStorage()
        //{
        //    clienteCommissioni = db.GetData();
        //    this.lstCommissioniScadenza.Clear();
        //    string[] arr = new string[6];
        //    ListViewItem lst;
        //    foreach (var i in Models.CommissionManager.clienteCommissioni)
        //    {
        //        List<Commissione> temp = i.Value;
        //        foreach (Commissione cm in temp)
        //        {

        //            arr[0] = i.Key.Nome;
        //            arr[1] = i.Key.Cognome;
        //            arr[2] = i.Key.Email;
        //            arr[3] = i.Key.Numero;
        //            arr[4] = cm.Descrizione;
        //            arr[5] = cm.Scadenza.ToString();
        //            lst = new ListViewItem(arr);

                   
        //           lstCommissioniScadenza.Items.Add(lst);

        //        }
        //    }
        //}


        private void Commissioni_OnListaCambia(object sender, Dictionary<int, List<Commissione>> clienteCommissioni)
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

        private void btnNuovaCommission_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void txtCommissioniScadenza_Click(object sender, EventArgs e)
        {

        }


        //private void BtnModifica_Click(object sender, EventArgs e,Cliente c)
        //{

        //    //FrmEditBank frm = new FrmEditBank();
        //    //frm.txtBankId.Text = gvBankCard.GetFocusedRowCellValue("BankId").ToString();
        //    //frm.cmbBankName.Text = gvBankCard.GetFocusedRowCellValue("BankName").ToString();
        //    //popUpModificaDati = new ModificaDati(/*lstCommissioniScadenza.FocusedItem(clmNome)*/);


        //    //(lstCommissioniScadenza.FocusedItem(clmNome).ToString(),
        //    //lstCommissioniScadenza.FocusedItem(clmCognome).ToString(),
        //    //lstCommissioniScadenza.FocusedItem(clmEmail).ToString(),
        //    //lstCommissioniScadenza.FocusedItem(clmNtel).ToString(),
        //    //lstCommissioniScadenza.FocusedItem(clmNome).ToString());
            
          
        //}

        private void btnModifica_Click(object sender, EventArgs e)
        {

            //var popUpModificaDati = new ModificaDati(, 0);
            //popUpModificaDati.ShowDialog(this);
        }
    }
}
