using System.Collections.Generic;

namespace ClientManagement.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }

        // numero di istanze totali che prenderemo come id
        // private int globalId = 0;
        // public int totAcquisti { get; set; }

        // Ogni cliente avrà una lista di commissioni
        // public List<Commissione> Commissioni = new List<Commissione>();

        public Cliente(string nome, string cognome, string numero, string email)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Numero = numero;
            this.Email = email;
            //globalId++;

        }

        

    }
}
