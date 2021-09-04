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
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            // inseriamo ogni commissione all'interno della tabella
            lstContatti.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[5];
            foreach (var i in CommissionManager.Clienti)
            {
                arr[0] = CommissionManager.Clienti[i.Key].Nome;
                arr[1] = CommissionManager.Clienti[i.Key].Cognome;
                arr[2] = CommissionManager.Clienti[i.Key].Numero;
                arr[3] = CommissionManager.Clienti[i.Key].Email;
                arr[4] = i.Key.ToString(); 
                lst = new ListViewItem(arr);
                //se l'item non esiste allora lo inseriamo
                //if (!lstCommissioniScadenza.Items.ContainsKey(cl.Numero.ToString()))
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
                lstContatti.SelectedItems[0].SubItems[2].Text,
                lstContatti.SelectedItems[0].SubItems[3].Text));

            CommissionManager.EliminaCliente(idCliente);
        }

    }
}

