
namespace ClientManagement.Resources
{
    partial class aggiungiCommissione
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
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aggiungiCommissione));
            this.dtpScadenza = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblDataScadenza = new System.Windows.Forms.Label();
            this.txtDescrizioneCommissione = new System.Windows.Forms.TextBox();
            this.lblDescrizioneCommissione = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnAggiungiEntry = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpScadenza
            // 
            this.dtpScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.dtpScadenza.Location = new System.Drawing.Point(277, 367);
            this.dtpScadenza.Name = "dtpScadenza";
            this.dtpScadenza.Size = new System.Drawing.Size(261, 25);
            this.dtpScadenza.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 178);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(80, 230);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(148, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // lblDataScadenza
            // 
            this.lblDataScadenza.AutoSize = true;
            this.lblDataScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataScadenza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataScadenza.Location = new System.Drawing.Point(273, 345);
            this.lblDataScadenza.Name = "lblDataScadenza";
            this.lblDataScadenza.Size = new System.Drawing.Size(73, 19);
            this.lblDataScadenza.TabIndex = 4;
            this.lblDataScadenza.Text = "Scadenza";
            // 
            // txtDescrizioneCommissione
            // 
            this.txtDescrizioneCommissione.Location = new System.Drawing.Point(277, 178);
            this.txtDescrizioneCommissione.Multiline = true;
            this.txtDescrizioneCommissione.Name = "txtDescrizioneCommissione";
            this.txtDescrizioneCommissione.Size = new System.Drawing.Size(389, 141);
            this.txtDescrizioneCommissione.TabIndex = 4;
            // 
            // lblDescrizioneCommissione
            // 
            this.lblDescrizioneCommissione.AutoSize = true;
            this.lblDescrizioneCommissione.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescrizioneCommissione.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescrizioneCommissione.Location = new System.Drawing.Point(273, 156);
            this.lblDescrizioneCommissione.Name = "lblDescrizioneCommissione";
            this.lblDescrizioneCommissione.Size = new System.Drawing.Size(226, 19);
            this.lblDescrizioneCommissione.TabIndex = 6;
            this.lblDescrizioneCommissione.Text = "Descrizione della commissione:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeCliente.Location = new System.Drawing.Point(77, 156);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(56, 19);
            this.lblNomeCliente.TabIndex = 7;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblCognome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCognome.Location = new System.Drawing.Point(77, 208);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(80, 19);
            this.lblCognome.TabIndex = 8;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(77, 297);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 319);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(77, 350);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 19);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero di telefono:";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(80, 372);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroTelefono.TabIndex = 3;
            this.txtNumeroTelefono.TextChanged += new System.EventHandler(this.txtNumeroTelefono_TextChanged);
            this.txtNumeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefono_KeyPress);
            // 
            // btnAggiungiEntry
            // 
            this.btnAggiungiEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAggiungiEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiEntry.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnAggiungiEntry.Location = new System.Drawing.Point(591, 340);
            this.btnAggiungiEntry.Name = "btnAggiungiEntry";
            this.btnAggiungiEntry.Size = new System.Drawing.Size(75, 57);
            this.btnAggiungiEntry.TabIndex = 13;
            this.btnAggiungiEntry.UseVisualStyleBackColor = false;
            this.btnAggiungiEntry.Click += new System.EventHandler(this.btnAggiungiEntry_Click);
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIndietro.Image = ((System.Drawing.Image)(resources.GetObject("btnIndietro.Image")));
            this.btnIndietro.Location = new System.Drawing.Point(80, 45);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(77, 57);
            this.btnIndietro.TabIndex = 15;
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click_1);
            // 
            // aggiungiCommissione
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnAggiungiEntry);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblDescrizioneCommissione);
            this.Controls.Add(this.txtDescrizioneCommissione);
            this.Controls.Add(this.lblDataScadenza);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpScadenza);
            this.Name = "aggiungiCommissione";
            this.Size = new System.Drawing.Size(764, 485);
            this.Load += new System.EventHandler(this.aggiungiCommissione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpScadenza;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblDataScadenza;
        private System.Windows.Forms.TextBox txtDescrizioneCommissione;
        private System.Windows.Forms.Label lblDescrizioneCommissione;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnAggiungiEntry;
        private System.Windows.Forms.Button btnIndietro;
    }
}
