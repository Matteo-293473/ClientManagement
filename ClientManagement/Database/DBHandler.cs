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
    class DbHandler : IDatabase
    {
        private readonly string dbPathClienti;
        private readonly string dbPathCommissioni;
        private static DbHandler _instance;

        // Qui viene usato il singleton in modo da non creare erroneamente nuove istanze
        public static DbHandler GetInstance(string databaseFilePathClienti,string databaseFilePathCommissioni)
        {
            if (_instance == null)
            {
                _instance = new DbHandler(databaseFilePathClienti, databaseFilePathCommissioni);
            }

            return _instance;
        }


        // Qui applichiamo il pattern Singleton.
        // Non vogliamo istanziare due volte DBHandler
        private DbHandler(string datafileClienti,string datafileCommissioni)
        {
            dbPathClienti = datafileClienti;
            dbPathCommissioni = datafileCommissioni;
        }



        // Qua usiamo l'estensione Newtonsoft.json

        public IDictionary<int, Cliente> GetDataClienti()
        {
            IDictionary<int, Cliente> clienti = null;
            try
            {
                // facciamo un parsing all'interno del file 
                var jsonObject = JArray.Parse(File.ReadAllText(dbPathClienti));

                // ricaviamo una lista 
                var lista = jsonObject
                    .Cast<JObject>()
                    .Select(o => new KeyValuePair<int, Cliente>(
                        (int) o.PropertyValues().ElementAtOrDefault(0),
                        new Cliente((string) o.PropertyValues().ElementAtOrDefault(1),
                            (string) o.PropertyValues().ElementAtOrDefault(2),
                            (string) o.PropertyValues().ElementAtOrDefault(3),
                            (string) o.PropertyValues().ElementAtOrDefault(4))))
                    .ToList();
                // la trasformiamo in un dizionario dedicato ai clienti
                clienti = lista.ToDictionary(p => p.Key, p => p.Value);
            }
            catch (Exception)
            {
                // nel caso fallisca, viene restituito un dizionario nuovo
                clienti = new Dictionary<int, Cliente>();
            }

            return clienti;
        }

        // metodo che restituisce un dizionario composto dalla chiave (cliente) e la
        // lista di commissioni associata
        public IDictionary<int, List<Commissione>> GetDataCommissioni()
        {
            IDictionary<int, List<Commissione>> commissioni = null;
            try
            {
                commissioni = new Dictionary<int, List<Commissione>>();

                var jsonObject = JArray.Parse(File.ReadAllText(dbPathCommissioni));

                // ricaviamo una matrice
                var matriceCommissioni = jsonObject
                    .Cast<JObject>()
                    .Select(o => new object[]
                    {
                        // inseriamo i valori del dizionario (chiave,commissione)
                        (int) o.PropertyValues().ElementAtOrDefault(0),
                        new Commissione((string) o.PropertyValues().ElementAtOrDefault(1),
                            (DateTime) o.PropertyValues().ElementAtOrDefault(2),
                            (bool) o.PropertyValues().ElementAtOrDefault(3),
                            (int) o.PropertyValues().ElementAtOrDefault(4))
                    }).ToArray();


                // convertiamo la matrice ricavata in un dizionario
                for (var i = 0; i < matriceCommissioni.LongLength; i++)
                {
                    for (var j = 0; j < matriceCommissioni.Length; j += matriceCommissioni.Length)
                    {
                        var listCommissioniTemp = new List<Commissione>();

                        // se nel dizionario è presente la chiave
                        if (commissioni.ContainsKey((int) matriceCommissioni[i][j]))
                        {
                            listCommissioniTemp = commissioni[(int)matriceCommissioni[i][j]];
                            listCommissioniTemp.Add((Commissione)matriceCommissioni[i][j + 1]);
                            commissioni[(int)matriceCommissioni[i][j]] =  listCommissioniTemp;
                        }
                        // se non è presente la chiave
                        else
                        {
                            listCommissioniTemp.Add((Commissione) matriceCommissioni[i][j + 1]);
                            commissioni.Add((int) matriceCommissioni[i][j], listCommissioniTemp);
                        }
                    }
                }


            }
            catch (Exception)
            {
                // nel caso fallisca, viene restituito un dizionario nuovo
                commissioni = new Dictionary<int, List<Commissione>>();
            }

            return commissioni;
        }


        // salviamo i dati relativi ai clienti in un file.
        public void SaveDataClienti(IDictionary<int, Cliente> cliente)
        {
            var clientiJArray = new JArray();

            foreach (var i in from i in cliente
                let temp = i.Value
                select i)
            {
                // i dati sono salvati su file in questo formato JSON
                clientiJArray.Add(new JObject
                {
                    {"Id", i.Key},
                    {"Nome", cliente[i.Key].Nome},
                    {"Cognome", cliente[i.Key].Cognome},
                    {"Numero", cliente[i.Key].Numero},
                    {"Email", cliente[i.Key].Email},

                });
            }
            // scriviamo su file
            File.WriteAllText(dbPathClienti, clientiJArray.ToString());
        }


        // salviamo i dati relativi alle commissioni in un file
        public void SaveDataCommissioni(IDictionary<int, List<Commissione>> commissioni)
        {
            var commissioniJArray = new JArray();

            foreach (var i in commissioni)
            {
                var temp = i.Value;
                foreach (Commissione cm in temp)
                {
                    // i dati sono salvati su file in questo formato JSON
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
            // scriviamo su file
            File.WriteAllText(dbPathCommissioni, commissioniJArray.ToString());
        }
    }

}


