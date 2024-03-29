﻿
namespace ClientManagement.Contatti
{
    partial class AggiungiContatto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggiungiContatto));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnAggiungiEntry = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstContatti = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.clmIdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(91, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 56);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIndietro.Image = ((System.Drawing.Image)(resources.GetObject("btnIndietro.Image")));
            this.btnIndietro.Location = new System.Drawing.Point(91, 38);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(77, 57);
            this.btnIndietro.TabIndex = 7;
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.BtnIndietro_Click);
            // 
            // btnAggiungiEntry
            // 
            this.btnAggiungiEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAggiungiEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiEntry.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnAggiungiEntry.Location = new System.Drawing.Point(573, 373);
            this.btnAggiungiEntry.Name = "btnAggiungiEntry";
            this.btnAggiungiEntry.Size = new System.Drawing.Size(165, 56);
            this.btnAggiungiEntry.TabIndex = 4;
            this.btnAggiungiEntry.UseVisualStyleBackColor = false;
            this.btnAggiungiEntry.Click += new System.EventHandler(this.BtnAggiungiEntry_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(94, 297);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 19);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Numero di telefono:";
            // 
            // TxtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(97, 319);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroTelefono.TabIndex = 3;
            this.txtNumeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroTelefono_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(93, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblCognome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCognome.Location = new System.Drawing.Point(93, 183);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(80, 19);
            this.lblCognome.TabIndex = 23;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeCliente.Location = new System.Drawing.Point(93, 124);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(56, 19);
            this.lblNomeCliente.TabIndex = 22;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // TxtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(97, 205);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(148, 20);
            this.txtCognome.TabIndex = 1;
            this.txtCognome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCognome_KeyPress);
            // 
            // TxtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 146);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // lstContatti
            // 
            this.lstContatti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCognome,
            this.clmNumero,
            this.clmEmail,
            this.clmIdCliente});
            this.lstContatti.FullRowSelect = true;
            this.lstContatti.GridLines = true;
            this.lstContatti.HideSelection = false;
            this.lstContatti.Location = new System.Drawing.Point(288, 38);
            this.lstContatti.Name = "lstContatti";
            this.lstContatti.Size = new System.Drawing.Size(450, 301);
            this.lstContatti.TabIndex = 27;
            this.lstContatti.UseCompatibleStateImageBehavior = false;
            this.lstContatti.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 73;
            // 
            // clmCognome
            // 
            this.clmCognome.Text = "Cognome";
            this.clmCognome.Width = 111;
            // 
            // clmNumero
            // 
            this.clmNumero.Text = "N. Tel.";
            this.clmNumero.Width = 104;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 103;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifica.Location = new System.Drawing.Point(288, 373);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(259, 56);
            this.btnModifica.TabIndex = 6;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // TxtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // clmIdCliente
            // 
            this.clmIdCliente.Text = "id Cliente";
            // 
            // AggiungiContatto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lstContatti);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnAggiungiEntry);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Name = "AggiungiContatto";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnAggiungiEntry;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListView lstContatti;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmNumero;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ColumnHeader clmIdCliente;
    }
}
