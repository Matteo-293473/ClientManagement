﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            aggiungiCommissione1.Visible = false;
        }

        private void BtnNuovaCommissione(object sender, EventArgs e)
        {
            aggiungiCommissione1.Visible = true;
        }
    }
}
