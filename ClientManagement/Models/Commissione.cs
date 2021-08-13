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

        public Commissione(string descrizione, DateTime scadenza)
        {
            this.IdCommissione = globalId; // ogni Commissione è identificata da un numero
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
            this.TaskCompletato = false;
            globalId++;
        }
    }
}
