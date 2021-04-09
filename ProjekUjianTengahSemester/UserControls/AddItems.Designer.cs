
namespace ProjekUjianTengahSemester.UserControls
{
    partial class AddItems
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
            this.AddNewItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddNewItem
            // 
            this.AddNewItem.AutoSize = true;
            this.AddNewItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItem.Location = new System.Drawing.Point(50, 205);
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.Size = new System.Drawing.Size(58, 24);
            this.AddNewItem.TabIndex = 0;
            this.AddNewItem.Text = "Price";
            this.AddNewItem.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            this.label1.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            this.label2.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add New Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(174, 276);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 39);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Cake",
            "Pastry",
            "Soft Drink",
            "Hot Beverage"});
            this.txtCategory.Location = new System.Drawing.Point(54, 100);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(349, 31);
            this.txtCategory.TabIndex = 5;
            this.txtCategory.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Location = new System.Drawing.Point(54, 235);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(349, 30);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemName.Location = new System.Drawing.Point(54, 168);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(349, 30);
            this.txtItemName.TabIndex = 7;
            this.txtItemName.Leave += new System.EventHandler(this.txtItemName_Leave);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddItems";
            this.Size = new System.Drawing.Size(765, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemName;
    }
}
