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
    public partial class NeuesKind : Form
    {
        public NeuesKind()
        {
            InitializeComponent();
        }

        private void btn_anlegen_Click(object sender, EventArgs e)
        {

        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            VerwaltungMitarbeiter VerwaltungMitarbeiter = new VerwaltungMitarbeiter();
            VerwaltungMitarbeiter.Show();
            Hide();
        }

        private void pb_kind_Click(object sender, EventArgs e)
        {

        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg;*.png)|*.jpg;*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                pb_kind.Image = Image.FromFile(file);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Show();
            Hide();
        }
    }
}
