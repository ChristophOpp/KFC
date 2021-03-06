﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitzFriendsClub_KFC_
{
    public partial class MitarbeiterBearbeiten : Form
    {
        public MitarbeiterBearbeiten()
        {
            InitializeComponent();
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            VerwaltungCEO VerwaltungCEO = new VerwaltungCEO();
            VerwaltungCEO.Show();
            Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Show();
            Hide();
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                pb_kind.Image = Image.FromFile(file);
            }
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
    }
}
