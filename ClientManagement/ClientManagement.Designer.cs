﻿
using ClientManagement.Commissioni;

namespace ClientManagement
{
    partial class ClientManagement
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'handler di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagement));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnScadenze = new System.Windows.Forms.Button();
            this.btnCommissioni = new System.Windows.Forms.Button();
            this.btnRubrica = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PctBoxLogo = new System.Windows.Forms.PictureBox();
            this.contatti1 = new Contatti.Contatti();
            this.commissioniDaFare1 = new Scadenze.CommissioniDaFare();
            this.commissioniTotali1 = new Commissioni.CommissioniTotali();
            this.home1 = new Home();
            this.pnlSideMenu.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pnlSideMenu.Controls.Add(this.btnScadenze);
            this.pnlSideMenu.Controls.Add(this.btnCommissioni);
            this.pnlSideMenu.Controls.Add(this.btnRubrica);
            this.pnlSideMenu.Controls.Add(this.btnHome);
            this.pnlSideMenu.Controls.Add(this.PnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(176, 483);
            this.pnlSideMenu.TabIndex = 1;
            this.pnlSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideMenu_Paint);
            // 
            // btnScadenze
            // 
            this.btnScadenze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnScadenze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScadenze.FlatAppearance.BorderSize = 0;
            this.btnScadenze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScadenze.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScadenze.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnScadenze.Image = ((System.Drawing.Image)(resources.GetObject("btnScadenze.Image")));
            this.btnScadenze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScadenze.Location = new System.Drawing.Point(0, 270);
            this.btnScadenze.Name = "btnScadenze";
            this.btnScadenze.Size = new System.Drawing.Size(176, 53);
            this.btnScadenze.TabIndex = 14;
            this.btnScadenze.Text = "Scadenze";
            this.btnScadenze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScadenze.UseVisualStyleBackColor = false;
            this.btnScadenze.Click += new System.EventHandler(this.BtnScadenze_Click);
            this.btnScadenze.Leave += new System.EventHandler(this.btnScadenze_Leave);
            // 
            // btnCommissioni
            // 
            this.btnCommissioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnCommissioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommissioni.FlatAppearance.BorderSize = 0;
            this.btnCommissioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommissioni.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommissioni.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCommissioni.Image = ((System.Drawing.Image)(resources.GetObject("btnCommissioni.Image")));
            this.btnCommissioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommissioni.Location = new System.Drawing.Point(0, 217);
            this.btnCommissioni.Name = "btnCommissioni";
            this.btnCommissioni.Size = new System.Drawing.Size(176, 53);
            this.btnCommissioni.TabIndex = 13;
            this.btnCommissioni.Text = "Commissioni";
            this.btnCommissioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCommissioni.UseVisualStyleBackColor = false;
            this.btnCommissioni.Click += new System.EventHandler(this.BtnCommissioni_Click);
            this.btnCommissioni.Leave += new System.EventHandler(this.btnCommissioni_Leave);
            // 
            // btnRubrica
            // 
            this.btnRubrica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnRubrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRubrica.FlatAppearance.BorderSize = 0;
            this.btnRubrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubrica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRubrica.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRubrica.Image = global::ClientManagement.Properties.Resources.appbar_book_contact;
            this.btnRubrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRubrica.Location = new System.Drawing.Point(0, 164);
            this.btnRubrica.Name = "btnRubrica";
            this.btnRubrica.Size = new System.Drawing.Size(176, 53);
            this.btnRubrica.TabIndex = 12;
            this.btnRubrica.Text = "Rubrica";
            this.btnRubrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRubrica.UseVisualStyleBackColor = false;
            this.btnRubrica.Click += new System.EventHandler(this.BtnRubrica_Click);
            this.btnRubrica.Leave += new System.EventHandler(this.btnRubrica_Leave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHome.Image = global::ClientManagement.Properties.Resources.appbar_home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 111);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(176, 53);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.PctBoxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(176, 111);
            this.PnlLogo.TabIndex = 10;
            this.PnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLogo_Paint);
            // 
            // PctBoxLogo
            // 
            this.PctBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.PctBoxLogo.Image = global::ClientManagement.Properties.Resources.clientManagement;
            this.PctBoxLogo.Location = new System.Drawing.Point(12, 0);
            this.PctBoxLogo.Name = "PctBoxLogo";
            this.PctBoxLogo.Size = new System.Drawing.Size(154, 111);
            this.PctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBoxLogo.TabIndex = 0;
            this.PctBoxLogo.TabStop = false;
            this.PctBoxLogo.Click += new System.EventHandler(this.PctBoxLogo_Click);
            // 
            // contatti1
            // 
            this.contatti1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.contatti1.Location = new System.Drawing.Point(175, 4);
            this.contatti1.Name = "contatti1";
            this.contatti1.Size = new System.Drawing.Size(764, 485);
            this.contatti1.TabIndex = 4;
            // 
            // commissioniDaFare1
            // 
            this.commissioniDaFare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.commissioniDaFare1.Location = new System.Drawing.Point(172, -12);
            this.commissioniDaFare1.Name = "commissioniDaFare1";
            this.commissioniDaFare1.Size = new System.Drawing.Size(764, 485);
            this.commissioniDaFare1.TabIndex = 3;
            // 
            // commissioniTotali1
            // 
            this.commissioniTotali1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.commissioniTotali1.Location = new System.Drawing.Point(173, 3);
            this.commissioniTotali1.Name = "commissioniTotali1";
            this.commissioniTotali1.Size = new System.Drawing.Size(764, 485);
            this.commissioniTotali1.TabIndex = 7;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(169, 1);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(764, 485);
            this.home1.TabIndex = 2;
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(931, 483);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.commissioniDaFare1);
            this.Controls.Add(this.commissioniTotali1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.contatti1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientManagement";
            this.Text = "Client Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientManagement_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRubrica;
        private System.Windows.Forms.PictureBox PctBoxLogo;
        private System.Windows.Forms.Button btnCommissioni;
        private System.Windows.Forms.Button btnScadenze;
        private Home home1;
        private Scadenze.CommissioniDaFare commissioniDaFare1;
        private Contatti.Contatti contatti1;
        private CommissioniTotali commissioniTotali1;
    }
}

