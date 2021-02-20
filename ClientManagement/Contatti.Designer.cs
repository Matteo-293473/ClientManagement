
namespace ClientManagement
{
    partial class Contatti
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
            this.btnContatti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContatti
            // 
            this.btnContatti.Location = new System.Drawing.Point(124, 126);
            this.btnContatti.Name = "btnContatti";
            this.btnContatti.Size = new System.Drawing.Size(75, 23);
            this.btnContatti.TabIndex = 0;
            this.btnContatti.Text = "btnContatti";
            this.btnContatti.UseVisualStyleBackColor = true;
            // 
            // Contatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnContatti);
            this.Name = "Contatti";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContatti;
    }
}
