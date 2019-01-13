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
            string connectionString = "URI=file:database.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);

            konekcija.Open();
            var sqlcmd = konekcija.CreateCommand();

            
            // Dodati još ograničenja, za email, za ponavljanje username ...
            if (textBox2.Text == textBox3.Text)
            {
               
                sqlcmd.CommandText = "INSERT INTO User(@ime,username,prezime,password,email) VALUES (@ime,@username,@prezime,@password,@email)";
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
