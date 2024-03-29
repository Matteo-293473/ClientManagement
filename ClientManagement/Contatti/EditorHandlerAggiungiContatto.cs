﻿using System;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.PopUp.ModificaCliente;

namespace ClientManagement.Contatti
{
    internal class EditorHandlerAggiungiContatto 
    {
        // diamo la visibilità anche alle classi derivate
        protected readonly TextBox TxtNome;
        protected readonly TextBox TxtCognome;
        protected readonly TextBox TxtEmail;
        protected readonly TextBox TxtNumeroTelefono;
        protected readonly DatiLocali DatiLocali = DatiLocali.GetInstance();

        
        public EditorHandlerAggiungiContatto()
        {

        }

        // overload del costruttore
        public EditorHandlerAggiungiContatto(TextBox txtNome, TextBox txtCognome, TextBox txtNumeroTelefono, TextBox txtEmail)
        {
            this.TxtNome = txtNome;
            this.TxtCognome = txtCognome;
            this.TxtNumeroTelefono = txtNumeroTelefono;
            this.TxtEmail = txtEmail;
        }

        // Cancelliamo il testo presente in tutte le text box
        internal virtual void ResetFields()
        {
            TxtNome.Text = "";
            TxtCognome.Text = "";
            TxtNumeroTelefono.Text = "";
            TxtEmail.Text = "";

        }


        internal virtual void InserisciEntry()
        {

            CorreggiCaratteri();

            // inserisco il cliente
            Cliente cl = new Cliente(TxtNome.Text, TxtCognome.Text, TxtNumeroTelefono.Text, TxtEmail.Text);

            // aggiungo il cliente al dizionario usufruendo dell'overload
            DatiLocali.AggiungiEntry(cl);
            
        }


        internal void CorreggiCaratteri()
        {
            // Prima lettere maiuscola il resto in minuscolo
            TxtNome.Text = TxtNome.Text.ToLower();
            TxtNome.Text = char.ToUpper(TxtNome.Text[0])+ TxtNome.Text.Substring(1);

            // Stessa cosa per il cognome
            TxtCognome.Text = TxtCognome.Text.ToLower();
            TxtCognome.Text = char.ToUpper(TxtCognome.Text[0]) + TxtCognome.Text.Substring(1);

        }


        internal virtual void ControllaValiditaInput()
        {
            // eliminiamo degli spazi e caratteri indesiderati alla fine dei nomi
            var nome = TxtNome.Text.Split(' ');
            var cognome = TxtCognome.Text.Split(' ');
            TxtNome.Text = nome[0];
            TxtCognome.Text = cognome[0];

            // usiamo la classe statica per controllare se ci sono errori negli input delle text box
            Controllo.ControlloInputCliente(TxtNome.Text, TxtCognome.Text, TxtNumeroTelefono.Text, TxtEmail.Text);
        }

        internal void MostraPopUpModifica(ListView lstContatti)
        {
            // usiamo la classe statica dedicata per il controllo
            Controllo.ControlloListViewSelezione(lstContatti);

            // recupero l'id della commissione
            var idCliente = Convert.ToInt32(lstContatti.SelectedItems[0].SubItems[4].Text);

            var popUpModificaCliente = new ModificaCliente(idCliente);
            popUpModificaCliente.ShowDialog(lstContatti);
        }
    }
}
