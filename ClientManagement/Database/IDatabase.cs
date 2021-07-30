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
        IList<Commissione> GetData();
        void SaveData(IList<Models.Commissione> commissioni);
    }
}
