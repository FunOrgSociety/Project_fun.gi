using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class KadaForm : Form


    {
        public BindingSource bindingSource = new BindingSource();
        public List<GljivaClass> gljiva;
     //   private DataView dv;




        public KadaForm()
        {
            InitializeComponent();

            populatecombo1();
            populatecombo2();
            

            DataTable dt = new DataTable();

            dt.Columns.Add("Naziv");
           // dt.Columns.Add("Boja");
            dt.Columns.Add("Mjesto branja");
            dt.Columns.Add("Vrijeme");
            //dt.Columns.Add("Strucak");
            //dt.Columns.Add("Klobuk");

            gljiva = GljivaClass.dohvati();

            foreach (var a in gljiva)
            {
                var row = dt.NewRow();

                row["Naziv"] = Convert.ToString(a.naziv);
              //  row["Boja"] = Convert.ToString(a.Boja);
                row["Mjesto branja"] = Convert.ToString(a.Mjesto_branja);
                row["Vrijeme"] = Convert.ToString(a.Vrijeme_branja);
               // row["Strucak"] = Convert.ToString(a.Strucak);
              //  row["Klobuk"] = Convert.ToString(a.Klobuk);

                dt.Rows.Add(a.naziv, a.Mjesto_branja, a.Vrijeme_branja);
                
            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            this.Hide();
            Home.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void KadaForm_Load(object sender, EventArgs e)
        {

        }
        public void populatecombo1()
        {
            comboBox1.Items.Add("Crnogoricna Suma");
            comboBox1.Items.Add("Bjelogoricna Suma");
            comboBox1.Items.Add("Sve sume");
            comboBox1.Items.Add("Livada");
        }

        public void populatecombo2()
        {
            comboBox2.Items.Add("Zima");
            comboBox2.Items.Add("Ljeto");
            comboBox2.Items.Add("Jesen");
            comboBox2.Items.Add("Proljeće");
            comboBox2.Items.Add("Cijela Godina");
            
        }


        /*public void populatecombo1()
        {
            gljiva = GljivaClass.dohvati();
            comboBox1.DataSource = gljiva;
            comboBox1.DisplayMember = "Mjesto_branja";

        }

        public void populatecombo2()
        {
            gljiva = GljivaClass.dohvati();
            comboBox2.DataSource = gljiva;
            comboBox2.DisplayMember = "Vrijeme_branja";

        }
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
