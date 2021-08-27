using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.Extensions
{
    public static class clienteCommissioniExtensions
    {
        // prendiamo il dizionario, scorporiamo ogni singola commissione e la inseriamo all'interno della listview

        public static ListViewItem ToListViewCliente(this Cliente cliente)
        {
            string[] row = {cliente.Nome, cliente.Cognome, cliente.Numero, cliente.Email};
            return new ListViewItem(row);
        }



        public static ListViewItem ToListViewCommissione(this Commissione commissione)
        {
            string[] row = { commissione.Descrizione , commissione.Scadenza.ToString().Substring(0, 10) , commissione.TaskCompletato?"Sì":"No", commissione.IdCommissione.ToString() };
            return new ListViewItem(row);
        }


        public static Cliente ToCliente(this ListViewItem cliente)
        {
            return new Cliente(
                cliente.SubItems[0].Text,
                cliente.SubItems[1].Text,
                cliente.SubItems[2].Text,
                cliente.SubItems[3].Text
            );
        }

        public static Commissione ToCommissione(this ListViewItem commissione)
        {
            return new Commissione(
                commissione.SubItems[0].Text,
                DateTime.Parse(commissione.SubItems[1].Text)
            );
        }


    }
}
