namespace KitzFriendsClub_KFC_
{
    partial class VerwaltungMitarbeiter
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
            this.lbl_group = new System.Windows.Forms.Label();
            this.lbl_groupname = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.btn_neu = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.dgv_gruppenmitglieder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gruppenmitglieder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_group.ForeColor = System.Drawing.Color.Gold;
            this.lbl_group.Location = new System.Drawing.Point(342, 18);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(135, 25);
            this.lbl_group.TabIndex = 1;
            this.lbl_group.Text = "Ihre Gruppe: ";
            this.lbl_group.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_groupname
            // 
            this.lbl_groupname.AutoSize = true;
            this.lbl_groupname.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_groupname.ForeColor = System.Drawing.Color.Gold;
            this.lbl_groupname.Location = new System.Drawing.Point(471, 18);
            this.lbl_groupname.Name = "lbl_groupname";
            this.lbl_groupname.Size = new System.Drawing.Size(145, 25);
            this.lbl_groupname.TabIndex = 2;
            this.lbl_groupname.Text = "Gruppenname";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_user.ForeColor = System.Drawing.Color.Gold;
            this.lbl_user.Location = new System.Drawing.Point(12, 74);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(48, 20);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.Gold;
            this.lbl_username.Location = new System.Drawing.Point(66, 74);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(54, 20);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Name";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.ForeColor = System.Drawing.Color.Gold;
            this.lbl_welcome.Location = new System.Drawing.Point(12, 18);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(132, 25);
            this.lbl_welcome.TabIndex = 6;
            this.lbl_welcome.Text = "Willkommen!";
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bearbeiten.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bearbeiten.ForeColor = System.Drawing.Color.Gold;
            this.btn_bearbeiten.Location = new System.Drawing.Point(12, 166);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(167, 31);
            this.btn_bearbeiten.TabIndex = 7;
            this.btn_bearbeiten.Text = "Kinder bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loeschen.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loeschen.ForeColor = System.Drawing.Color.Gold;
            this.btn_loeschen.Location = new System.Drawing.Point(12, 240);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(167, 31);
            this.btn_loeschen.TabIndex = 8;
            this.btn_loeschen.Text = "Kinder löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            // 
            // btn_neu
            // 
            this.btn_neu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_neu.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_neu.ForeColor = System.Drawing.Color.Gold;
            this.btn_neu.Location = new System.Drawing.Point(12, 203);
            this.btn_neu.Name = "btn_neu";
            this.btn_neu.Size = new System.Drawing.Size(167, 31);
            this.btn_neu.TabIndex = 9;
            this.btn_neu.Text = "Neues Kind";
            this.btn_neu.UseVisualStyleBackColor = true;
            this.btn_neu.Click += new System.EventHandler(this.btn_neu_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.Gold;
            this.btn_logout.Location = new System.Drawing.Point(12, 371);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(83, 31);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // dgv_gruppenmitglieder
            // 
            this.dgv_gruppenmitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gruppenmitglieder.Location = new System.Drawing.Point(347, 46);
            this.dgv_gruppenmitglieder.Name = "dgv_gruppenmitglieder";
            this.dgv_gruppenmitglieder.Size = new System.Drawing.Size(265, 356);
            this.dgv_gruppenmitglieder.TabIndex = 26;
            // 
            // VerwaltungMitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(624, 414);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_gruppenmitglieder);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_neu);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_bearbeiten);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_groupname);
            this.Controls.Add(this.lbl_group);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerwaltungMitarbeiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwaltung Mitarbeiter";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gruppenmitglieder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Label lbl_groupname;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Button btn_neu;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DataGridView dgv_gruppenmitglieder;
    }
}