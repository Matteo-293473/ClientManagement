using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Models;

namespace ClientManagement.DataBase
{
    class DBHandler : IDatabase
    {
        private readonly string DBPath;
        private static DBHandler instance;

        public static DBHandler GetInstance(string databaseFilePath)
        {
            if (instance == null)
            {
                instance = new DBHandler(databaseFile);
            }

            return instance;
        }

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
                commissioni.Select(i => new JObject
                {
                    {" "},
                    {" "},
                    {" "},
                })
            );

            File.WriteAllText(DBPath, commissioniArray.ToString());
        }
    }
}
