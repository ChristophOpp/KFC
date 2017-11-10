namespace KitzFriendsClub_KFC_
{
    partial class KinderEntfernen
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
            this.lbl_groupname = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_groupname
            // 
            this.lbl_groupname.AutoSize = true;
            this.lbl_groupname.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_groupname.ForeColor = System.Drawing.Color.Gold;
            this.lbl_groupname.Location = new System.Drawing.Point(497, 19);
            this.lbl_groupname.Name = "lbl_groupname";
            this.lbl_groupname.Size = new System.Drawing.Size(145, 25);
            this.lbl_groupname.TabIndex = 5;
            this.lbl_groupname.Text = "Gruppenname";
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_group.ForeColor = System.Drawing.Color.Gold;
            this.lbl_group.Location = new System.Drawing.Point(368, 19);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(135, 25);
            this.lbl_group.TabIndex = 4;
            this.lbl_group.Text = "Ihre Gruppe: ";
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(373, 47);
            this.txt_group.Multiline = true;
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(269, 226);
            this.txt_group.TabIndex = 3;
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loeschen.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loeschen.ForeColor = System.Drawing.Color.Gold;
            this.btn_loeschen.Location = new System.Drawing.Point(12, 199);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(167, 31);
            this.btn_loeschen.TabIndex = 13;
            this.btn_loeschen.Text = "Kind löschen";
            this.btn_loeschen.UseVisualStyleBackColor = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.Gold;
            this.lbl_username.Location = new System.Drawing.Point(66, 22);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(54, 20);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Name";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_user.ForeColor = System.Drawing.Color.Gold;
            this.lbl_user.Location = new System.Drawing.Point(12, 22);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(48, 20);
            this.lbl_user.TabIndex = 10;
            this.lbl_user.Text = "User:";
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zurueck.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_zurueck.ForeColor = System.Drawing.Color.Gold;
            this.btn_zurueck.Location = new System.Drawing.Point(12, 265);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(167, 31);
            this.btn_zurueck.TabIndex = 14;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            // 
            // KinderEntfernen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(654, 308);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_groupname);
            this.Controls.Add(this.lbl_group);
            this.Controls.Add(this.txt_group);
            this.Name = "KinderEntfernen";
            this.Text = "Kinder Entfernen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_groupname;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_zurueck;
    }
}