using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace WindowsFormsApp2
{
     public class GljivaClass
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public bool jestiva { get; set; }
        public string opis { get; set; }
        public bool pronadena { get; set; }
        public string Boja { get; set; }
        public string Vrijeme_branja { get; set; }
        public string Mjesto_branja { get; set; }
        public string Klobuk { get; set; }
        public string Strucak { get; set; }


        public static List<GljivaClass> dohvati()
        {
            dbClass.OtvoriKonekciju();

            var podaci = new List<GljivaClass>();

            SQLiteCommand c = dbClass.con.CreateCommand();
            c.CommandText = String.Format(@"SELECT * FROM Gljiva");
            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                GljivaClass a = new GljivaClass();
                a.naziv = (string)Convert.ToString(reader["naziv"]);
                a.Boja = (string)Convert.ToString(reader["boja"]);
                a.Mjesto_branja = (string)Convert.ToString(reader["mjesto"]);
                a.Vrijeme_branja = (string)Convert.ToString(reader["vrijeme"]);
                a.Klobuk = (string)Convert.ToString(reader["klobuk"]);
                a.Strucak = (string)Convert.ToString(reader["strucak"]);

                podaci.Add(a);

            }

            c.Dispose();

            dbClass.ZatvoriKonekciju();
      
            return podaci;
        }

        public void dodaj(string naziv,string Boja,string Mjesto_branja, string Vrijeme_branja, string Klobuk,string Strucak, string opis,bool jestiva) {

            string connectionString = "Data Source = bazaizregistra.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);
            konekcija.Open();

            // kreiranje komandi tj tablica i upita
            var sqlcmd = konekcija.CreateCommand();

            sqlcmd.CommandText = "INSERT INTO Gljiva(naziv , boja , mjesto , vrijeme , klobuk , strucak , opis , jestiva) " +
                                               "VALUES (@naziv , @boja , @mjesto , @vrijeme , @klobuk , @strucak , @opis , @jestiva)";

            sqlcmd.Parameters.Clear();

            sqlcmd.Parameters.AddWithValue("@naziv", naziv);
            sqlcmd.Parameters.AddWithValue("@boja", Boja);
            sqlcmd.Parameters.AddWithValue("@mjesto",Mjesto_branja);
            sqlcmd.Parameters.AddWithValue("@vrijeme", Vrijeme_branja);
            sqlcmd.Parameters.AddWithValue("@klobuk", Klobuk);
            sqlcmd.Parameters.AddWithValue("@strucak", Strucak);
            sqlcmd.Parameters.AddWithValue("@opis", opis);
            sqlcmd.Parameters.AddWithValue("@jestiva", jestiva);
            sqlcmd.ExecuteNonQuery();
            konekcija.Close();



        }



    }
}
