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
    public partial class RemoveItems : UserControl
    {
        function fn = new function();
        String query;

        public RemoveItems()
        {
            InitializeComponent();
        }

        private void RemoveItems_Load(object sender, EventArgs e)
        {
            RmvLabel.Text = "How to DELETE ?";
            RmvLabel.ForeColor = Color.Red;
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '"+txtSearch.Text+"%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete items ?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where iid ="+id+"";
                fn.setData(query);
                loadData();
            }
        }

        private void RmvLabel_Click(object sender, EventArgs e)
        {
            RmvLabel.ForeColor = Color.Red;
            RmvLabel.Text = "Click on Row to Delete the Item.";
        }

        private void RemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
