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
    public partial class PretragaForm : Form
    {

        public List<GljivaClass> gljiva;

        public PretragaForm()
        {
            InitializeComponent();

            populateCombo();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            this.Hide();
            Home.ShowDialog();
        }

        public void populateCombo()
        {
            gljiva = GljivaClass.dohvati();
            comboBox1.DataSource = gljiva;
            comboBox2.DataSource = gljiva;
            comboBox3.DataSource = gljiva;
            comboBox1.DisplayMember = "Boja";
            comboBox2.DisplayMember = "Klobuk";
            comboBox3.DisplayMember = "Strucak";
        }
    }
}
