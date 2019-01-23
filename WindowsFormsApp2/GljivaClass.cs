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




    }
}
