namespace TabPrinterDetails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            ASM = new Label();
            Remark = new Label();
            SerialNo = new Label();
            Location = new Label();
            Position = new Label();
            Categories = new Label();
            Brand = new Label();
            LastName = new Label();
            FirstName = new Label();
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            brandCombo = new ComboBox();
            categoriesCombo = new ComboBox();
            positionCombo = new ComboBox();
            locationCombo = new ComboBox();
            serielCombo = new ComboBox();
            remarkTxt = new TextBox();
            SaveBtn = new Button();
            clearBtn = new Button();
            closeBtn = new Button();
            date = new DateTimePicker();
            Column = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            distributorCombo = new ComboBox();
            ASMCombo = new ComboBox();
            repIDTxt = new TextBox();
            empTxt = new TextBox();
            EmpNo = new Label();
            RepID = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(distributorCombo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ASMCombo);
            panel1.Controls.Add(ASM);
            panel1.Controls.Add(date);
            panel1.Controls.Add(Remark);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(SerialNo);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(Location);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(Position);
            panel1.Controls.Add(remarkTxt);
            panel1.Controls.Add(Categories);
            panel1.Controls.Add(serielCombo);
            panel1.Controls.Add(Brand);
            panel1.Controls.Add(locationCombo);
            panel1.Controls.Add(LastName);
            panel1.Controls.Add(positionCombo);
            panel1.Controls.Add(EmpNo);
            panel1.Controls.Add(categoriesCombo);
            panel1.Controls.Add(FirstName);
            panel1.Controls.Add(brandCombo);
            panel1.Controls.Add(RepID);
            panel1.Controls.Add(lastNameTxt);
            panel1.Controls.Add(empTxt);
            panel1.Controls.Add(firstNameTxt);
            panel1.Controls.Add(repIDTxt);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 570);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(392, 161);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 43;
            label1.Text = "EMP ";
            // 
            // ASM
            // 
            ASM.AutoSize = true;
            ASM.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ASM.Location = new Point(392, 257);
            ASM.Name = "ASM";
            ASM.Size = new Size(36, 23);
            ASM.TabIndex = 42;
            ASM.Text = "ASM";
            // 
            // Remark
            // 
            Remark.AutoSize = true;
            Remark.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Remark.Location = new Point(47, 388);
            Remark.Name = "Remark";
            Remark.Size = new Size(54, 23);
            Remark.TabIndex = 40;
            Remark.Text = "Remark";
            // 
            // SerialNo
            // 
            SerialNo.AutoSize = true;
            SerialNo.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SerialNo.Location = new Point(392, 117);
            SerialNo.Name = "SerialNo";
            SerialNo.Size = new Size(91, 23);
            SerialNo.TabIndex = 39;
            SerialNo.Text = "Serial Number";
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Location.Location = new Point(392, 308);
            Location.Name = "Location";
            Location.Size = new Size(59, 23);
            Location.TabIndex = 38;
            Location.Text = "Location";
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Position.Location = new Point(47, 308);
            Position.Name = "Position";
            Position.Size = new Size(56, 23);
            Position.TabIndex = 37;
            Position.Text = "Position";
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Categories.Location = new Point(47, 255);
            Categories.Name = "Categories";
            Categories.Size = new Size(72, 23);
            Categories.TabIndex = 36;
            Categories.Text = "Categories";
            // 
            // Brand
            // 
            Brand.AutoSize = true;
            Brand.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Brand.Location = new Point(47, 209);
            Brand.Name = "Brand";
            Brand.Size = new Size(44, 23);
            Brand.TabIndex = 35;
            Brand.Text = "Brand";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LastName.Location = new Point(47, 161);
            LastName.Name = "LastName";
            LastName.Size = new Size(71, 23);
            LastName.TabIndex = 34;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FirstName.Location = new Point(46, 115);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(72, 23);
            FirstName.TabIndex = 32;
            FirstName.Text = "First Name";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(152, 117);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(202, 23);
            firstNameTxt.TabIndex = 12;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(152, 161);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(202, 23);
            lastNameTxt.TabIndex = 13;
            // 
            // brandCombo
            // 
            brandCombo.FormattingEnabled = true;
            brandCombo.Location = new Point(152, 209);
            brandCombo.Name = "brandCombo";
            brandCombo.Size = new Size(193, 23);
            brandCombo.TabIndex = 15;
            brandCombo.SelectedIndexChanged += brandCombo_SelectedIndexChanged;
            // 
            // categoriesCombo
            // 
            categoriesCombo.FormattingEnabled = true;
            categoriesCombo.Location = new Point(152, 257);
            categoriesCombo.Name = "categoriesCombo";
            categoriesCombo.Size = new Size(193, 23);
            categoriesCombo.TabIndex = 16;
            categoriesCombo.SelectedIndexChanged += categoriesCombo_SelectedIndexChanged;
            // 
            // positionCombo
            // 
            positionCombo.FormattingEnabled = true;
            positionCombo.Location = new Point(152, 308);
            positionCombo.Name = "positionCombo";
            positionCombo.Size = new Size(193, 23);
            positionCombo.TabIndex = 17;
            positionCombo.SelectedIndexChanged += positionCombo_SelectedIndexChanged;
            // 
            // locationCombo
            // 
            locationCombo.FormattingEnabled = true;
            locationCombo.Location = new Point(488, 310);
            locationCombo.Name = "locationCombo";
            locationCombo.Size = new Size(193, 23);
            locationCombo.TabIndex = 18;
            // 
            // serielCombo
            // 
            serielCombo.FormattingEnabled = true;
            serielCombo.Location = new Point(488, 117);
            serielCombo.Name = "serielCombo";
            serielCombo.Size = new Size(208, 23);
            serielCombo.TabIndex = 19;
            serielCombo.SelectedIndexChanged += serielCombo_SelectedIndexChanged;
            // 
            // remarkTxt
            // 
            remarkTxt.Location = new Point(152, 359);
            remarkTxt.Multiline = true;
            remarkTxt.Name = "remarkTxt";
            remarkTxt.Size = new Size(598, 91);
            remarkTxt.TabIndex = 20;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.Highlight;
            SaveBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = SystemColors.ButtonFace;
            SaveBtn.Location = new Point(675, 507);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 31);
            SaveBtn.TabIndex = 21;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.Highlight;
            clearBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = SystemColors.ButtonFace;
            clearBtn.Location = new Point(563, 507);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 31);
            clearBtn.TabIndex = 22;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.Highlight;
            closeBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.ForeColor = SystemColors.ButtonFace;
            closeBtn.Location = new Point(152, 507);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 31);
            closeBtn.TabIndex = 23;
            closeBtn.Text = "CLOSE";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // date
            // 
            date.Location = new Point(488, 209);
            date.Name = "date";
            date.Size = new Size(209, 23);
            date.TabIndex = 25;
            // 
            // Column
            // 
            Column.HeaderText = "Rep ID";
            Column.Name = "Column";
            // 
            // Column2
            // 
            Column2.HeaderText = "First Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Last Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Emp No";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Brand";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Categories";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Position";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Location";
            Column8.Name = "Column8";
            // 
            // distributorCombo
            // 
            distributorCombo.FormattingEnabled = true;
            distributorCombo.Location = new Point(488, 163);
            distributorCombo.Name = "distributorCombo";
            distributorCombo.Size = new Size(262, 23);
            distributorCombo.TabIndex = 31;
            // 
            // ASMCombo
            // 
            ASMCombo.FormattingEnabled = true;
            ASMCombo.Location = new Point(488, 257);
            ASMCombo.Name = "ASMCombo";
            ASMCombo.Size = new Size(193, 23);
            ASMCombo.TabIndex = 29;
            // 
            // repIDTxt
            // 
            repIDTxt.Location = new Point(152, 55);
            repIDTxt.Name = "repIDTxt";
            repIDTxt.Size = new Size(73, 23);
            repIDTxt.TabIndex = 11;
            // 
            // empTxt
            // 
            empTxt.Location = new Point(488, 55);
            empTxt.Name = "empTxt";
            empTxt.Size = new Size(73, 23);
            empTxt.TabIndex = 14;
            // 
            // EmpNo
            // 
            EmpNo.AutoSize = true;
            EmpNo.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EmpNo.Location = new Point(392, 55);
            EmpNo.Name = "EmpNo";
            EmpNo.Size = new Size(54, 23);
            EmpNo.TabIndex = 33;
            EmpNo.Text = "Emp No";
            // 
            // RepID
            // 
            RepID.AutoSize = true;
            RepID.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RepID.Location = new Point(47, 55);
            RepID.Name = "RepID";
            RepID.Size = new Size(47, 23);
            RepID.TabIndex = 31;
            RepID.Text = "Rep ID";
            RepID.Click += RepID_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 572);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private ComboBox brandCombo;
        private ComboBox categoriesCombo;
        private ComboBox positionCombo;
        private ComboBox locationCombo;
        private ComboBox serielCombo;
        private TextBox remarkTxt;
        private Button SaveBtn;
        private Button clearBtn;
        private Button closeBtn;
        private DateTimePicker date;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox distributorCombo;
        private ComboBox ASMCombo;
        private Label label1;
        private Label ASM;
        private Label Remark;
        private Label SerialNo;
        private Label Location;
        private Label Position;
        private Label Categories;
        private Label Brand;
        private Label LastName;
        private Label FirstName;
        private Label EmpNo;
        private Label RepID;
        private TextBox repIDTxt;
        private TextBox empTxt;
    }
}