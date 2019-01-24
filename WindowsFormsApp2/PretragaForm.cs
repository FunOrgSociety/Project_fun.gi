﻿using System;
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

            populateCombo1();
            populateCombo2();
            populateCombo3();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            this.Hide();
            Home.ShowDialog();
        }

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


    }
}
