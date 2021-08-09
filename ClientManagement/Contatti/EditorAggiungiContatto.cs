﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.Models;

namespace ClientManagement.Contatti
{
    class EditorAggiungiContatto
    {
        // diamo la visibilità anche alle classi derivate
        protected TextBox txtNome;
        protected TextBox txtCognome;
        protected TextBox txtEmail;
        protected TextBox txtNumeroTelefono;

        public string Nome { get => txtNome.Text; }
        public string Cognome { get => txtCognome.Text; }
        public string Email { get => txtEmail.Text; }
        public string NumeroTelefono { get => txtNumeroTelefono.Text; }

        public List<String> domini = new List<String>()
        {
                "gmail.com",
                "outlook.com",
                "live.com",
                "libero.it",
                "alice.it.com"
        };

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

        internal void ControllaNumeri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        internal void ControllaCaratteri(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        internal virtual void InserisciEntry()
        {
            // inserisco il cliente
            Cliente cl = new Cliente(txtNome.Text, txtCognome.Text, txtNumeroTelefono.Text, txtEmail.Text);

            // aggiungo il cliente al dizionario usufruendo dell'overload
            CommissionManager.AggiungiEntry(cl);
        }



        // OK
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

            if (!txtCognome.Text.All(char.IsLetter))
                throw new Exception("Cognome non valido, ci sono caratteri errati");

            
            if (!txtNumeroTelefono.Text.All(char.IsDigit))
                throw new Exception("Numero di telefono non valido");

            if (!txtNome.Text.All(char.IsLetter))
                throw new Exception("Nome non valido, ci sono caratteri errati");


            

        }



    }
}
