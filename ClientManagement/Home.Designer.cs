
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
            this.btnRiduciAIcona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRiduciAIcona
            // 
            this.btnRiduciAIcona.BackColor = System.Drawing.Color.Black;
            this.btnRiduciAIcona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiduciAIcona.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRiduciAIcona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRiduciAIcona.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnRiduciAIcona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiduciAIcona.Location = new System.Drawing.Point(23, 22);
            this.btnRiduciAIcona.Name = "btnRiduciAIcona";
            this.btnRiduciAIcona.Size = new System.Drawing.Size(232, 61);
            this.btnRiduciAIcona.TabIndex = 8;
            this.btnRiduciAIcona.Text = "Nuova commissione";
            this.btnRiduciAIcona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRiduciAIcona.UseVisualStyleBackColor = false;
            this.btnRiduciAIcona.Click += new System.EventHandler(this.btnRiduciAIcona_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRiduciAIcona);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRiduciAIcona;
    }
}
