using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekUjianTengahSemester.UserControls
{
    public partial class AddItems : UserControl
    {
        function fn = new function();
        String query;
        public AddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name, category, price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "', " + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
