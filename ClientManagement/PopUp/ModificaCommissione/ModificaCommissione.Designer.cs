
namespace ClientManagement
{
    partial class ModificaDati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTaskCompletato = new System.Windows.Forms.Label();
            this.lblDescrizioneCommissione = new System.Windows.Forms.Label();
            this.txtDescrizioneCommissione = new System.Windows.Forms.TextBox();
            this.lblDataScadenza = new System.Windows.Forms.Label();
            this.dtpScadenza = new System.Windows.Forms.DateTimePicker();
            this.cbxTask = new System.Windows.Forms.CheckBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaskCompletato
            // 
            this.lblTaskCompletato.AutoSize = true;
            this.lblTaskCompletato.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblTaskCompletato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTaskCompletato.Location = new System.Drawing.Point(16, 261);
            this.lblTaskCompletato.Name = "lblTaskCompletato";
            this.lblTaskCompletato.Size = new System.Drawing.Size(129, 19);
            this.lblTaskCompletato.TabIndex = 21;
            this.lblTaskCompletato.Text = "Task completato:";
            // 
            // lblDescrizioneCommissione
            // 
            this.lblDescrizioneCommissione.AutoSize = true;
            this.lblDescrizioneCommissione.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescrizioneCommissione.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescrizioneCommissione.Location = new System.Drawing.Point(12, 79);
            this.lblDescrizioneCommissione.Name = "lblDescrizioneCommissione";
            this.lblDescrizioneCommissione.Size = new System.Drawing.Size(226, 19);
            this.lblDescrizioneCommissione.TabIndex = 20;
            this.lblDescrizioneCommissione.Text = "Descrizione della commissione:";
            // 
            // txtDescrizioneCommissione
            // 
            this.txtDescrizioneCommissione.Location = new System.Drawing.Point(16, 101);
            this.txtDescrizioneCommissione.Multiline = true;
            this.txtDescrizioneCommissione.Name = "txtDescrizioneCommissione";
            this.txtDescrizioneCommissione.Size = new System.Drawing.Size(245, 140);
            this.txtDescrizioneCommissione.TabIndex = 17;
            // 
            // lblDataScadenza
            // 
            this.lblDataScadenza.AutoSize = true;
            this.lblDataScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataScadenza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataScadenza.Location = new System.Drawing.Point(12, 19);
            this.lblDataScadenza.Name = "lblDataScadenza";
            this.lblDataScadenza.Size = new System.Drawing.Size(73, 19);
            this.lblDataScadenza.TabIndex = 18;
            this.lblDataScadenza.Text = "Scadenza";
            // 
            // dtpScadenza
            // 
            this.dtpScadenza.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.dtpScadenza.Location = new System.Drawing.Point(16, 41);
            this.dtpScadenza.Name = "dtpScadenza";
            this.dtpScadenza.Size = new System.Drawing.Size(226, 25);
            this.dtpScadenza.TabIndex = 19;
            // 
            // cbxTask
            // 
            this.cbxTask.AutoSize = true;
            this.cbxTask.Location = new System.Drawing.Point(151, 266);
            this.cbxTask.Name = "cbxTask";
            this.cbxTask.Size = new System.Drawing.Size(15, 14);
            this.cbxTask.TabIndex = 22;
            this.cbxTask.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifica.Location = new System.Drawing.Point(172, 261);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(91, 34);
            this.btnModifica.TabIndex = 23;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // ModificaDati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(275, 312);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.cbxTask);
            this.Controls.Add(this.lblTaskCompletato);
            this.Controls.Add(this.lblDescrizioneCommissione);
            this.Controls.Add(this.txtDescrizioneCommissione);
            this.Controls.Add(this.lblDataScadenza);
            this.Controls.Add(this.dtpScadenza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaDati";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifica Dati";
            this.Load += new System.EventHandler(this.ModificaDati_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTaskCompletato;
        private System.Windows.Forms.Label lblDescrizioneCommissione;
        private System.Windows.Forms.TextBox txtDescrizioneCommissione;
        private System.Windows.Forms.Label lblDataScadenza;
        private System.Windows.Forms.DateTimePicker dtpScadenza;
        private System.Windows.Forms.CheckBox cbxTask;
        private System.Windows.Forms.Button btnModifica;
    }
}