using System;
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
    public partial class VerwaltungMitarbeiter : Form
    {
        public VerwaltungMitarbeiter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Show();
            Hide();

        }

        private void btn_neu_Click(object sender, EventArgs e)
        {
            NeuesKind NeuesKind = new NeuesKind();
            NeuesKind.Show();
            Hide();
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            KinderBearbeiten KinderBearbeiten = new KinderBearbeiten();
            KinderBearbeiten.Show();
            Hide();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Show();
            Hide();
        }
    }
}
