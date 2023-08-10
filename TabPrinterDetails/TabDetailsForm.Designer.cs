namespace TabPrinterDetails
{
    partial class TabDetailsForm
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
            TreeNode treeNode1 = new TreeNode("New User");
            TreeNode treeNode2 = new TreeNode("Tab & Printers", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Tab & Printers Repairing");
            TreeNode treeNode4 = new TreeNode("Finished Repairing");
            TreeNode treeNode5 = new TreeNode("Repairing", new TreeNode[] { treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("Add New Items");
            TreeNode treeNode7 = new TreeNode("Add Items", new TreeNode[] { treeNode6 });
            TreeNode treeNode8 = new TreeNode("Return Items ");
            TreeNode treeNode9 = new TreeNode("Return ", new TreeNode[] { treeNode8 });
            TreeNode treeNode10 = new TreeNode("Tab & Printers Deductions");
            TreeNode treeNode11 = new TreeNode("Deductions", new TreeNode[] { treeNode10 });
            TreeNode treeNode12 = new TreeNode("Item Reports");
            TreeNode treeNode13 = new TreeNode("User Reports");
            TreeNode treeNode14 = new TreeNode("Repairing Reports");
            TreeNode treeNode15 = new TreeNode("Tab Deductions");
            TreeNode treeNode16 = new TreeNode("Printers Deductions");
            TreeNode treeNode17 = new TreeNode("Reports", new TreeNode[] { treeNode12, treeNode13, treeNode14, treeNode15, treeNode16 });
            treeView1 = new TreeView();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.AccessibleRole = AccessibleRole.MenuBar;
            treeView1.AllowDrop = true;
            treeView1.BackColor = Color.White;
            treeView1.Cursor = Cursors.Hand;
            treeView1.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            treeView1.LineColor = Color.DimGray;
            treeView1.Location = new Point(1, 57);
            treeView1.Name = "treeView1";
            treeNode1.Name = "newUser";
            treeNode1.Text = "New User";
            treeNode2.BackColor = Color.White;
            treeNode2.ForeColor = Color.Black;
            treeNode2.Name = "t&pDetails";
            treeNode2.Text = "Tab & Printers";
            treeNode3.Name = "t&pRepairing";
            treeNode3.Text = "Tab & Printers Repairing";
            treeNode4.Name = "FinishedRepairing";
            treeNode4.Text = "Finished Repairing";
            treeNode5.Name = "Repairing";
            treeNode5.Text = "Repairing";
            treeNode6.Name = "Add";
            treeNode6.Text = "Add New Items";
            treeNode7.Name = "ItemsAdd";
            treeNode7.Text = "Add Items";
            treeNode8.Name = "ReturnItems ";
            treeNode8.Text = "Return Items ";
            treeNode9.Name = "Return";
            treeNode9.Text = "Return ";
            treeNode10.ForeColor = Color.Black;
            treeNode10.Name = "T&PDeductions";
            treeNode10.Text = "Tab & Printers Deductions";
            treeNode11.Name = "Deduction";
            treeNode11.Text = "Deductions";
            treeNode12.Name = "ItemReports";
            treeNode12.Text = "Item Reports";
            treeNode13.Name = "UserReports";
            treeNode13.Text = "User Reports";
            treeNode14.Name = "RepairingReports";
            treeNode14.Text = "Repairing Reports";
            treeNode15.Name = "TabDeductions";
            treeNode15.Text = "Tab Deductions";
            treeNode16.Name = "PrintersDeductions";
            treeNode16.Text = "Printers Deductions";
            treeNode17.Name = "Report";
            treeNode17.Text = "Reports";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode5, treeNode7, treeNode9, treeNode11, treeNode17 });
            treeView1.ShowNodeToolTips = true;
            treeView1.Size = new Size(235, 282);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Enabled = false;
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1673, 57);
            panel1.TabIndex = 0;
            // 
            // TabDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 824);
            Controls.Add(treeView1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "TabDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabDetailsForm";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TreeView treeView1;
    }
}