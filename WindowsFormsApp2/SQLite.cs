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
        public SQLiteConnection baza;

        public dbClass() {

            baza = new SQLiteConnection("Data Source = database.sqlite3");
            if (!File.Exists("*./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");


            }

        }


    }
}
