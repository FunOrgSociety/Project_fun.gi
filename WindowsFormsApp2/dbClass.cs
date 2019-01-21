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
        
        private static string connectionString = "Data Source = bazaizklase.db3";

        internal static SQLiteConnection con = new SQLiteConnection(connectionString);

        internal static void OtvoriKonekciju()
        {
            con.Open();
            SQLiteCommand com = con.CreateCommand();

            
            com.CommandText = @"CREATE	TABLE IF NOT EXISTS User(ime varchar(20),prezime varchar(20),username varchar(20),password varchar(20), email varchar(20))";

            com.ExecuteNonQuery(); //kreira tablicu user

            com.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

            com.ExecuteNonQuery(); //kreira tablicu gljiva

        }

        internal static void ZatvoriKonekciju()
        {
            con.Close();
        }


        //Nisam siguran ali mislim da je ova klasa višak



        /* private static string connectionString = "URI=file:databas.db3";

        internal static SQLiteConnection konekcija = new SQLiteConnection(connectionString);

        public static void otvoriKonekciju()
        {
            konekcija.Open();

            var cmd = konekcija.CreateCommand();

            //ne znam zasto ali nece mi kreirati bazu 
            cmd.CommandText = @"CREATE	TABLE User(ime varchar(20),prezime varchar(20),username varchar(20),password varchar(20), email varchar(20))";

            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Gljiva(id integer, naziv varchar (20), boja varchar(20), mjesto varchar(20),
                                        vrijeme varchar(20), jestiva boolean, opis varchar(200), klobuk varchar(30) , strucak varchar(30) ,
                                         pronadena boolean)";

            cmd.ExecuteNonQuery();
            }

            public static void zatvoriKonekciju()
         {
            konekcija.Close();

        }*/



    }
}
