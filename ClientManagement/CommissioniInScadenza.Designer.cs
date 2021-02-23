
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
            this.txtCommissioniScadenza = new System.Windows.Forms.Label();
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
            this.lstCommissioniScadenza.Location = new System.Drawing.Point(49, 85);
            this.lstCommissioniScadenza.Name = "lstCommissioniScadenza";
            this.lstCommissioniScadenza.Size = new System.Drawing.Size(660, 291);
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
            // txtCommissioniScadenza
            // 
            this.txtCommissioniScadenza.AutoSize = true;
            this.txtCommissioniScadenza.Enabled = false;
            this.txtCommissioniScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.txtCommissioniScadenza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCommissioniScadenza.Location = new System.Drawing.Point(45, 63);
            this.txtCommissioniScadenza.Name = "txtCommissioniScadenza";
            this.txtCommissioniScadenza.Size = new System.Drawing.Size(187, 19);
            this.txtCommissioniScadenza.TabIndex = 1;
            this.txtCommissioniScadenza.Text = "Commissioni in scadenza:";
            // 
            // CommissioniInScadenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCommissioniScadenza);
            this.Controls.Add(this.lstCommissioniScadenza);
            this.Name = "CommissioniInScadenza";
            this.Size = new System.Drawing.Size(764, 400);
            this.Load += new System.EventHandler(this.CommissioniInScadenza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCommissioniScadenza;
        private System.Windows.Forms.Label txtCommissioniScadenza;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmNtel;
        private System.Windows.Forms.ColumnHeader clmComm;
        private System.Windows.Forms.ColumnHeader clmScadenza;
    }
}
