
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
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCommissioniScadenza = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScadenza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuovaCommission = new System.Windows.Forms.Button();
            this.lblCommissioniSettimana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCommissioniScadenza
            // 
            this.lstCommissioniScadenza.BackColor = System.Drawing.SystemColors.Window;
            this.lstCommissioniScadenza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCognome,
            this.clmEmail,
            this.clmNtel,
            this.clmComm,
            this.clmScadenza});
            this.lstCommissioniScadenza.FullRowSelect = true;
            this.lstCommissioniScadenza.GridLines = true;
            this.lstCommissioniScadenza.HideSelection = false;
            this.lstCommissioniScadenza.Location = new System.Drawing.Point(49, 189);
            this.lstCommissioniScadenza.Name = "lstCommissioniScadenza";
            this.lstCommissioniScadenza.Size = new System.Drawing.Size(660, 213);
            this.lstCommissioniScadenza.TabIndex = 0;
            this.lstCommissioniScadenza.UseCompatibleStateImageBehavior = false;
            this.lstCommissioniScadenza.View = System.Windows.Forms.View.Details;
            this.lstCommissioniScadenza.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // clmEmail
            // 
            this.clmEmail.DisplayIndex = 3;
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 120;
            // 
            // clmNtel
            // 
            this.clmNtel.DisplayIndex = 2;
            this.clmNtel.Text = "N. Tel.";
            this.clmNtel.Width = 125;
            // 
            // clmComm
            // 
            this.clmComm.Text = "Commissione";
            this.clmComm.Width = 150;
            // 
            // clmScadenza
            // 
            this.clmScadenza.Text = "Scadenza";
            this.clmScadenza.Width = 68;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(49, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "MODIFICA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuovaCommission
            // 
            this.btnNuovaCommission.BackColor = System.Drawing.Color.Black;
            this.btnNuovaCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuovaCommission.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuovaCommission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuovaCommission.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnNuovaCommission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuovaCommission.Location = new System.Drawing.Point(49, 49);
            this.btnNuovaCommission.Name = "btnNuovaCommission";
            this.btnNuovaCommission.Size = new System.Drawing.Size(239, 49);
            this.btnNuovaCommission.TabIndex = 14;
            this.btnNuovaCommission.Text = "Nuova commissione";
            this.btnNuovaCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuovaCommission.UseVisualStyleBackColor = false;
            this.btnNuovaCommission.Click += new System.EventHandler(this.btnNuovaCommission_Click);
            // 
            // lblCommissioniSettimana
            // 
            this.lblCommissioniSettimana.AutoSize = true;
            this.lblCommissioniSettimana.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblCommissioniSettimana.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCommissioniSettimana.Location = new System.Drawing.Point(45, 167);
            this.lblCommissioniSettimana.Name = "lblCommissioniSettimana";
            this.lblCommissioniSettimana.Size = new System.Drawing.Size(245, 19);
            this.lblCommissioniSettimana.TabIndex = 16;
            this.lblCommissioniSettimana.Text = "Commissioni di questa settimana:";
            // 
            // CommissioniInScadenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.lblCommissioniSettimana);
            this.Controls.Add(this.btnNuovaCommission);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuovaCommission;
        private System.Windows.Forms.Label lblCommissioniSettimana;
    }
}
