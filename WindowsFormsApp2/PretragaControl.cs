using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PretragaControl : UserControl
    {

        public List<GljivaClass> gljiva;

        public PretragaControl()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            dt.Columns.Add("Naziv");
            dt.Columns.Add("Boja");
            dt.Columns.Add("Mjesto branja");
            dt.Columns.Add("Vrijeme");
            dt.Columns.Add("Strucak");
            dt.Columns.Add("Klobuk");

            gljiva = GljivaClass.dohvati();

            foreach (var a in gljiva)
            {
                var row = dt.NewRow();

                row["Naziv"] = Convert.ToString(a.naziv);
                row["Boja"] = Convert.ToString(a.Boja);
                row["Mjesto branja"] = Convert.ToString(a.Mjesto_branja);
                row["Vrijeme"] = Convert.ToString(a.Vrijeme_branja);
                row["Strucak"] = Convert.ToString(a.Strucak);
                row["Klobuk"] = Convert.ToString(a.Klobuk);

                dt.Rows.Add(a.naziv, a.Mjesto_branja, a.Vrijeme_branja);

            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
