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
    public partial class savijetibranjeForm : Form
    {
        public savijetibranjeForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SavjetiForm savjeti = new SavjetiForm();
            this.Hide();
            savjeti.ShowDialog();
        }
    }
}
