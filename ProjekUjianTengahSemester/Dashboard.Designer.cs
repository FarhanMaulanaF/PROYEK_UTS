
namespace ProjekUjianTengahSemester
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeItems1 = new ProjekUjianTengahSemester.RemoveItems();
            this.updateItems1 = new ProjekUjianTengahSemester.UpdateItems();
            this.placeOrder1 = new ProjekUjianTengahSemester.UserControls.PlaceOrder();
            this.addItems1 = new ProjekUjianTengahSemester.UserControls.AddItems();
            this.welcome1 = new ProjekUjianTengahSemester.UserControls.Welcome();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.removeItems1);
            this.panel1.Controls.Add(this.updateItems1);
            this.panel1.Controls.Add(this.placeOrder1);
            this.panel1.Controls.Add(this.addItems1);
            this.panel1.Controls.Add(this.welcome1);
            this.panel1.Location = new System.Drawing.Point(226, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 514);
            this.panel1.TabIndex = 0;
            // 
            // removeItems1
            // 
            this.removeItems1.BackColor = System.Drawing.Color.White;
            this.removeItems1.Location = new System.Drawing.Point(1, 0);
            this.removeItems1.Name = "removeItems1";
            this.removeItems1.Size = new System.Drawing.Size(765, 514);
            this.removeItems1.TabIndex = 4;
            // 
            // updateItems1
            // 
            this.updateItems1.BackColor = System.Drawing.Color.White;
            this.updateItems1.Location = new System.Drawing.Point(0, 0);
            this.updateItems1.Name = "updateItems1";
            this.updateItems1.Size = new System.Drawing.Size(765, 514);
            this.updateItems1.TabIndex = 3;
            // 
            // placeOrder1
            // 
            this.placeOrder1.BackColor = System.Drawing.Color.White;
            this.placeOrder1.Location = new System.Drawing.Point(0, 0);
            this.placeOrder1.Name = "placeOrder1";
            this.placeOrder1.Size = new System.Drawing.Size(765, 514);
            this.placeOrder1.TabIndex = 2;
            // 
            // addItems1
            // 
            this.addItems1.BackColor = System.Drawing.Color.White;
            this.addItems1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItems1.Location = new System.Drawing.Point(-3, 0);
            this.addItems1.Name = "addItems1";
            this.addItems1.Size = new System.Drawing.Size(765, 514);
            this.addItems1.TabIndex = 1;
            // 
            // welcome1
            // 
            this.welcome1.BackColor = System.Drawing.Color.White;
            this.welcome1.Location = new System.Drawing.Point(3, 3);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(765, 514);
            this.welcome1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnRemoveItems);
            this.panel2.Controls.Add(this.btnUpdateItems);
            this.panel2.Controls.Add(this.btnAddItems);
            this.panel2.Controls.Add(this.btnPlaceOrder);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 514);
            this.panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveLinkColor = System.Drawing.Color.White;
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnLogOut.LinkColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(59, 480);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(81, 24);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.Gold;
            this.btnRemoveItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.Location = new System.Drawing.Point(10, 265);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(181, 41);
            this.btnRemoveItems.TabIndex = 3;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.Location = new System.Drawing.Point(10, 194);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(181, 41);
            this.btnUpdateItems.TabIndex = 2;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Gold;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItems.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Location = new System.Drawing.Point(10, 122);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(181, 41);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Gold;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(10, 49);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(181, 41);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private UserControls.Welcome welcome1;
        private UserControls.AddItems addItems1;
        private UserControls.PlaceOrder placeOrder1;
        private UpdateItems updateItems1;
        private RemoveItems removeItems1;
    }
}