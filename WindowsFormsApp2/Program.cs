using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            string connectionString = "Data Source = bazaizregistra.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);
            konekcija.Open();

            var lista = new List<userClass>();
            var sqlcmd = konekcija.CreateCommand();
            sqlcmd.CommandText = @"CREATE	TABLE IF NOT	EXISTS User(ime varchar(20),prezime varchar(20),username varchar(20) UNIQUE,password varchar(20), email varchar(20))";

            sqlcmd.ExecuteNonQuery(); // kreiranje tablica


            sqlcmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

            sqlcmd.ExecuteNonQuery();

            sqlcmd.CommandText = "INSERT INTO User(ime,username,prezime,password,email) VALUES (@ime,@username,@prezime,@password,@email)";
            sqlcmd.ExecuteNonQuery();

        }
    }
}
