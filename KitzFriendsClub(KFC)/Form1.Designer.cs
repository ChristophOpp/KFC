namespace KitzFriendsClub_KFC_
{
    partial class LogIn
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCEO = new System.Windows.Forms.RadioButton();
            this.rbMitarbeiter = new System.Windows.Forms.RadioButton();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(398, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(154, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitz Friends Club";
            // 
            // rbCEO
            // 
            this.rbCEO.AutoSize = true;
            this.rbCEO.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold);
            this.rbCEO.ForeColor = System.Drawing.Color.Gold;
            this.rbCEO.Location = new System.Drawing.Point(12, 105);
            this.rbCEO.Name = "rbCEO";
            this.rbCEO.Size = new System.Drawing.Size(51, 20);
            this.rbCEO.TabIndex = 2;
            this.rbCEO.TabStop = true;
            this.rbCEO.Text = "CEO";
            this.rbCEO.UseVisualStyleBackColor = true;
            this.rbCEO.CheckedChanged += new System.EventHandler(this.rbGF_CheckedChanged);
            // 
            // rbMitarbeiter
            // 
            this.rbMitarbeiter.AutoSize = true;
            this.rbMitarbeiter.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold);
            this.rbMitarbeiter.ForeColor = System.Drawing.Color.Gold;
            this.rbMitarbeiter.Location = new System.Drawing.Point(12, 130);
            this.rbMitarbeiter.Name = "rbMitarbeiter";
            this.rbMitarbeiter.Size = new System.Drawing.Size(87, 20);
            this.rbMitarbeiter.TabIndex = 3;
            this.rbMitarbeiter.TabStop = true;
            this.rbMitarbeiter.Text = "Mitarbeiter";
            this.rbMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(237, 105);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(142, 20);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(237, 131);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(142, 20);
            this.txt_password.TabIndex = 5;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.Gold;
            this.lbl_username.Location = new System.Drawing.Point(158, 108);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(70, 16);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.Gold;
            this.lbl_password.Location = new System.Drawing.Point(160, 134);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 16);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "username: FayKay  password: Test1!";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(561, 226);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.rbMitarbeiter);
            this.Controls.Add(this.rbCEO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn - KFC";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCEO;
        private System.Windows.Forms.RadioButton rbMitarbeiter;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label label2;
    }
}

