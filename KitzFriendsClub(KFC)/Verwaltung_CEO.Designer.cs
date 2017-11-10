namespace KitzFriendsClub_KFC_
{
    partial class VerwaltungCEO
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_neu = new System.Windows.Forms.Button();
            this.btn_CeoStammdaten = new System.Windows.Forms.Button();
            this.dgv_mitarbeiter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mitarbeiter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.Gold;
            this.btn_logout.Location = new System.Drawing.Point(13, 376);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(83, 31);
            this.btn_logout.TabIndex = 22;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Willkommen!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(343, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ihre Mitarbeiter:";
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bearbeiten.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bearbeiten.ForeColor = System.Drawing.Color.Gold;
            this.btn_bearbeiten.Location = new System.Drawing.Point(13, 162);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(167, 31);
            this.btn_bearbeiten.TabIndex = 19;
            this.btn_bearbeiten.Text = "Mitarbeiter bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loeschen.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loeschen.ForeColor = System.Drawing.Color.Gold;
            this.btn_loeschen.Location = new System.Drawing.Point(13, 236);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(167, 31);
            this.btn_loeschen.TabIndex = 20;
            this.btn_loeschen.Text = "Mitarbeiter löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            // 
            // btn_neu
            // 
            this.btn_neu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_neu.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_neu.ForeColor = System.Drawing.Color.Gold;
            this.btn_neu.Location = new System.Drawing.Point(13, 199);
            this.btn_neu.Name = "btn_neu";
            this.btn_neu.Size = new System.Drawing.Size(167, 31);
            this.btn_neu.TabIndex = 21;
            this.btn_neu.Text = "Neuer Mitarbeiter";
            this.btn_neu.UseVisualStyleBackColor = true;
            this.btn_neu.Click += new System.EventHandler(this.btn_neu_Click);
            // 
            // btn_CeoStammdaten
            // 
            this.btn_CeoStammdaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CeoStammdaten.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CeoStammdaten.ForeColor = System.Drawing.Color.Gold;
            this.btn_CeoStammdaten.Location = new System.Drawing.Point(13, 273);
            this.btn_CeoStammdaten.Name = "btn_CeoStammdaten";
            this.btn_CeoStammdaten.Size = new System.Drawing.Size(167, 31);
            this.btn_CeoStammdaten.TabIndex = 24;
            this.btn_CeoStammdaten.Text = "Eigene Stammdaten";
            this.btn_CeoStammdaten.UseVisualStyleBackColor = true;
            this.btn_CeoStammdaten.Click += new System.EventHandler(this.btn_CeoStammdaten_Click);
            // 
            // dgv_mitarbeiter
            // 
            this.dgv_mitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mitarbeiter.Location = new System.Drawing.Point(348, 42);
            this.dgv_mitarbeiter.Name = "dgv_mitarbeiter";
            this.dgv_mitarbeiter.Size = new System.Drawing.Size(276, 365);
            this.dgv_mitarbeiter.TabIndex = 25;
            // 
            // VerwaltungCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(636, 419);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_mitarbeiter);
            this.Controls.Add(this.btn_CeoStammdaten);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_neu);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_bearbeiten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerwaltungCEO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwaltung_CEO";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mitarbeiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_neu;
        private System.Windows.Forms.Button btn_CeoStammdaten;
        private System.Windows.Forms.DataGridView dgv_mitarbeiter;
    }
}