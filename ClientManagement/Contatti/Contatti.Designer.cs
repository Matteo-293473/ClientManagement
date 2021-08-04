
namespace ClientManagement.Contatti
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
            this.listaContatti1 = new ListaContatti();
            this.aggiungiContatto1 = new AggiungiContatto();
            this.SuspendLayout();
            // 
            // listaContatti1
            // 
            this.listaContatti1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.listaContatti1.Location = new System.Drawing.Point(-3, -3);
            this.listaContatti1.Name = "listaContatti1";
            this.listaContatti1.Size = new System.Drawing.Size(764, 485);
            this.listaContatti1.TabIndex = 0;
            // 
            // aggiungiContatto1
            // 
            this.aggiungiContatto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.aggiungiContatto1.Location = new System.Drawing.Point(3, 3);
            this.aggiungiContatto1.Name = "aggiungiContatto1";
            this.aggiungiContatto1.Size = new System.Drawing.Size(764, 485);
            this.aggiungiContatto1.TabIndex = 1;
            // 
            // Contatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.aggiungiContatto1);
            this.Controls.Add(this.listaContatti1);
            this.Name = "Contatti";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion

        private ListaContatti listaContatti1;
        private AggiungiContatto aggiungiContatto1;
    }
}
