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

namespace Szukanuget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Kiir()
        {
            Select_ListBox.Items.Clear();
            using (var conn = new MySqlConnection(
             "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var command = conn.CreateCommand();


                var osszes = conn.CreateCommand();
                osszes.CommandText = "select * from felhasznalo";

                var olvas = osszes.ExecuteReader();

                while (olvas.Read())
                {

                    Select_ListBox.Items.Add(olvas["id"].ToString() + " " + olvas["nev"].ToString() + " " + olvas["regdatun"].ToString());

                }


                Select_ListBox.SelectedIndex = 0;














            }
        }
        private void Kuld_Button_Click  (object sender, EventArgs e) 
              {
            string nev=Nev_TextBox.Text;
            string jelszo=Jelszo_TextBox.Text;
            DateTime szuldat=Ev_DateTimePicker.Value;
            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev";

                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab =(long)ellenorzes.ExecuteScalar();
                if (darab!=0)
                {
                    MessageBox.Show("A usernev mar letezik");
                    return;
                }

                command.CommandText = "INSERT INTO felhasznalo (nev,jelszo,regdatun) values (@nev,@jelszo,@regdatum)";
                command.Parameters.AddWithValue("@nev",nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", szuldat);
                int erintett_sorok_szama=command.ExecuteNonQuery();













            }
              }

        private void Login_Click(object sender, EventArgs e)
        {
            Select_ListBox.Items.Clear();
            string nev = Nev_TextBox.Text;
            string jelszo = Jelszo_TextBox.Text;
            DateTime szuldat = Ev_DateTimePicker.Value;
            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev and jelszo=@jelszo";

                ellenorzes.Parameters.AddWithValue("@jelszo", jelszo);
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab == 0)
                {
                    MessageBox.Show("Rossz user nevet vagy jelszót adtál meg");
                    return;
                }

                Kiir();

                Login_Button.Hide();
                Kuld_Button.Hide();
                Delete_Button.Show();
                Logout_Button.Show();
                Select_ListBox.Show();
                Update_Button.Show();
                Select_ListBox.SelectedIndex = 0;


                 











            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string sor = Select_ListBox.Text;
            string[] adatok = sor.Split(' ');
            int id = int.Parse(adatok[0]);
            using (var conn = new MySqlConnection(
            "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var command = conn.CreateCommand();
                command.CommandText = "Delete from felhasznalo where id=@id";
                command.Parameters.AddWithValue("@id",id);

                int torolt = command.ExecuteNonQuery();

            }
            Kiir();


        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Button.Show();
            Kuld_Button.Show();
            Delete_Button.Hide();
            Logout_Button.Hide();
            Select_ListBox.Hide();
            Update_Button.Hide();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            string nev = Nev_TextBox.Text;
            string jelszo = Jelszo_TextBox.Text;
            DateTime szuldat = Ev_DateTimePicker.Value;
            string sor = Select_ListBox.Text;
            string[] adatok = sor.Split(' ');
            int id = int.Parse(adatok[0]);
            using (var conn = new MySqlConnection(
                "Server=localhost;Database=regisztracio;Uid=root;Password=;"))
            {
                conn.Open();

                var ellenorzes = conn.CreateCommand();
                var command = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) from felhasznalo where nev= @nev and id!=@id";

                ellenorzes.Parameters.AddWithValue("@nev", nev);
                ellenorzes.Parameters.AddWithValue("@id", id);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("A usernev mar letezik");
                    return;
                }

                command.CommandText = "UPDATE felhasznalo set nev=@nev,jelszo=@jelszo,regdatun=@regdatum where id=@id";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", szuldat);
                
                command.Parameters.AddWithValue("@id", id);
                int erintett_sorok_szama = command.ExecuteNonQuery();


                Kiir();








            }
        }
    }
}
