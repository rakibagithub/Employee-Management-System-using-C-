namespace DWA.PAL.User_Control
{
    partial class UserControlAttendance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabPage();
            this.dataGridViewMarkAttendance = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPageMarkAttendance);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Controls.Add(this.dataGridViewMarkAttendance);
            this.tabPageMarkAttendance.Controls.Add(this.panel4);
            this.tabPageMarkAttendance.Controls.Add(this.comboBoxDepartment);
            this.tabPageMarkAttendance.Controls.Add(this.label3);
            this.tabPageMarkAttendance.Controls.Add(this.dateTimePickerDate);
            this.tabPageMarkAttendance.Controls.Add(this.label2);
            this.tabPageMarkAttendance.Controls.Add(this.label1);
            this.tabPageMarkAttendance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(4, 4);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(888, 503);
            this.tabPageMarkAttendance.TabIndex = 0;
            this.tabPageMarkAttendance.Text = "Mark Attendeance";
            this.tabPageMarkAttendance.UseVisualStyleBackColor = true;
            this.tabPageMarkAttendance.Leave += new System.EventHandler(this.tabPageMarkAttendance_Leave);
            // 
            // dataGridViewMarkAttendance
            // 
            this.dataGridViewMarkAttendance.AllowUserToAddRows = false;
            this.dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewMarkAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewMarkAttendance.AllowUserToResizeRows = false;
            this.dataGridViewMarkAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMarkAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarkAttendance.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewMarkAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMarkAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarkAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewMarkAttendance.Location = new System.Drawing.Point(7, 115);
            this.dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            this.dataGridViewMarkAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMarkAttendance.ShowCellErrors = false;
            this.dataGridViewMarkAttendance.ShowEditingIcon = false;
            this.dataGridViewMarkAttendance.ShowRowErrors = false;
            this.dataGridViewMarkAttendance.Size = new System.Drawing.Size(858, 364);
            this.dataGridViewMarkAttendance.TabIndex = 19;
            this.dataGridViewMarkAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarkAttendance_CellContentClick);
            this.dataGridViewMarkAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMarkAttendance_CellFormatting);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(599, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 2);
            this.panel4.TabIndex = 0;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(599, 58);
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
            this.label3.Location = new System.Drawing.Point(483, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department : ";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(174, 51);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(156, 29);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 51);
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
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark Attendance : ";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Employee Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Reg";
            this.Column3.HeaderText = "Reg No";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(896, 540);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewMarkAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
