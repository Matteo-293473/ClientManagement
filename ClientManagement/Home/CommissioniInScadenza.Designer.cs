﻿
using ClientManagement.Models;

namespace ClientManagement
{
    partial class CommissioniInScadenza
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'handler di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCommissioniScadenza = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScadenza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIdComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovaCommission = new System.Windows.Forms.Button();
            this.lblCommissioniSettimana = new System.Windows.Forms.Label();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCommissioniScadenza
            // 
            this.lstCommissioniScadenza.BackColor = System.Drawing.SystemColors.Window;
            this.lstCommissioniScadenza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCognome,
            this.clmNtel,
            this.clmEmail,
            this.clmComm,
            this.clmScadenza,
            this.clmIdComm});
            this.lstCommissioniScadenza.FullRowSelect = true;
            this.lstCommissioniScadenza.GridLines = true;
            this.lstCommissioniScadenza.HideSelection = false;
            this.lstCommissioniScadenza.Location = new System.Drawing.Point(50, 154);
            this.lstCommissioniScadenza.Name = "lstCommissioniScadenza";
            this.lstCommissioniScadenza.Size = new System.Drawing.Size(680, 225);
            this.lstCommissioniScadenza.TabIndex = 0;
            this.lstCommissioniScadenza.UseCompatibleStateImageBehavior = false;
            this.lstCommissioniScadenza.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 80;
            // 
            // clmCognome
            // 
            this.clmCognome.Text = "Cognome";
            this.clmCognome.Width = 100;
            // 
            // clmNtel
            // 
            this.clmNtel.Text = "N. Tel.";
            this.clmNtel.Width = 125;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 131;
            // 
            // clmComm
            // 
            this.clmComm.Text = "Commissione";
            this.clmComm.Width = 106;
            // 
            // clmScadenza
            // 
            this.clmScadenza.Text = "Scadenza";
            this.clmScadenza.Width = 83;
            // 
            // clmIdComm
            // 
            this.clmIdComm.Text = "Id Comm.";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifica.Location = new System.Drawing.Point(170, 405);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(104, 38);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // btnNuovaCommission
            // 
            this.btnNuovaCommission.BackColor = System.Drawing.Color.Black;
            this.btnNuovaCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuovaCommission.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuovaCommission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuovaCommission.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnNuovaCommission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuovaCommission.Location = new System.Drawing.Point(49, 48);
            this.btnNuovaCommission.Name = "btnNuovaCommission";
            this.btnNuovaCommission.Size = new System.Drawing.Size(239, 49);
            this.btnNuovaCommission.TabIndex = 14;
            this.btnNuovaCommission.Text = "Nuova commissione";
            this.btnNuovaCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuovaCommission.UseVisualStyleBackColor = false;
            this.btnNuovaCommission.Click += new System.EventHandler(this.BtnNuovaCommission_Click);
            // 
            // lblCommissioniSettimana
            // 
            this.lblCommissioniSettimana.AutoSize = true;
            this.lblCommissioniSettimana.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblCommissioniSettimana.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCommissioniSettimana.Location = new System.Drawing.Point(45, 132);
            this.lblCommissioniSettimana.Name = "lblCommissioniSettimana";
            this.lblCommissioniSettimana.Size = new System.Drawing.Size(245, 19);
            this.lblCommissioniSettimana.TabIndex = 16;
            this.lblCommissioniSettimana.Text = "Commissioni di questa settimana:";
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVisualizza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnVisualizza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVisualizza.Location = new System.Drawing.Point(50, 405);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(115, 38);
            this.btnVisualizza.TabIndex = 17;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = false;
            this.btnVisualizza.Click += new System.EventHandler(this.BtnVisualizza_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalva.Location = new System.Drawing.Point(626, 405);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(104, 38);
            this.btnSalva.TabIndex = 18;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.BtnSalva_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElimina.Location = new System.Drawing.Point(280, 405);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(104, 38);
            this.btnElimina.TabIndex = 21;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // CommissioniInScadenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lblCommissioniSettimana);
            this.Controls.Add(this.btnNuovaCommission);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lstCommissioniScadenza);
            this.Name = "CommissioniInScadenza";
            this.Size = new System.Drawing.Size(764, 485);
            this.Load += new System.EventHandler(this.CommissioniInScadenza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCommissioniScadenza;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmNtel;
        private System.Windows.Forms.ColumnHeader clmComm;
        private System.Windows.Forms.ColumnHeader clmScadenza;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovaCommission;
        private System.Windows.Forms.Label lblCommissioniSettimana;
        private System.Windows.Forms.ColumnHeader clmIdComm;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnElimina;
    }
}
