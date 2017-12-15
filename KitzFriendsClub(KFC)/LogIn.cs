using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KitzFriendsClub_KFC_
{
    public partial class LogIn : Form
    {
        public static MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; database = team10; username = team10; password = T3amO10");

        public LogIn()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
        }

        public static string benutzername;

        private void LogIn_Load(object sender, EventArgs e)
        {
            
            //con.Open();
            //MessageBox.Show("Erfolgreich verbunden");
            
            
        }

        private void rbGF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbMitarbeiter.Checked == true)
            {
                //New Connection + SQLCommand
                MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; database = team10; username = team10; password = T3amO10");
                MySqlCommand com = new MySqlCommand("SELECT COUNT(*) as cnt from Mitarbeiter where username = @usr and password = @pwd", con);
                com.Parameters.Clear();
                //Die eingegebenen Variablen werden als "username" und "password" verwendet.
                com.Parameters.AddWithValue("@usr", txt_username.Text);
                com.Parameters.AddWithValue("@pwd", txt_password.Text);
                con.Open();

                //MessageBox.Show(com.ExecuteScalar().ToString());
                //wenn es einen Dateieintrag gibt, bei dem "username" und "password" übereinstimmen wird weitergeleitet.
                if (com.ExecuteScalar().ToString()=="1")
                {
                    //MessageBox.Show("Passt!");
                    benutzername = txt_username.Text;
                    VerwaltungMitarbeiter VerwaltungMitarbeiter = new VerwaltungMitarbeiter();
                    VerwaltungMitarbeiter.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Nein");
                }
            }
            else if (rbCEO.Checked = true)
            {
                //New Connection + SQLCommand
                MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; database = team10; username = team10; password = T3amO10");
                MySqlCommand com = new MySqlCommand("SELECT COUNT(*) as cnt from CEO where username = @usr and password = @pwd", con);
                com.Parameters.Clear();
                //Die eingegebenen Variablen werden als "username" und "password" verwendet.
                com.Parameters.AddWithValue("@usr", txt_username.Text);
                com.Parameters.AddWithValue("@pwd", txt_password.Text);
                con.Open();

                //MessageBox.Show(com.ExecuteScalar().ToString());
                //wenn es einen Dateieintrag gibt, bei dem "username" und "password" übereinstimmen wird weitergeleitet.
                if (com.ExecuteScalar().ToString() == "1")
                {
                    //MessageBox.Show("Passt!");
                    VerwaltungCEO VerwaltungCEO = new VerwaltungCEO();
                    VerwaltungCEO.Show();
                    Hide();
                }
                else
                //wenn "password" oder/und "username" nicht stimmen, wird der Zugang verweigert und es wird eine Fehlermeldung ausgegeben.
                {
                    MessageBox.Show("Nein");
                }
            }
        }
    }
}
