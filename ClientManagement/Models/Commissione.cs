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
        
        private int CodiceCommissione { set; get; }

        private bool TaskCompletato { set; get; }
        // identifichiamo il cliente con questi due campi che fungono da chiavi esterne


        public Commissione(string descrizione, DateTime scadenza)
        {
            this.Descrizione = descrizione;
            this.Scadenza = scadenza;
            this.TaskCompletato = false;
        }
    }
}
