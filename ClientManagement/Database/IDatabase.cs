using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    interface IDatabase
    {
        IList<> GetData();
        void SaveData(IList<> commissioni);
    }
}
