using System;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement
{
    class HandlerContatti
    {

        internal void AggiornaListaContatti(ListView lstContatti)
        {

            // inseriamo ogni commissione all'interno della tabella
            lstContatti.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (var i in CommissionManager.Clienti)
            {
                // uso il metodo all'interno del Cliente per inserire l'item
                lst = new ListViewItem(CommissionManager.Clienti[i.Key].ToArrayString());
                lstContatti.Items.Add(lst);
            }

        }

        public void Elimina(ListView lstContatti)
        {
            Controllo.ControlloListViewSelezione(lstContatti);

            // recupero l'id del cliente
            var idCliente = CommissionManager.RecuperaChiaveDaCliente(new Cliente(
                lstContatti.SelectedItems[0].SubItems[0].Text,
                lstContatti.SelectedItems[0].SubItems[1].Text,
                lstContatti.SelectedItems[0].SubItems[3].Text,
                lstContatti.SelectedItems[0].SubItems[2].Text));

            CommissionManager.EliminaCliente(idCliente);
        }

    }
}

