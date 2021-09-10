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
    abstract class HandlerCommissioni
    {

        protected readonly DatiLocali DatiLocali = DatiLocali.GetInstance();

        // invece di scrivere due volte la stessa funzione, viene aggiunto un nuovo parametro che serve 
        // a distinguere tra modifica e visualizzazione
        internal void MostraPopUp(ListView lstCommissioniScadenza, UserControl userControl, string opzione)
        {

            // Controllo sulla ListView e sulla selezione dell'elemento
            Controllo.ControlloListViewSelezione(lstCommissioniScadenza);
            // recupero l'id della commissione
            var idCommissione = Convert.ToInt32(lstCommissioniScadenza.SelectedItems[0].SubItems[6].Text);
            // recupero l'id del cliente attraverso la funzione recuperaChiaveCliente
            var idCliente = RecuperaIdClienteSelezionato(lstCommissioniScadenza);


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

        // Eliminazione di una commissione
        internal void Elimina(ListView lstCommissioniScadenza)
        {
            // Controllo sulla ListView e sulla selezione dell'elemento
            Controllo.ControlloListViewSelezione(lstCommissioniScadenza);
            // recupero l'id della commissione
            var idCommissione = Convert.ToInt32(lstCommissioniScadenza.SelectedItems[0].SubItems[6].Text);
            // recupero l'id del cliente attraverso la funzione recuperaChiaveCliente
            var idCliente = RecuperaIdClienteSelezionato(lstCommissioniScadenza);

            DatiLocali.EliminaCommissione(idCommissione, idCliente);

        }

        // Recupero dell'id del cliente selezionato nella listview
        private int RecuperaIdClienteSelezionato(ListView lstCommissioniScadenza)
        {
            return DatiLocali.RecuperaChiaveDaCliente(new Cliente(
                lstCommissioniScadenza.SelectedItems[0].SubItems[0].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[1].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[2].Text,
                lstCommissioniScadenza.SelectedItems[0].SubItems[3].Text
            ));
        }
    }
}
