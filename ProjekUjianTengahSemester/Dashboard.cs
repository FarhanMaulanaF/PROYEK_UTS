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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();
            }
            else if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addItems1.Visible = false;
            placeOrder1.Visible = false;
            updateItems1.Visible = false;
            removeItems1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            welcome1.SendToBack();
            placeOrder1.Visible = true;
            placeOrder1.BringToFront();

        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            updateItems1.Visible = true;
            updateItems1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            removeItems1.Visible = true;
            removeItems1.BringToFront();
        }
    }
}
