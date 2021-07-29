using System.Collections.Generic;

namespace ClientManagement.Models
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }

        // numero di istanze totali che prenderemo come id
        public static int globalId = 0;
        //public int totAcquisti { get; set; }
        public List<Commissione> Commissioni = new List<Commissione>();

        public Cliente(string nome, string cognome, string numero, string email, Commissione cm)
        {
            this.Id = globalId;
            this.Nome = nome;
            this.Cognome = cognome;
            this.Numero = numero;
            this.Email = email;
            Commissioni.Add(cm);
            globalId++;

        }

    }
}
