using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;
using ClientManagement.PopUp.VisualizzaCommissione;

namespace ClientManagement.Extensions
{
    class HandlerCommissioni
    {
        // invece di scrivere due volte la stessa funzione, viene aggiunto un nuovo parametro che serve 
        // a distinguere tra modifica e visualizzazione
        internal void MostraPopUp(ListView lstCommissioniScadenza, UserControl userControl, string opzione)
        {

            // controlliamo che la listview non sia vuota
            // oppure che ci sia un elemento selezionato
            // oppure che ci sia un solo elemento selezionato 
            Controllo.ControlloListViewSelezione(lstCommissioniScadenza);

            // recupero l'id della commissione
            var idCommissione = Convert.ToInt32(lstCommissioniScadenza.SelectedItems[0].SubItems[6].Text);


            // recupero l'id del cliente attraverso la funzione recuperaChiaveCliente
            var idCliente = CommissionManager.RecuperaChiaveDaCliente(new Cliente(
                lstCommissioniScadenza.SelectedItems[0].SubItems[0].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[1].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[3].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[2].Text
            ));

            // cognome
            // email

            switch (opzione)
            {
                case "modifica":
                {
                    var popUpModificaDati = new ModificaCommissione(idCommissione);
                    popUpModificaDati.ShowDialog(userControl);
                    break;
                }
                case "visualizza":
                {
                    var popUpVisualizzaDati = new VisualizzaCommissione(idCommissione, idCliente);
                    popUpVisualizzaDati.ShowDialog(userControl);
                    break;
                }
            }


        }

        internal void Elimina(ListView lstCommissioniScadenza)
        {
            // ELIMINARE ELEMENTO
        }
    }
}
