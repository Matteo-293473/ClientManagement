
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
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstContatti = new System.Windows.Forms.ListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuovoCliente = new System.Windows.Forms.Button();
            this.clmIdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstContatti
            // 
            this.lstContatti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCognome,
            this.clmNumero,
            this.clmEmail,
            this.clmIdCliente});
            this.lstContatti.FullRowSelect = true;
            this.lstContatti.GridLines = true;
            this.lstContatti.HideSelection = false;
            this.lstContatti.Location = new System.Drawing.Point(40, 136);
            this.lstContatti.Name = "lstContatti";
            this.lstContatti.Size = new System.Drawing.Size(660, 291);
            this.lstContatti.TabIndex = 2;
            this.lstContatti.UseCompatibleStateImageBehavior = false;
            this.lstContatti.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 104;
            // 
            // clmCognome
            // 
            this.clmCognome.Text = "Cognome";
            this.clmCognome.Width = 137;
            // 
            // clmNumero
            // 
            this.clmNumero.Text = "N. Tel.";
            this.clmNumero.Width = 186;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 132;
            // 
            // btnNuovoCliente
            // 
            this.btnNuovoCliente.BackColor = System.Drawing.Color.Black;
            this.btnNuovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuovoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuovoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuovoCliente.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnNuovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuovoCliente.Location = new System.Drawing.Point(40, 45);
            this.btnNuovoCliente.Name = "btnNuovoCliente";
            this.btnNuovoCliente.Size = new System.Drawing.Size(188, 49);
            this.btnNuovoCliente.TabIndex = 15;
            this.btnNuovoCliente.Text = "Nuovo cliente";
            this.btnNuovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuovoCliente.UseVisualStyleBackColor = false;
            this.btnNuovoCliente.Click += new System.EventHandler(this.btnNuovoCliente_Click);
            // 
            // clmIdCliente
            // 
            this.clmIdCliente.Text = "Id Cliente";
            this.clmIdCliente.Width = 80;
            // 
            // ListaContatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.btnNuovoCliente);
            this.Controls.Add(this.lstContatti);
            this.Name = "ListaContatti";
            this.Size = new System.Drawing.Size(764, 485);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstContatti;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCognome;
        private System.Windows.Forms.ColumnHeader clmNumero;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.Button btnNuovoCliente;
        private System.Windows.Forms.ColumnHeader clmIdCliente;
    }
}
