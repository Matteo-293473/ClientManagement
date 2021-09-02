using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Composite;

namespace ClientManagement.Models
{
    // usiamo il design pattern composite. Cliente è una foglia del pattern
    public class Cliente : IComponent
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string cognome, string numero, string email)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Numero = numero;
            this.Email = email;
            //globalId++;

        }


        

        public ListViewItem ToListView()
        {
            string[] row = { this.Nome, this.Cognome, this.Numero, this.Email };
            return new ListViewItem(row);
        }


    }
}
