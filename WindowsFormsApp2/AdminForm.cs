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

            sqlcmd.CommandText = "INSERT INTO Gljiva(naziv , boja , mjesto , vrijeme , klobuk , strucak) VALUES (@naziv , @boja , @mjesto , @vrijeme , @klobuk , @strucak)";
            sqlcmd.Parameters.Clear();

            sqlcmd.Parameters.AddWithValue("@naziv", textBox1.Text);
            sqlcmd.Parameters.AddWithValue("@boja", textBox2.Text);
            sqlcmd.Parameters.AddWithValue("@mjesto", textBox3.Text);
            sqlcmd.Parameters.AddWithValue("@vrijeme", textBox4.Text);
            sqlcmd.Parameters.AddWithValue("@klobuk", textBox5.Text);
            sqlcmd.Parameters.AddWithValue("@strucak", textBox6.Text);
            sqlcmd.ExecuteNonQuery();

            /*
             popraviti sljedece:
                dodati bool otrovna(jestiva)
                urediti ennum(boja strucak...)
                Poraditi dizajn i sitnice             
             */

        }
    }
}
