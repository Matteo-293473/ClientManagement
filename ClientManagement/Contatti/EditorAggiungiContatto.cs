﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Extensions;
using ClientManagement.Models;
using ClientManagement.PopUp.ModificaCliente;

namespace ClientManagement.Contatti
{
    class EditorAggiungiContatto 
    {
        // diamo la visibilità anche alle classi derivate
        protected TextBox txtNome;
        protected TextBox txtCognome;
        protected TextBox txtEmail;
        protected TextBox txtNumeroTelefono;
        

        public EditorAggiungiContatto()
        {

        }

        //OK
        public EditorAggiungiContatto(TextBox txtNome, TextBox txtCognome, TextBox txtEmail, TextBox txtNumeroTelefono)
        {
            this.txtNome = txtNome;
            this.txtCognome = txtCognome;
            this.txtEmail = txtEmail;
            this.txtNumeroTelefono = txtNumeroTelefono;
        }

        //OK
        internal virtual void ResetFields()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            txtEmail.Text = "";
            txtNumeroTelefono.Text = "";

        }


        internal virtual void InserisciEntry()
        {

            CorreggiCaratteri();

            // inserisco il cliente
            Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, txtEmail.Text);

            // aggiungo il cliente al dizionario usufruendo dell'overload
            CommissionManager.AggiungiEntry(cl);
            
        }


        internal void CorreggiCaratteri()
        {
            // Prima lettere maiuscola il resto in minuscolo
            txtNome.Text = txtNome.Text.ToLower();
            txtNome.Text = char.ToUpper(txtNome.Text[0])+ txtNome.Text.Substring(1);

            // Stessa cosa per il cognome
            txtCognome.Text = txtCognome.Text.ToLower();
            txtCognome.Text = char.ToUpper(txtCognome.Text[0]) + txtCognome.Text.Substring(1);

        }


        internal virtual void ControllaValiditaInput()
        {
            // eliminiamo degli spazi e caratteri indesiderati alla fine dei nomi
            var nome = txtNome.Text.Split(' ');
            var cognome = txtCognome.Text.Split(' ');
            txtNome.Text = nome[0];
            txtCognome.Text = cognome[0];

            // controllo degli input
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCognome.Text) ||
                String.IsNullOrEmpty(txtNumeroTelefono.Text))
                throw new Exception("Uno dei campi è vuoto");

            // usiamo una libreria per controllare la validà dell'email
            // nel caso in cui l'email sia in un formata sbagliato, viene
            // generata un'eccezione
            MailAddress mail = new MailAddress(txtEmail.Text);

            // il numero di telefono in genere ha tra le 10 e le 15 cifre
            if (!txtNumeroTelefono.Text.Any(char.IsLetter) && (txtNumeroTelefono.Text.Length > 15 
                                                              || txtNumeroTelefono.Text.Length < 10))
                throw new Exception("Numero di telefono non valido");

           
            if (!txtCognome.Text.All(char.IsLetter))
                throw new Exception("Cognome non valido, ci sono caratteri errati");

            
            if (!txtNumeroTelefono.Text.All(char.IsDigit))
                throw new Exception("Numero di telefono non valido");

            if (!txtNome.Text.All(char.IsLetter))
                throw new Exception("Nome non valido, ci sono caratteri errati");


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
