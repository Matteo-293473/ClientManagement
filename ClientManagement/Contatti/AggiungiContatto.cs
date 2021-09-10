using System;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.Observer;

namespace ClientManagement.Contatti
{
    public partial class AggiungiContatto : UserControl, IObserver
    {
        private readonly EditorHandlerAggiungiContatto editorAggiungiContatti;
        private readonly HandlerContatti handlerContatti;
        private readonly DatiLocali datiLocali = DatiLocali.GetInstance();

        public AggiungiContatto()
        {
            InitializeComponent();

            // carico due handler che alleggeriscono il codice della classe
            // il primo si occupa della verifica e inserimento dei dati
            editorAggiungiContatti = new EditorHandlerAggiungiContatto(txtNome, txtCognome, txtNumeroTelefono, txtEmail);
            
            // il secondo permette di richiamare il metodo aggiornaListaContatti
            handlerContatti = new HandlerContatti();
            datiLocali.AggiungiObserver(this);
        }

        public new void Update()
        {
            handlerContatti.AggiornaListaContatti(lstContatti);
        }


        private void BtnIndietro_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void TxtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void TxtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaNumeri(e);
        }

        private void BtnAggiungiEntry_Click(object sender, EventArgs e)
        {
            try
            {
                // controllo input
                editorAggiungiContatti.ControllaValiditaInput();

                // funzione che crea una nuova commissione, nuovo cliente e l'associazione nel dizionario
                editorAggiungiContatti.InserisciEntry();

                // ripuliamo i campi
                editorAggiungiContatti.ResetFields();
            }
            catch (Exception err)
            {
                MessageBox.Show("Input errati: " + err.Message);
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaSpazi(e);
        }


        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                editorAggiungiContatti.MostraPopUpModifica(lstContatti);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
