using System;
using System.IO;
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
            //string directory = Path.GetFullPath():

            //var dbClienti = Path.Combine(Directory.GetCurrentDirectory(), "\\dbClienti.txt");
            //var dbCommissioni = Path.Combine(Directory.GetCurrentDirectory(), "\\dbCommissioni.txt");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // passo i file iniettandoli da fuori
            Application.Run(new ClientManagement(
                Database.DbHandler.GetInstance(@"dbClienti.txt",
                    @"dbCommissioni.txt"
                )));
        }
    }
}
