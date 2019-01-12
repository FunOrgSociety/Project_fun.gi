using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsApp2
{
    class dbClass
    {
        private static string connectionString = "URI=file:database.db";

        internal static SQLiteConnection konekcija = new SQLiteConnection(connectionString);

        public static void otvoriKonekciju()
        {
            konekcija.Open();

            var cmd = konekcija.CreateCommand();


            cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	User(id integer,  ime varchar(20) , prezime varchar(20) , username varchar(20) , password varchar(20))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

            cmd.ExecuteNonQuery();

        }

        public static void zatvoriKonekciju()
        {
            konekcija.Close();
        }



    }
}
