using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        //public int totAcquisti { get; set; }
        public List<Commissione> Commissioni = new List<Commissione>();

        public Cliente(string nome, string cognome, string numero, string email, Commissione cm)
        {

            this.Nome = nome;
            this.Cognome = cognome;
            this.Numero = numero;
            this.Email = email;
            Commissioni.Add(cm);

        }

    }
}
