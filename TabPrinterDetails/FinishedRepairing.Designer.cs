namespace TabPrinterDetails
{
    partial class FinishedRepairing
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
            txtSerielNo = new TextBox();
            txtResult = new ComboBox();
            label1 = new Label();
            cmbBrand = new ComboBox();
            btnClose = new Button();
            btnClear = new Button();
            btnSave = new Button();
            dgv1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            txtRemark = new TextBox();
            label9 = new Label();
            label14 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSerielNo);
            panel1.Controls.Add(txtResult);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbBrand);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dgv1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtRemark);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 590);
            panel1.TabIndex = 1;
            // 
            // txtSerielNo
            // 
            txtSerielNo.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSerielNo.Location = new Point(111, 73);
            txtSerielNo.Multiline = true;
            txtSerielNo.Name = "txtSerielNo";
            txtSerielNo.Size = new Size(242, 30);
            txtSerielNo.TabIndex = 37;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.FormattingEnabled = true;
            txtResult.Location = new Point(111, 184);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(242, 26);
            txtResult.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 189);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 35;
            label1.Text = "Results";
            // 
            // cmbBrand
            // 
            cmbBrand.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(111, 21);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(242, 26);
            cmbBrand.TabIndex = 34;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
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
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(358, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 32);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(477, 373);
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
            dgv1.Size = new Size(535, 131);
            dgv1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 22);
            dateTimePicker1.TabIndex = 26;
            // 
            // txtRemark
            // 
            txtRemark.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemark.Location = new Point(111, 236);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(441, 99);
            txtRemark.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(28, 26);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 8;
            label9.Text = "Brand";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(28, 135);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 78);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Seriel No";
            // 
            // FinishedRepairing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 595);
            Controls.Add(panel1);
            Name = "FinishedRepairing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinishedRepairing";
            Load += FinishedRepairing_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSerielNo;
        private ComboBox txtResult;
        private Label label1;
        private ComboBox cmbBrand;
        private Button btnClose;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dgv1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtRemark;
        private Label label9;
        private Label label14;
        private Label label4;
        private Label label3;
    }
}