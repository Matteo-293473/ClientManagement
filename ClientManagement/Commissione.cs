using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    public class Commissione
    {
        //protected string stato;
        public DateTime Scadenza { get; set; }
        public string Descrizione { set; get; }

        public Commissione(string descrizione, DateTime scadenza)
        {
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
        }
    }
}
