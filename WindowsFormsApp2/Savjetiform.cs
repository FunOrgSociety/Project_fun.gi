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
    public partial class SavjetiForm : Form
    {
        public SavjetiForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            this.Hide();
            Home.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dijelovigljivaForm dio = new dijelovigljivaForm();
            dio.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            savijetibranjeForm branje = new savijetibranjeForm();
            branje.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            savijeticiscenjeForm cisc = new savijeticiscenjeForm();
            cisc.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            savijetipripremaForm prip = new savijetipripremaForm();
            prip.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dijelovigljivaForm dio = new dijelovigljivaForm();
            dio.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
