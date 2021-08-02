﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    class EditorCommissioniInScadenza
    {
        public EditorCommissioniInScadenza()
        {


        }

        internal void AggiornaListView(ListView lstCommissioniScadenza)
        {
            // rimuoviamo gli elementi presenti
            //lstCommissioniScadenza.Items.Clear();
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int) date.DayOfWeek);

            // inseriamo ogni commissione all'interno della tabella
            lstCommissioniScadenza.Items.Clear();
            ListViewItem lst;
            string[] arr = new string[6];

            foreach (var i in Models.CommissionManager.clienteCommissioni)
            {
                List<Commissione> temp = i.Value;
                foreach (Commissione cm in temp)
                {

                    arr[0] = i.Key.Nome;
                    arr[1] = i.Key.Cognome;
                    arr[2] = i.Key.Email;
                    arr[3] = i.Key.Numero;
                    arr[4] = cm.Descrizione;
                    arr[5] = cm.Scadenza.ToString();
                    lst = new ListViewItem(arr);

                    //se l'item non esiste allora lo inseriamo
                    if (cm.Scadenza < nextSunday)
                        lstCommissioniScadenza.Items.Add(lst);

                }
            }

        }
    }
}