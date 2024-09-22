using DWA.PAL.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWA.PAL.Forms
{
    public partial class FormMain : Form
    {
        public string Username, Role;

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 260);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if(Role == "User")
            {
                buttonDashboard.Hide();
                buttonAddDepartment.Hide();
                buttonAddEmployee.Hide();
                buttonRegister.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
                panelExpand.Hide();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlReport1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlAddDepartment1.Visible = false;
            userControlAddEmployee1.Visible = false;
            userControlRegister1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlRegister1.Visible = false;
            userControlAddDepartment1.Visible = false;
            userControlAddEmployee1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlReport1.Visible = false;
            userControlAttendance1.Visible = true;
        }
        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddDepartment);
            userControlAddDepartment1.ClearTextBox();
            userControlAddDepartment1.Visible = true;
            userControlRegister1.Visible = false;
            userControlAddEmployee1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlReport1.Visible = false;
            userControlAttendance1.Visible = false;
        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddEmployee);
            userControlAddDepartment1.Visible = false;
            userControlRegister1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlRegister1.HideErrorPic();
            userControlAddEmployee1.ClearTextBox();
            userControlAddEmployee1.Visible = true;
            userControlAttendance1.Visible = false;
            userControlReport1.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlReport1.Visible = false;
            userControlAddEmployee1.Visible = false;
            userControlAddDepartment1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlRegister1.ClearTextBox();
            userControlRegister1.Visible = true;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if(panelExpand.Visible)
                panelExpand.Visible = false;
            else
                panelExpand.Visible = true;
        }

        private void userControlAddDepartment1_Load(object sender, EventArgs e)
        {

        }

        private void userControlReport1_Load(object sender, EventArgs e)
        {

        }

       

        private void buttonReport_Click_1(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlAddDepartment1.Visible = false;
            userControlAddEmployee1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlReport1.FirstTab();
            userControlReport1.Visible = true;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
