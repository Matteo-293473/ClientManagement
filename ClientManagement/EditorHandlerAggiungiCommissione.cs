﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    class EditorHandlerAggiungiCommissione
    {

        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtEmail;
        private TextBox txtNumeroTelefono;
        private TextBox txtDescrizioneCommissione;
        private DateTimePicker dtpScadenza;

        public string Nome { get => txtNome.Text; }
        public string Cognome { get => txtCognome.Text; }
        public string Email { get => txtEmail.Text; }
        public string NumeroTelefono { get => txtNumeroTelefono.Text; }
        public string DescrizioneCommissione { get => txtDescrizioneCommissione.Text; }

        public EditorHandlerAggiungiCommissione(TextBox txtNome, TextBox txtCognome, TextBox txtEmail, TextBox txtNumeroTelefono, TextBox txtDescrizioneCommissione)
        {
            this.txtNome = txtNome;
            this.txtCognome = txtCognome;
            this.txtEmail = txtEmail;
            this.txtNumeroTelefono = txtNumeroTelefono;
            this.txtDescrizioneCommissione = txtDescrizioneCommissione;
        }
        
        internal void ResetFields()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            txtEmail.Text = "";
            txtNumeroTelefono.Text = "";
            txtDescrizioneCommissione.Text = "";

        }

        internal void ControllaNumeroTelefono(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        internal void ControllaNome(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        internal bool ControllaValiditaInput()
        {
            // controllo degli input
            if ((txtNumeroTelefono.Text.All(char.IsDigit)) && 
                (txtNome.Text.All(char.IsLetter)) && 
                (txtCognome.Text.All(char.IsLetter)))
                return true;
            else
                return false;
            
        }

    }
}