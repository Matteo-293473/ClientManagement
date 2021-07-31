using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Models;

namespace ClientManagement.Database
{
    class DBHandler : IDatabase
    {
        private readonly string DBPath;
        private static DBHandler instance;

        public static DBHandler GetInstance(string databaseFilePath)
        {
            if (instance == null)
            {
                instance = new DBHandler(databaseFilePath);
            }

            return instance;
        }


        // Qui applichiamo il pattern Singleton.
        // Non vogliamo istanziare due volte DBHandler
        protected DBHandler(string datafile)
        {
            DBPath = datafile;
        }

        public IDictionary<Cliente, List<Commissione>> GetData()
        {
            IDictionary<Cliente, List<Commissione>> clienteCommissioni = null;
            try
            {
                JArray jsonArray = JArray.Parse(File.ReadAllText(DBPath));

                // trasformiamo l'array Json in un dizionario cliente, commissioni
                clienteCommissioni = jsonArray.ToObject<IDictionary<Cliente, List<Commissione>>>();
            }
            catch (Exception)
            {
                clienteCommissioni = new Dictionary<Cliente, List<Commissione>>();
            }

            return clienteCommissioni;
        }

        public void SaveData(IDictionary<Cliente, List<Commissione>> clienteCommissioni)
        {
            JArray commissioniArray = new JArray(
                clienteCommissioni.Select(c => new JObject
                {

                        {"Nome", c.Key.Nome},
                        {"Cognome",c.Key.Cognome},
                        {"Email",c.Key.Email},
                        {"Numero",c.Key.Numero},
                        //{"Descrizione", c.Descrizione},
                        //{"Scadenza", c.Scadenza},

                })
            );

            File.WriteAllText(DBPath, commissioniArray.ToString());
        }
    }
}


