
namespace ClientManagement
{
    partial class ModificaDati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEmail = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblDescrizioneCommissione = new System.Windows.Forms.Label();
            this.txtDescrizioneCommissione = new System.Windows.Forms.TextBox();
            this.lblDataScadenza = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpScadenza = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbEmail
            // 
            this.cmbEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "@yahoo.it",
            "@gmail.com",
            "@libero.it"});
            this.cmbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.Location = new System.Drawing.Point(28, 156);
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(147, 21);
            this.cmbEmail.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(24, 196);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 19);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Numero di telefono:";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(28, 218);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroTelefono.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(29, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblCognome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCognome.Location = new System.Drawing.Point(24, 76);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(80, 19);
            this.lblCognome.TabIndex = 22;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeCliente.Location = new System.Drawing.Point(24, 24);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(56, 19);
            this.lblNomeCliente.TabIndex = 21;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblDescrizioneCommissione
            // 
            this.lblDescrizioneCommissione.AutoSize = true;
            this.lblDescrizioneCommissione.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescrizioneCommissione.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescrizioneCommissione.Location = new System.Drawing.Point(206, 76);
            this.lblDescrizioneCommissione.Name = "lblDescrizioneCommissione";
            this.lblDescrizioneCommissione.Size = new System.Drawing.Size(226, 19);
            this.lblDescrizioneCommissione.TabIndex = 20;
            this.lblDescrizioneCommissione.Text = "Descrizione della commissione:";
            // 
            // txtDescrizioneCommissione
            // 
            this.txtDescrizioneCommissione.Location = new System.Drawing.Point(206, 98);
            this.txtDescrizioneCommissione.Multiline = true;
            this.txtDescrizioneCommissione.Name = "txtDescrizioneCommissione";
            this.txtDescrizioneCommissione.Size = new System.Drawing.Size(245, 140);
            this.txtDescrizioneCommissione.TabIndex = 17;
            // 
            // lblDataScadenza
            // 
            this.lblDataScadenza.AutoSize = true;
            this.lblDataScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataScadenza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataScadenza.Location = new System.Drawing.Point(202, 24);
            this.lblDataScadenza.Name = "lblDataScadenza";
            this.lblDataScadenza.Size = new System.Drawing.Size(73, 19);
            this.lblDataScadenza.TabIndex = 18;
            this.lblDataScadenza.Text = "Scadenza";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(28, 98);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(148, 20);
            this.txtCognome.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 13;
            // 
            // dtpScadenza
            // 
            this.dtpScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.dtpScadenza.Location = new System.Drawing.Point(206, 46);
            this.dtpScadenza.Name = "dtpScadenza";
            this.dtpScadenza.Size = new System.Drawing.Size(226, 25);
            this.dtpScadenza.TabIndex = 19;
            // 
            // ModificaDati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(474, 266);
            this.Controls.Add(this.cmbEmail);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblDescrizioneCommissione);
            this.Controls.Add(this.txtDescrizioneCommissione);
            this.Controls.Add(this.lblDataScadenza);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpScadenza);
            this.Name = "ModificaDati";
            this.Text = "ModificaDati";
            this.Load += new System.EventHandler(this.ModificaDati_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmail;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblDescrizioneCommissione;
        private System.Windows.Forms.TextBox txtDescrizioneCommissione;
        private System.Windows.Forms.Label lblDataScadenza;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpScadenza;
    }
}