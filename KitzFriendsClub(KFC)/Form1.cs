using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitzFriendsClub_KFC_
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //    SqlConnection KFC = new SqlConnection();

        }

        private void rbGF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbMitarbeiter.Checked == true)
            {
                VerwaltungMitarbeiter VerwaltungMitarbeiter = new VerwaltungMitarbeiter();
                VerwaltungMitarbeiter.Show();
                Hide();
            }
            else if (rbCEO.Checked = true)
            {
                VerwaltungCEO Verwaltung_CEO = new VerwaltungCEO();
                Verwaltung_CEO.Show();
                Hide();
            }
        }
    }
}
