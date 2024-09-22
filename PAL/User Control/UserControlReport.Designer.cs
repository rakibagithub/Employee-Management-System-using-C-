namespace DWA.PAL.User_Control
{
    partial class UserControlReport
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
            this.components = new System.ComponentModel.Container();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageDepartmentReport = new System.Windows.Forms.TabPage();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.dataGridViewDepartmentAttendenceReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEmployeeReport = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployeeReport = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDepartment1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDate1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxPrint1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.easyHTMLReports = new KimToo.EasyHTMLReports(this.components);
            this.tabControlReport.SuspendLayout();
            this.tabPageDepartmentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentAttendenceReport)).BeginInit();
            this.tabPageEmployeeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReport
            // 
            this.tabControlReport.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReport.Controls.Add(this.tabPageDepartmentReport);
            this.tabControlReport.Controls.Add(this.tabPageEmployeeReport);
            this.tabControlReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(896, 540);
            this.tabControlReport.TabIndex = 1;
            // 
            // tabPageDepartmentReport
            // 
            this.tabPageDepartmentReport.Controls.Add(this.pictureBoxPrint);
            this.tabPageDepartmentReport.Controls.Add(this.dataGridViewDepartmentAttendenceReport);
            this.tabPageDepartmentReport.Controls.Add(this.panel4);
            this.tabPageDepartmentReport.Controls.Add(this.comboBoxDepartment);
            this.tabPageDepartmentReport.Controls.Add(this.label3);
            this.tabPageDepartmentReport.Controls.Add(this.dateTimePickerDate);
            this.tabPageDepartmentReport.Controls.Add(this.label2);
            this.tabPageDepartmentReport.Controls.Add(this.label1);
            this.tabPageDepartmentReport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDepartmentReport.Location = new System.Drawing.Point(4, 4);
            this.tabPageDepartmentReport.Name = "tabPageDepartmentReport";
            this.tabPageDepartmentReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartmentReport.Size = new System.Drawing.Size(888, 503);
            this.tabPageDepartmentReport.TabIndex = 0;
            this.tabPageDepartmentReport.Text = "Department Attendeance Report";
            this.tabPageDepartmentReport.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.Image = global::DWA.Properties.Resources.icons8_print_641;
            this.pictureBoxPrint.Location = new System.Drawing.Point(784, 20);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(70, 58);
            this.pictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrint.TabIndex = 20;
            this.pictureBoxPrint.TabStop = false;
            this.pictureBoxPrint.Click += new System.EventHandler(this.pictureBoxPrint_Click);
            this.pictureBoxPrint.MouseHover += new System.EventHandler(this.pictureBoxPrint_MouseHover);
            // 
            // dataGridViewDepartmentAttendenceReport
            // 
            this.dataGridViewDepartmentAttendenceReport.AllowUserToAddRows = false;
            this.dataGridViewDepartmentAttendenceReport.AllowUserToDeleteRows = false;
            this.dataGridViewDepartmentAttendenceReport.AllowUserToResizeColumns = false;
            this.dataGridViewDepartmentAttendenceReport.AllowUserToResizeRows = false;
            this.dataGridViewDepartmentAttendenceReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDepartmentAttendenceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartmentAttendenceReport.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewDepartmentAttendenceReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDepartmentAttendenceReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDepartmentAttendenceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentAttendenceReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewDepartmentAttendenceReport.Location = new System.Drawing.Point(7, 115);
            this.dataGridViewDepartmentAttendenceReport.Name = "dataGridViewDepartmentAttendenceReport";
            this.dataGridViewDepartmentAttendenceReport.ReadOnly = true;
            this.dataGridViewDepartmentAttendenceReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDepartmentAttendenceReport.ShowCellErrors = false;
            this.dataGridViewDepartmentAttendenceReport.ShowEditingIcon = false;
            this.dataGridViewDepartmentAttendenceReport.ShowRowErrors = false;
            this.dataGridViewDepartmentAttendenceReport.Size = new System.Drawing.Size(858, 364);
            this.dataGridViewDepartmentAttendenceReport.TabIndex = 19;
            this.dataGridViewDepartmentAttendenceReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmentAttendenceReport_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_Name";
            this.Column1.HeaderText = "Employee Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Reg";
            this.Column2.HeaderText = "Reg No.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Class_Name";
            this.Column3.HeaderText = "Department";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Attendance_Date";
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(494, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 2);
            this.panel4.TabIndex = 0;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(494, 63);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(201, 30);
            this.comboBoxDepartment.TabIndex = 5;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            this.comboBoxDepartment.Click += new System.EventHandler(this.comboBoxDepartment_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department : ";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(69, 56);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(156, 29);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Attendance Report : ";
            // 
            // tabPageEmployeeReport
            // 
            this.tabPageEmployeeReport.Controls.Add(this.dataGridViewEmployeeReport);
            this.tabPageEmployeeReport.Controls.Add(this.panel2);
            this.tabPageEmployeeReport.Controls.Add(this.comboBoxRegNo);
            this.tabPageEmployeeReport.Controls.Add(this.label7);
            this.tabPageEmployeeReport.Controls.Add(this.panel1);
            this.tabPageEmployeeReport.Controls.Add(this.comboBoxDepartment1);
            this.tabPageEmployeeReport.Controls.Add(this.label4);
            this.tabPageEmployeeReport.Controls.Add(this.dateTimePickerDate1);
            this.tabPageEmployeeReport.Controls.Add(this.label5);
            this.tabPageEmployeeReport.Controls.Add(this.label6);
            this.tabPageEmployeeReport.Controls.Add(this.pictureBoxPrint1);
            this.tabPageEmployeeReport.Location = new System.Drawing.Point(4, 4);
            this.tabPageEmployeeReport.Name = "tabPageEmployeeReport";
            this.tabPageEmployeeReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployeeReport.Size = new System.Drawing.Size(888, 503);
            this.tabPageEmployeeReport.TabIndex = 1;
            this.tabPageEmployeeReport.Text = "Employee Attendence Report";
            this.tabPageEmployeeReport.UseVisualStyleBackColor = true;
            this.tabPageEmployeeReport.Click += new System.EventHandler(this.tabPageEmployeeReport_Click);
            // 
            // dataGridViewEmployeeReport
            // 
            this.dataGridViewEmployeeReport.AllowUserToAddRows = false;
            this.dataGridViewEmployeeReport.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeReport.AllowUserToResizeColumns = false;
            this.dataGridViewEmployeeReport.AllowUserToResizeRows = false;
            this.dataGridViewEmployeeReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployeeReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeeReport.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewEmployeeReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployeeReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewEmployeeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewEmployeeReport.Location = new System.Drawing.Point(17, 133);
            this.dataGridViewEmployeeReport.Name = "dataGridViewEmployeeReport";
            this.dataGridViewEmployeeReport.ReadOnly = true;
            this.dataGridViewEmployeeReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEmployeeReport.ShowCellErrors = false;
            this.dataGridViewEmployeeReport.ShowEditingIcon = false;
            this.dataGridViewEmployeeReport.ShowRowErrors = false;
            this.dataGridViewEmployeeReport.Size = new System.Drawing.Size(858, 364);
            this.dataGridViewEmployeeReport.TabIndex = 28;
            this.dataGridViewEmployeeReport.UseWaitCursor = true;
            this.dataGridViewEmployeeReport.VirtualMode = true;
            this.dataGridViewEmployeeReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeReport_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Student_Name";
            this.Column6.HeaderText = "Employee Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Student_Reg";
            this.Column7.HeaderText = "Reg No.";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Class_Name";
            this.Column8.HeaderText = "Department";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Attendance_Date";
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Attendance_Status";
            this.Column10.HeaderText = "Status";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(623, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 2);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxRegNo
            // 
            this.comboBoxRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(623, 80);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(201, 32);
            this.comboBoxRegNo.TabIndex = 3;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);
            this.comboBoxRegNo.Click += new System.EventHandler(this.comboBoxRegNo_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reg No : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(265, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 2);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxDepartment1
            // 
            this.comboBoxDepartment1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDepartment1.FormattingEnabled = true;
            this.comboBoxDepartment1.Location = new System.Drawing.Point(265, 80);
            this.comboBoxDepartment1.Name = "comboBoxDepartment1";
            this.comboBoxDepartment1.Size = new System.Drawing.Size(201, 32);
            this.comboBoxDepartment1.TabIndex = 2;
            this.comboBoxDepartment1.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment1_SelectedIndexChanged);
            this.comboBoxDepartment1.Click += new System.EventHandler(this.comboBoxDepartment1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department : ";
            // 
            // dateTimePickerDate1
            // 
            this.dateTimePickerDate1.CustomFormat = "MM/yyyy";
            this.dateTimePickerDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate1.Location = new System.Drawing.Point(26, 80);
            this.dateTimePickerDate1.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerDate1.Name = "dateTimePickerDate1";
            this.dateTimePickerDate1.Size = new System.Drawing.Size(156, 32);
            this.dateTimePickerDate1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Employee Attendance Report : ";
            // 
            // pictureBoxPrint1
            // 
            this.pictureBoxPrint1.Image = global::DWA.Properties.Resources.icons8_print_64;
            this.pictureBoxPrint1.Location = new System.Drawing.Point(823, 13);
            this.pictureBoxPrint1.Name = "pictureBoxPrint1";
            this.pictureBoxPrint1.Size = new System.Drawing.Size(59, 50);
            this.pictureBoxPrint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrint1.TabIndex = 27;
            this.pictureBoxPrint1.TabStop = false;
            this.pictureBoxPrint1.Click += new System.EventHandler(this.pictureBoxPrint1_Click);
            this.pictureBoxPrint1.MouseHover += new System.EventHandler(this.pictureBoxPrint1_MouseHover);
            // 
            // easyHTMLReports
            // 
            this.easyHTMLReports.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.easyHTMLReports.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.tabControlReport);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(896, 540);
            this.tabControlReport.ResumeLayout(false);
            this.tabPageDepartmentReport.ResumeLayout(false);
            this.tabPageDepartmentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentAttendenceReport)).EndInit();
            this.tabPageEmployeeReport.ResumeLayout(false);
            this.tabPageEmployeeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReport;
        private System.Windows.Forms.TabPage tabPageDepartmentReport;
        private System.Windows.Forms.DataGridView dataGridViewDepartmentAttendenceReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageEmployeeReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDepartment1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxRegNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxPrint1;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeReport;
        private KimToo.EasyHTMLReports easyHTMLReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
