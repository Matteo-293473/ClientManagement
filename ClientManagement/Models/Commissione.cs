using System;
using ClientManagement.Composite;

namespace ClientManagement.Models
{
    public class Commissione : IComponent
    {

        public DateTime Scadenza { get; set; }
        public string Descrizione { set; get; }
        public bool TaskCompletato { set; get; }
        public int IdCommissione { get; }

        private static int _globalId = 1;

        // questo costruttore 
        public Commissione(string descrizione, DateTime scadenza)
        {
            this.IdCommissione = _globalId; // ogni Commissione è identificata da un numero
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
            this.TaskCompletato = false;
            _globalId++;
        }


        // questo costruttore viene usato solo nel caso di caricamento dei dati, sfruttiamo il meccanismo di overloading
        public Commissione(string descrizione, DateTime scadenza, bool taskCompletato, int idCommissione)
        {
            this.IdCommissione = idCommissione; // ogni Commissione è identificata da un numero
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
            this.TaskCompletato = taskCompletato;
            if (idCommissione >= _globalId)
                _globalId = idCommissione+1;
        }


        public string[] ToArrayString()
        {
            string[] row = { 
                this.Descrizione, 
                this.Scadenza.ToString().Substring(0, 10),
                this.IdCommissione.ToString(),
                this.TaskCompletato ? "Sì" : "No"
            }; 
            return row;
        }

    }
}
