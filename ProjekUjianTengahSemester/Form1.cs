using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekUjianTengahSemester
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            //Username dan Password untuk Login bisa diganti yang lain
            if (txtUsername.Text == "farhan" && txtPassword.Text == "460544")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
        }
    }
}
