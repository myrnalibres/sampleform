namespace chapter4
{
    partial class Mainform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FirstName = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.HireDate = new System.Windows.Forms.Label();
            this.listBoxPosition = new System.Windows.Forms.ListBox();
            this.AddPersonnel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnhireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnlongpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columndeductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeHireDate = new System.Windows.Forms.DateTimePicker();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(104, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(77, 18);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(57, 28);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.Click += new System.EventHandler(this.FirstNameTextBox_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(230, 28);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 2;
            this.LastNameTextBox.Click += new System.EventHandler(this.LastNameTextBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.Location = new System.Drawing.Point(395, 9);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(57, 18);
            this.Position.TabIndex = 6;
            this.Position.Text = "Position";
            // 
            // HireDate
            // 
            this.HireDate.AutoSize = true;
            this.HireDate.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireDate.Location = new System.Drawing.Point(558, 6);
            this.HireDate.Name = "HireDate";
            this.HireDate.Size = new System.Drawing.Size(67, 18);
            this.HireDate.TabIndex = 7;
            this.HireDate.Text = "Hire Date";
            // 
            // listBoxPosition
            // 
            this.listBoxPosition.FormattingEnabled = true;
            this.listBoxPosition.Items.AddRange(new object[] {
            "PO1",
            "PO2",
            "PO3",
            "SPO1",
            "SPO2",
            "SPO3",
            "SPO4",
            "PINSP",
            "PSINSP",
            "PCINSP",
            "PSUPT"});
            this.listBoxPosition.Location = new System.Drawing.Point(375, 25);
            this.listBoxPosition.Name = "listBoxPosition";
            this.listBoxPosition.Size = new System.Drawing.Size(89, 82);
            this.listBoxPosition.TabIndex = 8;
            // 
            // AddPersonnel
            // 
            this.AddPersonnel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddPersonnel.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersonnel.Location = new System.Drawing.Point(57, 77);
            this.AddPersonnel.Name = "AddPersonnel";
            this.AddPersonnel.Size = new System.Drawing.Size(222, 23);
            this.AddPersonnel.TabIndex = 9;
            this.AddPersonnel.Text = "Add Personnel";
            this.AddPersonnel.UseVisualStyleBackColor = false;
            this.AddPersonnel.Click += new System.EventHandler(this.AddPersonnel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ColumnPosition,
            this.ColumnhireDate,
            this.Columnlongpay,
            this.GSIS,
            this.Columndeductions,
            this.Columnsalary});
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.DataPropertyName = "Position";
            this.ColumnPosition.HeaderText = "Position";
            this.ColumnPosition.Name = "ColumnPosition";
            // 
            // ColumnhireDate
            // 
            this.ColumnhireDate.DataPropertyName = "HireDate";
            this.ColumnhireDate.HeaderText = "Hire Date";
            this.ColumnhireDate.Name = "ColumnhireDate";
            // 
            // Columnlongpay
            // 
            this.Columnlongpay.DataPropertyName = "LongPay";
            this.Columnlongpay.HeaderText = "Long Pay";
            this.Columnlongpay.Name = "Columnlongpay";
            // 
            // GSIS
            // 
            this.GSIS.DataPropertyName = "GSIS";
            this.GSIS.HeaderText = "GSIS";
            this.GSIS.Name = "GSIS";
            // 
            // Columndeductions
            // 
            this.Columndeductions.DataPropertyName = "TotalDeductions";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Columndeductions.DefaultCellStyle = dataGridViewCellStyle2;
            this.Columndeductions.HeaderText = "Deductions";
            this.Columndeductions.Name = "Columndeductions";
            // 
            // Columnsalary
            // 
            this.Columnsalary.DataPropertyName = "TotalSalary";
            this.Columnsalary.HeaderText = "Salary";
            this.Columnsalary.Name = "Columnsalary";
            // 
            // dateTimeHireDate
            // 
            this.dateTimeHireDate.Location = new System.Drawing.Point(537, 35);
            this.dateTimeHireDate.Name = "dateTimeHireDate";
            this.dateTimeHireDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHireDate.TabIndex = 11;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(295, 312);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(106, 32);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(91, 318);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(136, 26);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(888, 425);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.dateTimeHireDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddPersonnel);
            this.Controls.Add(this.listBoxPosition);
            this.Controls.Add(this.HireDate);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstName);
            this.Name = "Mainform";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label HireDate;
        private System.Windows.Forms.ListBox listBoxPosition;
        private System.Windows.Forms.Button AddPersonnel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimeHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnhireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnlongpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columndeductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnsalary;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

