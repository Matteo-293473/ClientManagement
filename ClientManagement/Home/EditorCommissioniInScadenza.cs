using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.PopUp.VisualizzaCommissione;

namespace ClientManagement
{
    class EditorCommissioniInScadenza
    {
        private ControlloListView controlloList = new ControlloListView();
        public EditorCommissioniInScadenza()
        {

        }


        // invece di scrivere due volte la stessa funzione, viene aggiunto un nuovo parametro che serve 
        // a distinguere tra modifica e visualizzazione
        internal void MostraPopUp(ListView lstCommissioniScadenza, CommissioniInScadenza commissioniInScadenza, string opzione)
        {

            // controlliamo che la listview non sia vuota
            // oppure che ci sia un elemento selezionato
            // oppure che ci sia un solo elemento selezionato 
            controlloList.ControlloSelezione(lstCommissioniScadenza);

            // recupero l'id della commissione
            var idCommissione = Convert.ToInt32(lstCommissioniScadenza.SelectedItems[0].SubItems[6].Text);


            // recupero l'id del cliente attraverso la funzione recuperaChaiveCliente
            var idCliente = CommissionManager.recuperaChaiveCliente(new Cliente(
                lstCommissioniScadenza.SelectedItems[0].SubItems[0].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[1].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[3].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[2].Text
            ));

             // cognome
             // email

            if (opzione == "modifica")
            {
                var popUpModificaDati = new ModificaCommissione(idCommissione);
                popUpModificaDati.ShowDialog(commissioniInScadenza);
            }
            else if (opzione == "visualizza")
            {
                var popUpVisualizzaDati = new VisualizzaCommissione(idCommissione,idCliente);
                popUpVisualizzaDati.ShowDialog(commissioniInScadenza);
            }
                

                

        }


        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int) date.DayOfWeek);

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[7];

            foreach (var i in CommissionManager.clienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {
                    if (cm.TaskCompletato == false) // se è un task completato non lo inseriamo nella lista
                    {
                        arr[0] = CommissionManager.clienti[i.Key].Nome;
                        arr[1] = CommissionManager.clienti[i.Key].Cognome;
                        arr[2] = CommissionManager.clienti[i.Key].Email;
                        arr[3] = CommissionManager.clienti[i.Key].Numero;
                        arr[4] = cm.Descrizione;
                        arr[5] = cm.Scadenza.ToString().Substring(0, 10); // mostriamo solo la data
                        arr[6] = cm.IdCommissione.ToString();
                        lst = new ListViewItem(arr);

                        //se l'item non esiste allora lo inseriamo
                        if (cm.Scadenza < nextSunday)
                            lstCommissioniScadenza.Items.Add(lst);
                    }
                }
            }

        }
    }
}
