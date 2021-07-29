using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class CommissioniInScadenza : UserControl
    {
        private readonly EditorCommissioniInScadenza editor;
        private readonly ModificaDati popUpModificaDati;

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

        private void btnNuovaCommission_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void txtCommissioniScadenza_Click(object sender, EventArgs e)
        {

        }


        private void btnModifica_Click(object sender, EventArgs e)
        {

            //FrmEditBank frm = new FrmEditBank();
            //frm.txtBankId.Text = gvBankCard.GetFocusedRowCellValue("BankId").ToString();
            //frm.cmbBankName.Text = gvBankCard.GetFocusedRowCellValue("BankName").ToString();
            //popUpModificaDati = new ModificaDati(/*lstCommissioniScadenza.FocusedItem(clmNome)*/);


                //(lstCommissioniScadenza.FocusedItem(clmNome).ToString(),
                //lstCommissioniScadenza.FocusedItem(clmCognome).ToString(),
                //lstCommissioniScadenza.FocusedItem(clmEmail).ToString(),
                //lstCommissioniScadenza.FocusedItem(clmNtel).ToString(),
                //lstCommissioniScadenza.FocusedItem(clmNome).ToString());

            popUpModificaDati.ShowDialog(this);
        }
    }
}
