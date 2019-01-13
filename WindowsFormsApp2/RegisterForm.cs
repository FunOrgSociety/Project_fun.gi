using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = bazaizregistra.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);

          
            var sqlcmd = konekcija.CreateCommand();
            sqlcmd.CommandText = @"CREATE	TABLE IF NOT	EXISTS User(ime varchar(20),prezime varchar(20),username varchar(20),password varchar(20), email varchar(20))";

            sqlcmd.ExecuteNonQuery();

            sqlcmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

            sqlcmd.ExecuteNonQuery();


            // Dodati još ograničenja, za email, za ponavljanje username ...
            if (textBox2.Text == textBox3.Text)
            {
               
                sqlcmd.CommandText = "INSERT INTO User(ime,username,prezime,password,email) VALUES (@ime,@username,@prezime,@password,@email)";
                sqlcmd.Parameters.Clear();

                sqlcmd.Parameters.AddWithValue("@ime", textBox4.Text);
                sqlcmd.Parameters.AddWithValue("@username", textBox1.Text);
                sqlcmd.Parameters.AddWithValue("@prezime", textBox5.Text);
                sqlcmd.Parameters.AddWithValue("@email", textBox6.Text);
                sqlcmd.Parameters.AddWithValue("@password", textBox2.Text);
                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("You successfully registered. Have fun.", "Register");

                HomeForm home = new HomeForm();
                this.Hide();
                home.ShowDialog();
            }
            else {
                MessageBox.Show("Your password does not match", "Password error");
            }

            


            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
