using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string Indirizzo { get; set; }
        public int totAcquisti { get; set; }
        public List<Commissione> commissioni { get; set; }

        public Cliente()
        {

        }
    }
}
