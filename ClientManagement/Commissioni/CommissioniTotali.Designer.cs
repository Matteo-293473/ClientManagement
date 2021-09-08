
namespace ClientManagement.Commissioni
{
    partial class CommissioniTotali
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
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScadenza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCompletato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
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
            this.clmId,
            this.clmCompletato});
            this.lstCommissioniScadenza.FullRowSelect = true;
            this.lstCommissioniScadenza.GridLines = true;
            this.lstCommissioniScadenza.HideSelection = false;
            this.lstCommissioniScadenza.Location = new System.Drawing.Point(49, 47);
            this.lstCommissioniScadenza.Name = "lstCommissioniScadenza";
            this.lstCommissioniScadenza.Size = new System.Drawing.Size(680, 338);
            this.lstCommissioniScadenza.TabIndex = 1;
            this.lstCommissioniScadenza.UseCompatibleStateImageBehavior = false;
            this.lstCommissioniScadenza.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 77;
            // 
            // clmCognome
            // 
            this.clmCognome.Text = "Cognome";
            this.clmCognome.Width = 95;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 92;
            // 
            // clmNtel
            // 
            this.clmNtel.Text = "N. Tel.";
            this.clmNtel.Width = 93;
            // 
            // clmComm
            // 
            this.clmComm.Text = "Commissione";
            this.clmComm.Width = 125;
            // 
            // clmScadenza
            // 
            this.clmScadenza.Text = "Scadenza";
            this.clmScadenza.Width = 70;
            // 
            // clmId
            // 
            this.clmId.Text = "id";
            this.clmId.Width = 54;
            // 
            // clmCompletato
            // 
            this.clmCompletato.Text = "Completato";
            this.clmCompletato.Width = 70;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVisualizza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnVisualizza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVisualizza.Location = new System.Drawing.Point(49, 405);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(115, 38);
            this.btnVisualizza.TabIndex = 18;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = false;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifica.Location = new System.Drawing.Point(170, 405);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(104, 38);
            this.btnModifica.TabIndex = 19;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElimina.Location = new System.Drawing.Point(280, 405);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(104, 38);
            this.btnElimina.TabIndex = 20;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // CommissioniTotali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lstCommissioniScadenza);
            this.Name = "CommissioniTotali";
            this.Size = new System.Drawing.Size(764, 485);
            this.Load += new System.EventHandler(this.CommissioniTotali_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCommissioniScadenza;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmNtel;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmComm;
        private System.Windows.Forms.ColumnHeader clmScadenza;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmCompletato;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
    }
}
