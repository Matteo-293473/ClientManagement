﻿using System;
using System.Windows.Forms;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement.Contatti
{
    public partial class ListaContatti : UserControl, IObserver
    {
        private readonly HandlerContatti handler;
        private readonly EditorHandlerAggiungiContatto editorAggiungiContatti;

        public ListaContatti()
        {
            InitializeComponent();
            editorAggiungiContatti = new EditorHandlerAggiungiContatto();
            var datiLocali = DatiLocali.GetInstance();
            handler = new HandlerContatti();

            // ci iscriviamo all'evento
            datiLocali.AggiungiObserver(this);

        }

        // observer pattern
        public new void Update()
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
