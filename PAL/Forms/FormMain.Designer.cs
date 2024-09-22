namespace DWA.PAL.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControlRegister1 = new DWA.PAL.User_Control.UserControlRegister();
            this.userControlAddEmployee1 = new DWA.PAL.User_Control.UserControlAddEmployee();
            this.userControlAddDepartment1 = new DWA.PAL.User_Control.UserControlAddDepartment();
            this.userControlDashboard1 = new DWA.PAL.User_Control.UserControlDashboard();
            this.userControlAttendance1 = new DWA.PAL.User_Control.UserControlAttendance();
            this.userControlReport1 = new DWA.PAL.User_Control.UserControlReport();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonAddEmployee);
            this.panel1.Controls.Add(this.buttonAddDepartment);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 749);
            this.panel1.TabIndex = 0;
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.Navy;
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Image = global::DWA.Properties.Resources.icons8_report_48;
            this.buttonReport.Location = new System.Drawing.Point(14, 538);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(322, 54);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "     Report";
            this.buttonReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click_1);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Navy;
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Image = global::DWA.Properties.Resources.icons8_setting_48;
            this.buttonRegister.Location = new System.Drawing.Point(14, 490);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(322, 48);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "     Register";
            this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.Navy;
            this.buttonAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddEmployee.FlatAppearance.BorderSize = 0;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonAddEmployee.Image = global::DWA.Properties.Resources.icons8_add_male_user_group_48;
            this.buttonAddEmployee.Location = new System.Drawing.Point(14, 436);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(322, 54);
            this.buttonAddEmployee.TabIndex = 0;
            this.buttonAddEmployee.Text = "     Add Employee";
            this.buttonAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.BackColor = System.Drawing.Color.Navy;
            this.buttonAddDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddDepartment.FlatAppearance.BorderSize = 0;
            this.buttonAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDepartment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDepartment.ForeColor = System.Drawing.Color.White;
            this.buttonAddDepartment.Image = global::DWA.Properties.Resources.icons8_department_48;
            this.buttonAddDepartment.Location = new System.Drawing.Point(14, 382);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(322, 54);
            this.buttonAddDepartment.TabIndex = 0;
            this.buttonAddDepartment.Text = "     Add Department";
            this.buttonAddDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.Color.Navy;
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonAttendance.Image = global::DWA.Properties.Resources.icons8_attendance_48;
            this.buttonAttendance.Location = new System.Drawing.Point(14, 328);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(322, 54);
            this.buttonAttendance.TabIndex = 0;
            this.buttonAttendance.Text = "     Attendance";
            this.buttonAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.Navy;
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::DWA.Properties.Resources.icons8_dashboard_40;
            this.buttonDashboard.Location = new System.Drawing.Point(14, 274);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(322, 54);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "     Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 475);
            this.panel4.TabIndex = 1;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(1, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(13, 54);
            this.panelSlide.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 274);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DWA Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DWA.Properties.Resources.government_image;
            this.pictureBox1.Location = new System.Drawing.Point(67, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Snow;
            this.panelBack.Controls.Add(this.panelExpand);
            this.panelBack.Controls.Add(this.pictureBoxExpand);
            this.panelBack.Controls.Add(this.pictureBox2);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(336, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(896, 209);
            this.panelBack.TabIndex = 0;
            // 
            // panelExpand
            // 
            this.panelExpand.BackColor = System.Drawing.Color.Navy;
            this.panelExpand.Controls.Add(this.buttonLogOut);
            this.panelExpand.Controls.Add(this.buttonMinimize);
            this.panelExpand.Controls.Add(this.panel3);
            this.panelExpand.Location = new System.Drawing.Point(663, 93);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(217, 113);
            this.panelExpand.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.White;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Image = global::DWA.Properties.Resources.icons8_logout_30;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 70);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(217, 43);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "  Log  Out";
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.White;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.Image = global::DWA.Properties.Resources.icons8_minimize_30;
            this.buttonMinimize.Location = new System.Drawing.Point(0, 28);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(217, 43);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.Text = " Minimize";
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 28);
            this.panel3.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            this.pictureBoxExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpand.Image = global::DWA.Properties.Resources.icons8_expand_arrow_48;
            this.pictureBoxExpand.Location = new System.Drawing.Point(795, 52);
            this.pictureBoxExpand.Name = "pictureBoxExpand";
            this.pictureBoxExpand.Size = new System.Drawing.Size(43, 35);
            this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExpand.TabIndex = 5;
            this.pictureBoxExpand.TabStop = false;
            this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::DWA.Properties.Resources.government_image2;
            this.pictureBox2.Location = new System.Drawing.Point(663, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Navy;
            this.labelTime.Location = new System.Drawing.Point(20, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(42, 26);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 93);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(896, 116);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRole.Location = new System.Drawing.Point(165, 79);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(42, 26);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "{?}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(34, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Role : ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(165, 22);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(42, 26);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome : ";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.BackColor = System.Drawing.Color.Snow;
            this.userControlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRegister1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRegister1.Location = new System.Drawing.Point(336, 209);
            this.userControlRegister1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(896, 540);
            this.userControlRegister1.TabIndex = 0;
            this.userControlRegister1.Visible = false;
            // 
            // userControlAddEmployee1
            // 
            this.userControlAddEmployee1.BackColor = System.Drawing.Color.Snow;
            this.userControlAddEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddEmployee1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.userControlAddEmployee1.Location = new System.Drawing.Point(336, 209);
            this.userControlAddEmployee1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userControlAddEmployee1.Name = "userControlAddEmployee1";
            this.userControlAddEmployee1.Size = new System.Drawing.Size(896, 540);
            this.userControlAddEmployee1.TabIndex = 2;
            this.userControlAddEmployee1.Visible = false;
            // 
            // userControlAddDepartment1
            // 
            this.userControlAddDepartment1.BackColor = System.Drawing.Color.White;
            this.userControlAddDepartment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddDepartment1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAddDepartment1.Location = new System.Drawing.Point(336, 209);
            this.userControlAddDepartment1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAddDepartment1.Name = "userControlAddDepartment1";
            this.userControlAddDepartment1.Size = new System.Drawing.Size(896, 540);
            this.userControlAddDepartment1.TabIndex = 1;
            this.userControlAddDepartment1.Visible = false;
            this.userControlAddDepartment1.Load += new System.EventHandler(this.userControlAddDepartment1_Load);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashboard1.Location = new System.Drawing.Point(336, 209);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(896, 540);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlAttendance1
            // 
            this.userControlAttendance1.BackColor = System.Drawing.Color.Snow;
            this.userControlAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAttendance1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAttendance1.Location = new System.Drawing.Point(336, 209);
            this.userControlAttendance1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAttendance1.Name = "userControlAttendance1";
            this.userControlAttendance1.Size = new System.Drawing.Size(896, 540);
            this.userControlAttendance1.TabIndex = 0;
            this.userControlAttendance1.Visible = false;
            // 
            // userControlReport1
            // 
            this.userControlReport1.BackColor = System.Drawing.Color.Snow;
            this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReport1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlReport1.Location = new System.Drawing.Point(336, 209);
            this.userControlReport1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userControlReport1.Name = "userControlReport1";
            this.userControlReport1.Size = new System.Drawing.Size(896, 540);
            this.userControlReport1.TabIndex = 0;
            this.userControlReport1.Visible = false;
            this.userControlReport1.Load += new System.EventHandler(this.userControlReport1_Load);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 749);
            this.Controls.Add(this.userControlReport1);
            this.Controls.Add(this.userControlAttendance1);
            this.Controls.Add(this.userControlRegister1);
            this.Controls.Add(this.userControlAddEmployee1);
            this.Controls.Add(this.userControlAddDepartment1);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DWA Employee Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private User_Control.UserControlDashboard userControlDashboard1;
        private User_Control.UserControlAddDepartment userControlAddDepartment1;
        private User_Control.UserControlAddEmployee userControlAddEmployee1;
        private User_Control.UserControlRegister userControlRegister1;
        private User_Control.UserControlAttendance userControlAttendance1;
        private User_Control.UserControlReport userControlReport1;
        private System.Windows.Forms.Button buttonReport;
    }
}