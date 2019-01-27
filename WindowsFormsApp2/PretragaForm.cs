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
    public partial class PretragaForm : Form
    {

        public List<GljivaClass> gljiva;

       // bool boja = false;

        public PretragaForm()
        {
            InitializeComponent();

            populateCombo1();
            populateCombo2();
            populateCombo3();

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

                dt.Rows.Add(a.naziv, a.Boja, a.Mjesto_branja, a.Vrijeme_branja, a.Strucak, a.Klobuk);

            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            this.Hide();
            Home.ShowDialog();
        }
        public void populateCombo1()
        {
            comboBox1.Items.Add("Zuta");
            comboBox1.Items.Add("Zelena");
            comboBox1.Items.Add("Crna");
            comboBox1.Items.Add("Crvena");
            comboBox1.Items.Add("Narancasta");
            comboBox1.Items.Add("Smeda");
            comboBox1.Items.Add("Siva");
            comboBox1.Items.Add("Krem");
            comboBox1.Items.Add("Maslinasta");
        }

        public void populateCombo2()
        {
            comboBox2.Items.Add("Konveksan");
            comboBox2.Items.Add("Ravan");
            comboBox2.Items.Add("Odmaknut");
            comboBox2.Items.Add("Stozast");
            comboBox2.Items.Add("Pupcast");
            comboBox2.Items.Add("Polukuglast");
            comboBox2.Items.Add("Ljevkast");
            comboBox2.Items.Add("Zvonolik");
            comboBox2.Items.Add("Ulegnut");
            comboBox2.Items.Add("Jajast");
            comboBox2.Items.Add("Ispupcen");
        }

        public void populateCombo3()
        {
            comboBox3.Items.Add("Gol");
            comboBox3.Items.Add("Koprena");
            comboBox3.Items.Add("Obojak");
            comboBox3.Items.Add("Prstenak");
            comboBox3.Items.Add("Prstenak i Obojak");
            comboBox3.Items.Add("Bez Strucka");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pretragaff a = new Pretragaff();
            this.Hide();
            a.ShowDialog();
        }

        /*
        public void populateCombo1()
        {
            gljiva = GljivaClass.dohvati();
            comboBox1.DataSource = gljiva;
            comboBox1.DisplayMember = "Boja";
            

        }
        public void populateCombo2()
        {
            gljiva = GljivaClass.dohvati();
            comboBox2.DataSource = gljiva;
            comboBox2.DisplayMember = "Klobuk";
        }
        public void populateCombo3()
        {
            gljiva = GljivaClass.dohvati();
            comboBox3.DataSource = gljiva;
            comboBox3.DisplayMember = "Strucak";
        }

    */ // NAISAO SAM NA PROBLEM S OVIME JER SU MI SE POJAVLJIVALJE DUPLE VRJEDNOSTI PA SAM ODLUCIO RUCNO UNIJETI PARAMETRE, ALI VALJA PROVJERITI ZA MOGUCI UPGRADE KASNIJE
    }
}
