namespace TabPrinterDetails
{
    partial class TPRepairing
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
            panel1 = new Panel();
            cmbBrand = new ComboBox();
            cmbLocation = new ComboBox();
            btnClose = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            dgv1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            cmbDistributor = new ComboBox();
            cmbAsm = new ComboBox();
            cmbPosition = new ComboBox();
            txtRemark = new TextBox();
            txtSeriel = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtEmpNo = new TextBox();
            txtSrid = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label14 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbBrand);
            panel1.Controls.Add(cmbLocation);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dgv1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cmbDistributor);
            panel1.Controls.Add(cmbAsm);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(txtRemark);
            panel1.Controls.Add(txtSeriel);
            panel1.Controls.Add(txtLName);
            panel1.Controls.Add(txtFName);
            panel1.Controls.Add(txtEmpNo);
            panel1.Controls.Add(txtSrid);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 590);
            panel1.TabIndex = 0;
            // 
            // cmbBrand
            // 
            cmbBrand.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(652, 86);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(194, 26);
            cmbBrand.TabIndex = 33;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // cmbLocation
            // 
            cmbLocation.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(652, 137);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(194, 26);
            cmbLocation.TabIndex = 32;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(28, 373);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 32);
            btnClose.TabIndex = 31;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(492, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 32);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(620, 373);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 32);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(744, 373);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 28;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(28, 421);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(818, 131);
            dgv1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 22);
            dateTimePicker1.TabIndex = 26;
            // 
            // cmbDistributor
            // 
            cmbDistributor.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDistributor.FormattingEnabled = true;
            cmbDistributor.Location = new Point(652, 186);
            cmbDistributor.Name = "cmbDistributor";
            cmbDistributor.Size = new Size(194, 26);
            cmbDistributor.TabIndex = 25;
            // 
            // cmbAsm
            // 
            cmbAsm.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAsm.FormattingEnabled = true;
            cmbAsm.Location = new Point(368, 188);
            cmbAsm.Name = "cmbAsm";
            cmbAsm.Size = new Size(139, 26);
            cmbAsm.TabIndex = 24;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(368, 132);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(139, 26);
            cmbPosition.TabIndex = 23;
            cmbPosition.SelectedIndexChanged += cmbPosition_SelectedIndexChanged;
            // 
            // txtRemark
            // 
            txtRemark.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemark.Location = new Point(111, 241);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(735, 99);
            txtRemark.TabIndex = 21;
            // 
            // txtSeriel
            // 
            txtSeriel.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeriel.Location = new Point(111, 132);
            txtSeriel.Multiline = true;
            txtSeriel.Name = "txtSeriel";
            txtSeriel.Size = new Size(139, 23);
            txtSeriel.TabIndex = 19;
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLName.Location = new Point(368, 86);
            txtLName.Multiline = true;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(139, 23);
            txtLName.TabIndex = 17;
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFName.Location = new Point(111, 86);
            txtFName.Multiline = true;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(139, 23);
            txtFName.TabIndex = 16;
            // 
            // txtEmpNo
            // 
            txtEmpNo.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpNo.Location = new Point(368, 33);
            txtEmpNo.Multiline = true;
            txtEmpNo.Name = "txtEmpNo";
            txtEmpNo.Size = new Size(60, 23);
            txtEmpNo.TabIndex = 15;
            // 
            // txtSrid
            // 
            txtSrid.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSrid.Location = new Point(111, 33);
            txtSrid.Multiline = true;
            txtSrid.Name = "txtSrid";
            txtSrid.Size = new Size(60, 23);
            txtSrid.TabIndex = 14;
            txtSrid.WordWrap = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(291, 38);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 12;
            label13.Text = "EMP No";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(548, 140);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 11;
            label12.Text = "Location";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(291, 191);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 10;
            label11.Text = "ASM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(291, 140);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 9;
            label10.Text = "Position";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(548, 91);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 8;
            label9.Text = "Brand";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(291, 91);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 7;
            label8.Text = "Last Name";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(28, 38);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 6;
            label7.Text = "SRID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(28, 241);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 5;
            label14.Text = "Remarks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(548, 191);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Distributor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(28, 191);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 140);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Seriel No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // TPRepairing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 593);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            MaximizeBox = false;
            Name = "TPRepairing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tab & Printers Details Add";
            WindowState = FormWindowState.Maximized;
            Load += TPRepairing_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox5;
        private TextBox txtSeriel;
        private TextBox textBox3;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtEmpNo;
        private TextBox txtSrid;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnClose;
        private Button btnClear;
        private Button btnEdit;
        private Button btnSave;
        private DataGridView dgv1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbDistributor;
        private ComboBox cmbAsm;
        private ComboBox cmbPosition;
        private TextBox txtRemark;
        private Label label14;
        private ComboBox cmbBrand;
        private ComboBox cmbLocation;
    }
}