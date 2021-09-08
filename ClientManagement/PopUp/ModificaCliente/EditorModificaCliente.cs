﻿using ClientManagement.Models;
using System.Windows.Forms;

namespace ClientManagement.PopUp.ModificaCliente
{
    class EditorModificaCliente
    {
        private readonly TextBox txtNome;
        private readonly TextBox txtCognome;
        private readonly TextBox txtNumeroTelefono;
        private readonly TextBox txtEmail;
        private Cliente cl;
        private readonly CommissionManager commissionManager = CommissionManager.GetInstance();



        public EditorModificaCliente(TextBox txtNome, TextBox txtCognome, TextBox txtNumeroTelefono, TextBox txtEmail)
        {
            this.txtNome = txtNome;
            this.txtCognome = txtCognome;
            this.txtNumeroTelefono = txtNumeroTelefono;
            this.txtEmail = txtEmail;
        }


        public void CaricaDati(int idCliente)
        {

            // Ci viene restituito il cliente selezionato
            this.cl = commissionManager.RestituisciCliente(idCliente);

            txtNome.Text = cl.Nome;
            txtCognome.Text = cl.Cognome;
            txtNumeroTelefono.Text = cl.Numero;
            txtEmail.Text = cl.Email;

        }

        internal void AggiornaCommissione(int idCliente)
        {
            // aggiorno i campi
            cl.Nome = txtNome.Text;
            cl.Cognome = txtCognome.Text;
            cl.Numero = txtNumeroTelefono.Text;
            cl.Email = txtEmail.Text;
            commissionManager.ModificaCliente(cl, idCliente);
        }
    }
}
