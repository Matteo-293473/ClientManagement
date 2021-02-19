
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlSideMenu = new System.Windows.Forms.Panel();
            this.btnRubrica = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.btnRiduciAIcona = new System.Windows.Forms.Button();
            this.btnScadenze = new System.Windows.Forms.Button();
            this.btnCommissioni = new System.Windows.Forms.Button();
            this.PctBoxLogo = new System.Windows.Forms.PictureBox();
            this.PnlSideMenu.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSideMenu
            // 
            this.PnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PnlSideMenu.Controls.Add(this.btnScadenze);
            this.PnlSideMenu.Controls.Add(this.btnCommissioni);
            this.PnlSideMenu.Controls.Add(this.btnRubrica);
            this.PnlSideMenu.Controls.Add(this.btnHome);
            this.PnlSideMenu.Controls.Add(this.PnlLogo);
            this.PnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlSideMenu.Name = "PnlSideMenu";
            this.PnlSideMenu.Size = new System.Drawing.Size(176, 485);
            this.PnlSideMenu.TabIndex = 1;
            // 
            // btnRubrica
            // 
            this.btnRubrica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnRubrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRubrica.FlatAppearance.BorderSize = 0;
            this.btnRubrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubrica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRubrica.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRubrica.Image = global::ClientManagement.Properties.Resources.appbar_book_contact;
            this.btnRubrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRubrica.Location = new System.Drawing.Point(0, 164);
            this.btnRubrica.Name = "btnRubrica";
            this.btnRubrica.Size = new System.Drawing.Size(176, 53);
            this.btnRubrica.TabIndex = 12;
            this.btnRubrica.Text = "Rubrica";
            this.btnRubrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRubrica.UseVisualStyleBackColor = false;
            this.btnRubrica.Click += new System.EventHandler(this.BtnRubrica_Click);
            this.btnRubrica.Leave += new System.EventHandler(this.btnRubrica_Leave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHome.Image = global::ClientManagement.Properties.Resources.appbar_home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 111);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(176, 53);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.PctBoxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(176, 111);
            this.PnlLogo.TabIndex = 10;
            this.PnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLogo_Paint);
            // 
            // btnRiduciAIcona
            // 
            this.btnRiduciAIcona.BackColor = System.Drawing.Color.Black;
            this.btnRiduciAIcona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiduciAIcona.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnRiduciAIcona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRiduciAIcona.Image = global::ClientManagement.Properties.Resources.appbar_add;
            this.btnRiduciAIcona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiduciAIcona.Location = new System.Drawing.Point(182, 61);
            this.btnRiduciAIcona.Name = "btnRiduciAIcona";
            this.btnRiduciAIcona.Size = new System.Drawing.Size(225, 50);
            this.btnRiduciAIcona.TabIndex = 5;
            this.btnRiduciAIcona.Text = "Nuova commissione";
            this.btnRiduciAIcona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRiduciAIcona.UseVisualStyleBackColor = false;
            this.btnRiduciAIcona.Click += new System.EventHandler(this.btnRiduciAIcona_Click);
            // 
            // btnScadenze
            // 
            this.btnScadenze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnScadenze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScadenze.FlatAppearance.BorderSize = 0;
            this.btnScadenze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScadenze.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScadenze.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnScadenze.Image = ((System.Drawing.Image)(resources.GetObject("btnScadenze.Image")));
            this.btnScadenze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScadenze.Location = new System.Drawing.Point(0, 270);
            this.btnScadenze.Name = "btnScadenze";
            this.btnScadenze.Size = new System.Drawing.Size(176, 53);
            this.btnScadenze.TabIndex = 14;
            this.btnScadenze.Text = "Scadenze";
            this.btnScadenze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScadenze.UseVisualStyleBackColor = false;
            this.btnScadenze.Click += new System.EventHandler(this.BtnScadenze_Click);
            this.btnScadenze.Leave += new System.EventHandler(this.btnScadenze_Leave);
            // 
            // btnCommissioni
            // 
            this.btnCommissioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCommissioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommissioni.FlatAppearance.BorderSize = 0;
            this.btnCommissioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommissioni.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommissioni.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCommissioni.Image = ((System.Drawing.Image)(resources.GetObject("btnCommissioni.Image")));
            this.btnCommissioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommissioni.Location = new System.Drawing.Point(0, 217);
            this.btnCommissioni.Name = "btnCommissioni";
            this.btnCommissioni.Size = new System.Drawing.Size(176, 53);
            this.btnCommissioni.TabIndex = 13;
            this.btnCommissioni.Text = "Commissioni";
            this.btnCommissioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCommissioni.UseVisualStyleBackColor = false;
            this.btnCommissioni.Click += new System.EventHandler(this.BtnCommissioni_Click);
            this.btnCommissioni.Leave += new System.EventHandler(this.btnCommissioni_Leave);
            // 
            // PctBoxLogo
            // 
            this.PctBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PctBoxLogo.Image = global::ClientManagement.Properties.Resources.clientManagement;
            this.PctBoxLogo.Location = new System.Drawing.Point(3, 0);
            this.PctBoxLogo.Name = "PctBoxLogo";
            this.PctBoxLogo.Size = new System.Drawing.Size(173, 111);
            this.PctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBoxLogo.TabIndex = 0;
            this.PctBoxLogo.TabStop = false;
            this.PctBoxLogo.Click += new System.EventHandler(this.PctBoxLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.PnlSideMenu);
            this.Controls.Add(this.btnRiduciAIcona);
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
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRubrica;
        private System.Windows.Forms.PictureBox PctBoxLogo;
        private System.Windows.Forms.Button btnCommissioni;
        private System.Windows.Forms.Button btnScadenze;
    }
}

