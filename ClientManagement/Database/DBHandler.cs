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

        public IList<Models.Commissione> GetData()
        {
            IList<Commissione> commissioni = null;
            try
            {
                JArray jsonArray = JArray.Parse(File.ReadAllText(DBPath));

                // trasformiamo l'array Json in una lista di commissioni
                commissioni = jsonArray.ToObject<IList<Commissione>>();
            }
            catch (Exception)
            {
                commissioni = new List<Commissione>();
            }

            return commissioni;
        }

        public void SaveData(IList<Models.Commissione> commissioni)
        {
            JArray commissioniArray = new JArray(
                commissioni.Select(c => new JObject
                {
                    {"Descrizione", c.Descrizione},
                    {"Scadenza", c.Scadenza},
                })
            );

            File.WriteAllText(DBPath, commissioniArray.ToString());
        }
    }
}
