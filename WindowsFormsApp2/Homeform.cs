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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

        }



       

     

        private void kadaButton_Click(object sender, EventArgs e)
        {
            KadaForm kada = new KadaForm();
            this.Hide();
            kada.ShowDialog();
        }

        private void savjetButton_Click(object sender, EventArgs e)
        {
            SavjetiForm savjet = new SavjetiForm();
            this.Hide();
            savjet.ShowDialog();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            
        }

        private void pretragaButton_Click_1(object sender, EventArgs e)
        {
            PretragaForm pretraga = new PretragaForm();
            this.Hide();
            pretraga.ShowDialog();

        }
    }
}
