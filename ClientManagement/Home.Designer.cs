
namespace ClientManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnNuovaCommission = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.aggiungiCommissione1 = new ClientManagement.Resources.aggiungiCommissione();
            this.commissioniInScadenza1 = new ClientManagement.CommissioniInScadenza();
            this.SuspendLayout();
            // 
            // btnNuovaCommission
            // 
            this.btnNuovaCommission.BackColor = System.Drawing.Color.Black;
            this.btnNuovaCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuovaCommission.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuovaCommission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuovaCommission.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnNuovaCommission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuovaCommission.Location = new System.Drawing.Point(27, 26);
            this.btnNuovaCommission.Name = "btnNuovaCommission";
            this.btnNuovaCommission.Size = new System.Drawing.Size(239, 49);
            this.btnNuovaCommission.TabIndex = 13;
            this.btnNuovaCommission.Text = "Nuova commissione";
            this.btnNuovaCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuovaCommission.UseVisualStyleBackColor = false;
            this.btnNuovaCommission.Click += new System.EventHandler(this.BtnNuovaCommissione);
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIndietro.Image = ((System.Drawing.Image)(resources.GetObject("btnIndietro.Image")));
            this.btnIndietro.Location = new System.Drawing.Point(54, 23);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(77, 57);
            this.btnIndietro.TabIndex = 14;
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // aggiungiCommissione1
            // 
            this.aggiungiCommissione1.Location = new System.Drawing.Point(0, 85);
            this.aggiungiCommissione1.Name = "aggiungiCommissione1";
            this.aggiungiCommissione1.Size = new System.Drawing.Size(764, 400);
            this.aggiungiCommissione1.TabIndex = 15;
            // 
            // commissioniInScadenza1
            // 
            this.commissioniInScadenza1.Location = new System.Drawing.Point(0, 86);
            this.commissioniInScadenza1.Name = "commissioniInScadenza1";
            this.commissioniInScadenza1.Size = new System.Drawing.Size(764, 400);
            this.commissioniInScadenza1.TabIndex = 16;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commissioniInScadenza1);
            this.Controls.Add(this.aggiungiCommissione1);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnNuovaCommission);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuovaCommission;
        private System.Windows.Forms.Button btnIndietro;
        private Resources.aggiungiCommissione aggiungiCommissione1;
        private CommissioniInScadenza commissioniInScadenza1;
    }
}
