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
    public partial class PlaceOrder : UserControl
    {
        function fn = new function();
        String query;

        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select name from items where category = '"+category+"'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "' and name like '"+txtSearch.Text+"%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            String text = listBox.GetItemText(listBox.SelectedItem);
            txtItemName.Text = text;
            query = "select price from items where name = '"+text+"'";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        //Untuk mengubah harga berdasaekan kuantitas
        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;

        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemoveRed_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelTotalAmount.Text = "Rp. " + total;
        }

        private void labelHowRemove_Click(object sender, EventArgs e)
        {
            labelHowRemove.ForeColor = Color.Red;
            labelHowRemove.Text = "Click One Full Row to Remove Properly.";
        }

        private void btnAddtoChart_Click(object sender, EventArgs e)
        {
            //Agar tidak bisa menambahkan item 0 ke dalam chart maka dibuat seperti ini
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Rp. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
