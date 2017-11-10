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
    public partial class VerwaltungCEO : Form
    {
        public VerwaltungCEO()
        {
            InitializeComponent();
        }

        private void btn_CeoStammdaten_Click(object sender, EventArgs e)
        {
            CEO_Daten CEO_Daten = new CEO_Daten();
            CEO_Daten.Show();
            Hide();
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            MitarbeiterBearbeiten MitarbeiterBearbeiten = new MitarbeiterBearbeiten();
            MitarbeiterBearbeiten.Show();
            Hide();
        }

        private void btn_neu_Click(object sender, EventArgs e)
        {
            NeuerMitarbeiter NeuerMitarbeiter = new NeuerMitarbeiter();
            NeuerMitarbeiter.Show();
            Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Show();
            Hide();
        }
    }
}
