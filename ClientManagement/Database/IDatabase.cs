using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Models;

namespace ClientManagement.Database
{
    public interface IDatabase
    {
        IDictionary<Cliente,List<Commissione>> GetData();
        void SaveData(IDictionary<Cliente, List<Commissione>> commissioni);
    }
}
