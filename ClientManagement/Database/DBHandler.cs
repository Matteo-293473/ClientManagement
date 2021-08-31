using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Models;
using Newtonsoft.Json;

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
                var jsonObject = JArray.Parse(File.ReadAllText(DBPathClienti));

                
                var lista = jsonObject
                    .Cast<JObject>()
                    .Select(o => new KeyValuePair<int, Cliente>(
                        (int) o.PropertyValues().ElementAtOrDefault(0),
                        new Cliente((string) o.PropertyValues().ElementAtOrDefault(1),
                            (string) o.PropertyValues().ElementAtOrDefault(2),
                            (string) o.PropertyValues().ElementAtOrDefault(3),
                            (string) o.PropertyValues().ElementAtOrDefault(4))))
                    .ToList();
                clienti = lista.ToDictionary(p => p.Key, p => p.Value);
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
                commissioni = new Dictionary<int, List<Commissione>>();

                var jsonObject = JArray.Parse(File.ReadAllText(DBPathCommissioni));


                // ci creiamo prima una lista generica contenente id e commissione
                //var listaCommissioni = jsonObject
                //    .Cast<JObject>()
                //    .Select(o => new List<object>
                //    {
                //        (int) o.PropertyValues().ElementAtOrDefault(0),
                //        new Commissione((string) o.PropertyValues().ElementAtOrDefault(1),
                //            (DateTime) o.PropertyValues().ElementAtOrDefault(2),
                //            (bool) o.PropertyValues().ElementAtOrDefault(3),
                //            (int) o.PropertyValues().ElementAtOrDefault(4))
                //    }).ToList();

                var listaCommissioni = jsonObject
                    .Cast<JObject>()
                    .Select(o => new object[]
                    {
                        (int) o.PropertyValues().ElementAtOrDefault(0),
                        new Commissione((string) o.PropertyValues().ElementAtOrDefault(1),
                            (DateTime) o.PropertyValues().ElementAtOrDefault(2),
                            (bool) o.PropertyValues().ElementAtOrDefault(3),
                            (int) o.PropertyValues().ElementAtOrDefault(4))
                    }).ToArray();

                



                for (var i = 0; i < listaCommissioni.LongLength; i++)
                {
                    for (var j = 0; j < listaCommissioni.Length; j += listaCommissioni.Length)
                    {
                        var listCommissioniTemp = new List<Commissione>();

                        if (commissioni.ContainsKey((int) listaCommissioni[i][j]))
                        {
                            listCommissioniTemp = commissioni[(int)listaCommissioni[i][j]];
                            listCommissioniTemp.Add((Commissione)listaCommissioni[i][j + 1]);
                            commissioni[(int)listaCommissioni[i][j]] =  listCommissioniTemp;
                        }
                        else
                        {
                            listCommissioniTemp.Add((Commissione) listaCommissioni[i][j + 1]);
                            commissioni.Add((int) listaCommissioni[i][j], listCommissioniTemp);
                        }
                    }
                }


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
                    {"Id", i.Key},
                    {"Nome", cliente[i.Key].Nome},
                    {"Cognome", cliente[i.Key].Cognome},
                    {"Numero", cliente[i.Key].Numero},
                    {"Email", cliente[i.Key].Email},

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
                        {"IdCliente", i.Key},
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


