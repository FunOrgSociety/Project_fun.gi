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
            dbClass db = new dbClass();
            dbClass.OtvoriKonekciju();

            string connectionString = "Data Source = bazaizregistra.db3";
            SQLiteConnection konekcija = new SQLiteConnection(connectionString);
            konekcija.Open();

            // kreiranje komandi tj tablica i upita
            


        }
    }
}
