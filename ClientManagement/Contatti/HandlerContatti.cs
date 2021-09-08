using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement
{
    internal class HandlerContatti
    {
        private readonly CommissionManager commissionManager = CommissionManager.GetInstance();
        internal void AggiornaListaContatti(ListView lstContatti)
        {

            // inseriamo ogni commissione all'interno della tabella
            lstContatti.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (var i in commissionManager.Clienti)
            {
                // uso il metodo all'interno del Cliente per inserire l'item
                var arrayCliente = commissionManager.Clienti[i.Key].ToArrayString();
                for(var j = 0; j < arrayCliente.Length; j++)
                {
                    arr[j] = arrayCliente[j];
                }
                arr[4] = i.Key.ToString();

                lst = new ListViewItem(arr);
                lstContatti.Items.Add(lst);
            }

        }

        public void Elimina(ListView lstContatti)
        {
            Controllo.ControlloListViewSelezione(lstContatti);

            // recupero l'id del cliente
            var idCliente = commissionManager.RecuperaChiaveDaCliente(new Cliente(
                lstContatti.SelectedItems[0].SubItems[0].Text,
                lstContatti.SelectedItems[0].SubItems[1].Text,
                lstContatti.SelectedItems[0].SubItems[2].Text,
                lstContatti.SelectedItems[0].SubItems[3].Text));

            commissionManager.EliminaCliente(idCliente);
        }

    }
}

