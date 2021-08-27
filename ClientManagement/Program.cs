﻿using System;
using System.Windows.Forms;

namespace ClientManagement
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientManagement(
                Database.DBHandler.GetInstance(@"C:\Users\pulci\Documents\progetto oop\ClientManagement\ClientManagement\dbClienti.txt",
                    @"C:\Users\pulci\Documents\progetto oop\ClientManagement\ClientManagement\dbCommissioni.txt")
                ));
        }
    }
}
