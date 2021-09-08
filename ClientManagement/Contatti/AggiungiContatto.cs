﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;

namespace ClientManagement.Contatti
{
    public partial class AggiungiContatto : UserControl
    {
        private readonly EditorHandlerAggiungiContatto editorAggiungiContatti;
        private readonly HandlerContatti handlerContatti;

        public AggiungiContatto()
        {
            InitializeComponent();

            
            // carico due handler che alleggeriscono il codice della classe
            // il primo si occupa della verifica e inserimento dei dati
            editorAggiungiContatti = new EditorHandlerAggiungiContatto(txtNome, txtCognome, txtNumeroTelefono, txtEmail);
            
            // il secondo permette di richiamare il metodo aggiornaListaContatti
            handlerContatti = new HandlerContatti();
            CommissionManager.OnClientiCambia += AggiungiContatto_OnListaCambia;
        }
        private void AggiungiContatto_OnListaCambia(object sender, Dictionary<int, Cliente> clienteCommissioni)
        {
            handlerContatti.AggiornaListaContatti(lstContatti);
        }


        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void txtCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaCaratteri(e);
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllo.ControllaNumeri(e);
        }

        private void btnAggiungiEntry_Click(object sender, EventArgs e)
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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
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
