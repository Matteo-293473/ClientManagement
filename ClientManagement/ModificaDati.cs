using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement
{
    public partial class ModificaDati : Form
    {
        public ModificaDati(int idCommissione)
        {
            InitializeComponent();

            //var cm = CommissionManager.clienteCommissioni.Where(s =>
            //     CommissionManager.clienteCommissioni[s.key] ).Select(s => s.Key).FirstOrDefault();

            foreach (var listaCommissioni in CommissionManager.clienteCommissioni.Values)
            {
                foreach (var cm in listaCommissioni)
                {
                    if (cm.IdCommissione == idCommissione)
                    {
                        dtpScadenza.Value = cm.Scadenza;
                        txtDescrizioneCommissione.Text = cm.Descrizione;
                    }

                }
            }



            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }

        private void ModificaDati_Load(object sender, EventArgs e)
        {
            
        }
    }
}
