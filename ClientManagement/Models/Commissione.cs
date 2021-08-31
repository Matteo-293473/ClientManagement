using System;
using System.Collections.Generic;

namespace ClientManagement.Models
{
    public class Commissione
    {
        //protected string stato;

        //public Cliente Cliente { set; get; }
        public DateTime Scadenza { get; set; }
        public string Descrizione { set; get; }
        public bool TaskCompletato { set; get; }
        public int IdCommissione { set; get; }
        // identifichiamo il cliente con questi due campi che fungono da chiavi esterne

        private static int globalId = 1;

        // questo costruttore 
        public Commissione(string descrizione, DateTime scadenza)
        {
            this.IdCommissione = globalId; // ogni Commissione è identificata da un numero
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
            this.TaskCompletato = false;
            globalId++;
        }


        // questo costruttore viene usato solo nel caso di caricamento dei dati, sfruttiamo il meccanismo di overloading
        public Commissione(string descrizione, DateTime scadenza, bool taskCompletato, int idCommissione)
        {
            this.IdCommissione = idCommissione; // ogni Commissione è identificata da un numero
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
            this.TaskCompletato = taskCompletato;
            globalId++;
        }
    }
}
