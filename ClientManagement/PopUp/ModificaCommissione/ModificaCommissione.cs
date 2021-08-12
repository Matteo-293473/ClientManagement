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
using ClientManagement.PopUpModifica;

namespace ClientManagement
{
    public partial class ModificaCommissione : Form
    {
        private EditorModificaDati editor;
        private int idCommissione;
        public ModificaCommissione(int idCommissione)
        {
            InitializeComponent();
            this.idCommissione = idCommissione;
            editor = new EditorModificaDati(txtDescrizioneCommissione, dtpScadenza);
            editor.CaricaDati(idCommissione);

            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }

        private void ModificaDati_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            editor.AggiornaCommissione();
            Close();
        }
    }
}
