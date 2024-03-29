﻿using System.Collections.Generic;
using ClientManagement.Models;

namespace ClientManagement.Database
{
    public interface IDatabase
    {
        // firme per il recupero dei dati
        IDictionary<int,Cliente> GetDataClienti(); 
        IDictionary<int, List<Commissione>> GetDataCommissioni();

        // firme per il salvataggio dei dati
        void SaveDataClienti(IDictionary<int, Cliente> clienti);
        void SaveDataCommissioni(IDictionary<int, List<Commissione>> commissioni);

    }
}
