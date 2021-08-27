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
        private readonly string DBPathClienti;
        private readonly string DBPathCommissioni;
        private static DBHandler instance;

        // Design Pattern : Singleton
        public static DBHandler GetInstance(string databaseFilePathClienti,string databaseFilePathCommissioni)
        {
            if (instance == null)
            {
                instance = new DBHandler(databaseFilePathClienti, databaseFilePathCommissioni);
            }

            return instance;
        }
        //1:04 DEL VIDEO


        // Qui applichiamo il pattern Singleton.
        // Non vogliamo istanziare due volte DBHandler
        protected DBHandler(string datafileClienti,string datafileCommissioni)
        {
            DBPathClienti = datafileClienti;
            DBPathCommissioni = datafileCommissioni;
        }

        public IDictionary<int, Cliente> GetDataClienti()
        {
            IDictionary<int, Cliente> clienti = null;
            try
            {
                JArray jsonArray = JArray.Parse(File.ReadAllText(DBPathClienti));

                // trasformiamo l'array Json in un dizionario cliente, commissioni
                clienti = jsonArray.ToObject<IDictionary<int, Cliente>>();
            }
            catch (Exception)
            {
                clienti = new Dictionary<int, Cliente>();
            }

            return clienti;
        }


        public IDictionary<int, List<Commissione>> GetDataCommissioni()
        {
            IDictionary<int, List<Commissione>> commissioni = null;
            try
            {
                JArray jsonArray = JArray.Parse(File.ReadAllText(DBPathCommissioni));

                // trasformiamo l'array Json in un dizionario cliente, commissioni
                commissioni = jsonArray.ToObject<IDictionary<int, List<Commissione>>>();
            }
            catch (Exception)
            {
                commissioni = new Dictionary<int, List<Commissione>>();
            }

            return commissioni;
        }

        public void SaveDataClienti(IDictionary<int, Cliente> cliente)
        {
            var clientiJArray = new JArray();

            foreach (var i in from i in cliente
                let temp = i.Value
                select i)
            {
                clientiJArray.Add(new JObject
                {

                    {"Nome", cliente[i.Key].Nome},
                    {"Cognome", cliente[i.Key].Cognome},
                    {"Email", cliente[i.Key].Email},
                    {"Numero", cliente[i.Key].Numero},

                });
            }

            File.WriteAllText(DBPathClienti, clientiJArray.ToString());
        }

        public void SaveDataCommissioni(IDictionary<int, List<Commissione>> commissioni)
        {
            var commissioniJArray = new JArray();

            foreach (var i in commissioni)
            {
                var temp = i.Value;
                foreach (Commissione cm in temp)
                {

                    commissioniJArray.Add(new JObject
                    {

                        {"Descrizione", cm.Descrizione},
                        {"Scadenza", cm.Scadenza},
                        {"TaskCompletato", cm.TaskCompletato},
                        {"IdCommissione", cm.IdCommissione},

                    });
                }
            }

            File.WriteAllText(DBPathCommissioni, commissioniJArray.ToString());
        }
    }

}


