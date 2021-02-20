﻿
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
            this.btnRiduciAIcona = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.aggiungiCommissione1 = new ClientManagement.Resources.aggiungiCommissione();
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
            this.btnRiduciAIcona.Location = new System.Drawing.Point(177, 26);
            this.btnRiduciAIcona.Name = "btnRiduciAIcona";
            this.btnRiduciAIcona.Size = new System.Drawing.Size(239, 49);
            this.btnRiduciAIcona.TabIndex = 13;
            this.btnRiduciAIcona.Text = "Nuova commissione";
            this.btnRiduciAIcona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRiduciAIcona.UseVisualStyleBackColor = false;
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
            // 
            // aggiungiCommissione1
            // 
            this.aggiungiCommissione1.Location = new System.Drawing.Point(-3, 86);
            this.aggiungiCommissione1.Name = "aggiungiCommissione1";
            this.aggiungiCommissione1.Size = new System.Drawing.Size(764, 399);
            this.aggiungiCommissione1.TabIndex = 15;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aggiungiCommissione1);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnRiduciAIcona);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRiduciAIcona;
        private System.Windows.Forms.Button btnIndietro;
        private Resources.aggiungiCommissione aggiungiCommissione1;
    }
}
