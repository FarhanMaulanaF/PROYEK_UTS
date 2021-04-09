
namespace ProjekUjianTengahSemester.UserControls
{
    partial class PlaceOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnAddtoChart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveRed = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelHowRemove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // comboCategory
            // 
            this.comboCategory.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Cake",
            "Pastry",
            "Soft Drink",
            "Hot Beverage"});
            this.comboCategory.Location = new System.Drawing.Point(51, 107);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(143, 26);
            this.comboCategory.TabIndex = 2;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(51, 152);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(51, 192);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(143, 184);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(245, 140);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(201, 26);
            this.txtItemName.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(268, 32);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(201, 26);
            this.txtPrice.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(494, 197);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(201, 26);
            this.txtTotal.TabIndex = 13;
            // 
            // txtQuantityUpDown
            // 
            this.txtQuantityUpDown.Location = new System.Drawing.Point(245, 197);
            this.txtQuantityUpDown.Name = "txtQuantityUpDown";
            this.txtQuantityUpDown.Size = new System.Drawing.Size(201, 26);
            this.txtQuantityUpDown.TabIndex = 15;
            this.txtQuantityUpDown.ValueChanged += new System.EventHandler(this.txtQuantityUpDown_ValueChanged);
            // 
            // btnAddtoChart
            // 
            this.btnAddtoChart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddtoChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoChart.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoChart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoChart.Location = new System.Drawing.Point(56, 120);
            this.btnAddtoChart.Name = "btnAddtoChart";
            this.btnAddtoChart.Size = new System.Drawing.Size(123, 36);
            this.btnAddtoChart.TabIndex = 16;
            this.btnAddtoChart.Text = "Add to Chart";
            this.btnAddtoChart.UseVisualStyleBackColor = false;
            this.btnAddtoChart.Click += new System.EventHandler(this.btnAddtoChart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRemoveRed);
            this.panel1.Controls.Add(this.btnAddtoChart);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Location = new System.Drawing.Point(225, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 167);
            this.panel1.TabIndex = 17;
            // 
            // btnRemoveRed
            // 
            this.btnRemoveRed.BackColor = System.Drawing.Color.Red;
            this.btnRemoveRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveRed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRed.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRed.Location = new System.Drawing.Point(315, 120);
            this.btnRemoveRed.Name = "btnRemoveRed";
            this.btnRemoveRed.Size = new System.Drawing.Size(123, 36);
            this.btnRemoveRed.TabIndex = 20;
            this.btnRemoveRed.Text = "Remove";
            this.btnRemoveRed.UseVisualStyleBackColor = false;
            this.btnRemoveRed.Click += new System.EventHandler(this.btnRemoveRed_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(225, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(489, 193);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Grand Total";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTotalAmount.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(46, 423);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(159, 63);
            this.labelTotalAmount.TabIndex = 20;
            this.labelTotalAmount.Text = "Rp. 00";
            this.labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHowRemove
            // 
            this.labelHowRemove.AutoSize = true;
            this.labelHowRemove.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowRemove.Location = new System.Drawing.Point(59, 491);
            this.labelHowRemove.Name = "labelHowRemove";
            this.labelHowRemove.Size = new System.Drawing.Size(131, 18);
            this.labelHowRemove.TabIndex = 21;
            this.labelHowRemove.Text = "How to Remove ?";
            this.labelHowRemove.Click += new System.EventHandler(this.labelHowRemove_Click);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelHowRemove);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuantityUpDown);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrder";
            this.Size = new System.Drawing.Size(765, 514);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddtoChart;
        private System.Windows.Forms.NumericUpDown txtQuantityUpDown;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnRemoveRed;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelHowRemove;
    }
}
