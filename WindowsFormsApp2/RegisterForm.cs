﻿using System;
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
    public partial  class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        /*
            Postaviti enkripciju na password i Cconfirm passwod--rijeseno
            Provjeriti ako ceć postoji isti username u bazi------rijeseno
            Provjeriti ako postoji isti email ------rijeseno
            Dodatno: Postaviti da email bude donekle   vjerodostajan    rijeseno                  
             */



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
        }

        public bool IsValidEmail(string email) //kreiranje funkcije gdje email mora biti donekle validan, donekle je ključna riječ
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        

        public void usernameExist()
        {
           }




        private void button1_Click(object sender, EventArgs e)
        {
            bool usernamebool = false;
            bool emailbool = false;
            string connectionString = "Data Source = bazaizregistra.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);
            konekcija.Open();

            string sql = "SELECT * FROM User WHERE username='" + textBox1.Text + "'";
            string sql2 = "SELECT * FROM User WHERE email='" + textBox6.Text + "'";
            SQLiteCommand cmda = new SQLiteCommand(sql, konekcija);
            SQLiteCommand cmda2 = new SQLiteCommand(sql2, konekcija);


            cmda.Connection = konekcija;
            cmda2.Connection = konekcija;

            SQLiteDataReader rda = cmda.ExecuteReader();
            SQLiteDataReader rda2 = cmda2.ExecuteReader();

            if (rda.Read())
            {
                usernamebool = true;
            }

            if (rda2.Read())
            {
                emailbool = true;
            }

            if (usernamebool == false)
            {
                if (emailbool == false)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                        || textBox5.Text == "" || textBox6.Text == "")
                    {

                        MessageBox.Show("You have to fill in everything", "Fatal error"); // Svako polje mora biti popunjeno

                    }
                    else
                    {

                        var lista = new List<userClass>();
                        var sqlcmd = konekcija.CreateCommand();
                        sqlcmd.CommandText = @"CREATE	TABLE IF NOT	EXISTS User(ime varchar(20),prezime varchar(20),username varchar(20) UNIQUE,password varchar(20), email varchar(20))";

                        sqlcmd.ExecuteNonQuery(); // kreiranje tablica


                        sqlcmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

                        sqlcmd.ExecuteNonQuery();

 



                        // Dodati još ograničenja, za email, za ponavljanje username ...
                        if (textBox2.Text == textBox3.Text) // provjera dal je password i confirnm password isti
                        {
                            if (IsValidEmail(textBox6.Text) == true)
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
                            else
                            {
                                MessageBox.Show("Incorrect Emali", "Fatal ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your password does not match", "Password error");
                        }


                        konekcija.Close();

                    }
                    konekcija.Close();




                }
                else
                {
                    MessageBox.Show("Postoji mail ", "Fatal ERROR");
                }
            }
            else
            {
                MessageBox.Show("Postoji suername ", "Fatal ERROR");
            }
        

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
