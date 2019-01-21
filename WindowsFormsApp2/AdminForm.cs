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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            //otvaranje baze
            string connectionString = "Data Source = bazaizregistra.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);
            konekcija.Open();

            // kreiranje komandi tj tablica i upita
            var sqlcmd = konekcija.CreateCommand();
            sqlcmd.CommandText = @"CREATE	TABLE IF NOT	EXISTS User(ime varchar(20),prezime varchar(20),username varchar(20),password varchar(20), email varchar(20))";

            sqlcmd.ExecuteNonQuery();

            sqlcmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

            sqlcmd.ExecuteNonQuery();

            sqlcmd.CommandText = "INSERT INTO Gljiva(naziv , boja , mjesto , vrijeme , klobuk , strucak , opis , jestiva) " +
                                               "VALUES (@naziv , @boja , @mjesto , @vrijeme , @klobuk , @strucak , @opis , @jestiva)";

            sqlcmd.Parameters.Clear();

            sqlcmd.Parameters.AddWithValue("@naziv", textBox1.Text);
            sqlcmd.Parameters.AddWithValue("@boja", comboBox2.Text);
            sqlcmd.Parameters.AddWithValue("@mjesto", comboBox3.Text);
            sqlcmd.Parameters.AddWithValue("@vrijeme", comboBox4.Text);
            sqlcmd.Parameters.AddWithValue("@klobuk", comboBox5.Text);
            sqlcmd.Parameters.AddWithValue("@strucak", comboBox6.Text);
            sqlcmd.Parameters.AddWithValue("@opis", richTextBox1.Text);
            sqlcmd.Parameters.AddWithValue("@jestiva", comboBox1.Text);
            sqlcmd.ExecuteNonQuery();


            MessageBox.Show("Gljiva dodana. Have fun.", "Fun.gi");
            /*
             popraviti sljedece:
                dodati bool otrovna(jestiva)
                Poraditi dizajn i sitnice             
             */

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "neobavezno")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "neobavezno";
                richTextBox1.ForeColor = Color.Gray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
