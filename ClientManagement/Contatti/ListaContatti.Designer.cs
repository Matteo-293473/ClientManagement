
namespace ClientManagement.Contatti
{
    partial class ListaContatti
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
            this.lstContatti = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuovoCliente = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblClienti = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstContatti
            // 
            this.lstContatti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCognome,
            this.clmNumero,
            this.clmEmail,
            this.clmId});
            this.lstContatti.FullRowSelect = true;
            this.lstContatti.GridLines = true;
            this.lstContatti.HideSelection = false;
            this.lstContatti.Location = new System.Drawing.Point(50, 154);
            this.lstContatti.Name = "lstContatti";
            this.lstContatti.Size = new System.Drawing.Size(677, 225);
            this.lstContatti.TabIndex = 2;
            this.lstContatti.UseCompatibleStateImageBehavior = false;
            this.lstContatti.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 122;
            // 
            // clmCognome
            // 
            this.clmCognome.Text = "Cognome";
            this.clmCognome.Width = 160;
            // 
            // clmNumero
            // 
            this.clmNumero.DisplayIndex = 2;
            this.clmNumero.Text = "N. Tel.";
            this.clmNumero.Width = 156;
            // 
            // clmEmail
            // 
            this.clmEmail.DisplayIndex = 3;
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 168;
            // 
            // btnNuovoCliente
            // 
            this.btnNuovoCliente.BackColor = System.Drawing.Color.Black;
            this.btnNuovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuovoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuovoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuovoCliente.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnNuovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuovoCliente.Location = new System.Drawing.Point(49, 48);
            this.btnNuovoCliente.Name = "btnNuovoCliente";
            this.btnNuovoCliente.Size = new System.Drawing.Size(188, 49);
            this.btnNuovoCliente.TabIndex = 15;
            this.btnNuovoCliente.Text = "Nuovo cliente";
            this.btnNuovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuovoCliente.UseVisualStyleBackColor = false;
            this.btnNuovoCliente.Click += new System.EventHandler(this.btnNuovoCliente_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifica.Location = new System.Drawing.Point(50, 405);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(115, 38);
            this.btnModifica.TabIndex = 16;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblClienti
            // 
            this.lblClienti.AutoSize = true;
            this.lblClienti.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblClienti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClienti.Location = new System.Drawing.Point(45, 132);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(57, 19);
            this.lblClienti.TabIndex = 17;
            this.lblClienti.Text = "Clienti:";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElimina.Location = new System.Drawing.Point(171, 405);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(115, 38);
            this.btnElimina.TabIndex = 18;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // clmId
            // 
            this.clmId.Text = "Id";
            // 
            // ListaContatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.lblClienti);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnNuovoCliente);
            this.Controls.Add(this.lstContatti);
            this.Name = "ListaContatti";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstContatti;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmNumero;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.Button btnNuovoCliente;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lblClienti;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.ColumnHeader clmId;
    }
}
