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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void UserBox_Enter(object sender, EventArgs e)
        {
            if (UserBox.Text == "Username")
            {
                UserBox.Text = "";
                UserBox.ForeColor = Color.Black;
            }
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            if (UserBox.Text == "")
            {
                UserBox.Text = "Username";
                UserBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.PasswordChar = '*';
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Password";
                PasswordBox.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                AdminForm admin = new AdminForm();
                this.Hide();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please register with admin", "Fatal error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeForm Home = new HomeForm();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
