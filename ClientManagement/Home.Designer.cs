
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
            this.aggiungiCommissione1 = new Resources.aggiungiCommissione();
            this.commissioniInScadenza1 = new CommissioniInScadenza();
            this.SuspendLayout();
            // 
            // aggiungiCommissione1
            // 
            this.aggiungiCommissione1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.aggiungiCommissione1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aggiungiCommissione1.Location = new System.Drawing.Point(0, 0);
            this.aggiungiCommissione1.Name = "aggiungiCommissione1";
            this.aggiungiCommissione1.Size = new System.Drawing.Size(764, 485);
            this.aggiungiCommissione1.TabIndex = 1;
            // 
            // commissioniInScadenza1
            // 
            this.commissioniInScadenza1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.commissioniInScadenza1.Location = new System.Drawing.Point(0, 3);
            this.commissioniInScadenza1.Name = "commissioniInScadenza1";
            this.commissioniInScadenza1.Size = new System.Drawing.Size(764, 485);
            this.commissioniInScadenza1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commissioniInScadenza1);
            this.Controls.Add(this.aggiungiCommissione1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.aggiungiCommissione aggiungiCommissione1;
        private CommissioniInScadenza commissioniInScadenza1;
    }
}
