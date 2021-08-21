﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.PopUpModifica;

namespace ClientManagement.PopUp.VisualizzaCommissione
{
    public partial class VisualizzaCommissione : Form
    {
        private HandlerVisualizzaCommissione editor;
        public VisualizzaCommissione(int idCommissione,int idCliente)
        {
            InitializeComponent();
            editor = new HandlerVisualizzaCommissione(lblTxtNome, lblTxtCognome, lblTxtEmail, lblTxtNumeroTel,lblTxtDescrizioneCommissione,lblTxtScadenza, lblTxtCompletato);
            editor.CaricaDati(idCommissione,idCliente);

            // aggiungere un editor handler che va a popolare i campi 
            // editor.PopolaCampi();
        }
    }
}