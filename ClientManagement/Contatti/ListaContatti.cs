using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement.Contatti
{
    public partial class ListaContatti : UserControl
    {
        private HandlerContatti handler;
        private EditorHandlerAggiungiContatto editorAggiungiContatti;
        public ListaContatti()
        {
            InitializeComponent();
            editorAggiungiContatti = new EditorHandlerAggiungiContatto();
            // ci iscriviamo all'evento della lista Clienti
            CommissionManager.OnClientiCambia += Clienti_OnListaCambia;
            handler = new HandlerContatti();
        }

        private void Clienti_OnListaCambia(object sender, Dictionary<int, Cliente> clienti)
        {
            handler.AggiornaListaContatti(lstContatti);
        }

        private void Contatti_Load(object sender, EventArgs e)
        {
            handler.AggiornaListaContatti(lstContatti);
        }

        private void btnNuovoCliente_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }


        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                editorAggiungiContatti.MostraPopUpModifica(lstContatti);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare il cliente?"+
                                                            "\nVerranno rimosse tutte le commissioni associate." +"" +
                                                            "\nL'operazione non è reversibile.", "Eliminare cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    handler.Elimina(lstContatti);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
