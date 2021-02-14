
namespace ClientManagement
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlSideMenu = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.BtnRubrica = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PctBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnRiduciAIcona = new System.Windows.Forms.Button();
            this.PnlSideMenu.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSideMenu
            // 
            this.PnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PnlSideMenu.Controls.Add(this.BtnRubrica);
            this.PnlSideMenu.Controls.Add(this.BtnHome);
            this.PnlSideMenu.Controls.Add(this.btnRiduciAIcona);
            this.PnlSideMenu.Controls.Add(this.PnlLogo);
            this.PnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlSideMenu.Name = "PnlSideMenu";
            this.PnlSideMenu.Size = new System.Drawing.Size(145, 485);
            this.PnlSideMenu.TabIndex = 1;
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.PctBoxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(145, 111);
            this.PnlLogo.TabIndex = 10;
            this.PnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLogo_Paint);
            // 
            // BtnRubrica
            // 
            this.BtnRubrica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnRubrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRubrica.FlatAppearance.BorderSize = 0;
            this.BtnRubrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRubrica.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnRubrica.Image = global::ClientManagement.Properties.Resources.appbar_book_contact;
            this.BtnRubrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRubrica.Location = new System.Drawing.Point(0, 164);
            this.BtnRubrica.Name = "BtnRubrica";
            this.BtnRubrica.Size = new System.Drawing.Size(145, 53);
            this.BtnRubrica.TabIndex = 12;
            this.BtnRubrica.Text = "Rubrica";
            this.BtnRubrica.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnRubrica.UseVisualStyleBackColor = false;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnHome.Image = global::ClientManagement.Properties.Resources.appbar_home;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 111);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(145, 53);
            this.BtnHome.TabIndex = 11;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PctBoxLogo
            // 
            this.PctBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PctBoxLogo.Image = global::ClientManagement.Properties.Resources.clientManagement1;
            this.PctBoxLogo.Location = new System.Drawing.Point(0, -3);
            this.PctBoxLogo.Name = "PctBoxLogo";
            this.PctBoxLogo.Size = new System.Drawing.Size(145, 111);
            this.PctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBoxLogo.TabIndex = 0;
            this.PctBoxLogo.TabStop = false;
            this.PctBoxLogo.Click += new System.EventHandler(this.PctBoxLogo_Click);
            // 
            // btnRiduciAIcona
            // 
            this.btnRiduciAIcona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRiduciAIcona.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnRiduciAIcona.Location = new System.Drawing.Point(29, 367);
            this.btnRiduciAIcona.Name = "btnRiduciAIcona";
            this.btnRiduciAIcona.Size = new System.Drawing.Size(71, 66);
            this.btnRiduciAIcona.TabIndex = 5;
            this.btnRiduciAIcona.UseVisualStyleBackColor = false;
            this.btnRiduciAIcona.Click += new System.EventHandler(this.btnRiduciAIcona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.PnlSideMenu);
            this.Name = "Form1";
            this.Text = "ClientManagement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlSideMenu.ResumeLayout(false);
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlSideMenu;
        private System.Windows.Forms.Button btnRiduciAIcona;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnRubrica;
        private System.Windows.Forms.PictureBox PctBoxLogo;
    }
}

