using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWA.PAL.User_Control
{
    
    public partial class UserControlAttendance : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                               Initial Catalog = Attendance_Management_System;
                               Integrated Security = True;";
        private bool okay;
        public UserControlAttendance()
        {
            InitializeComponent();
            dataGridViewMarkAttendance.Columns["Column1"].Visible = false;
            dataGridViewMarkAttendance.Columns["Column5"].Visible = false;
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxDepartment.SelectedItem.ToString(), sql))
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Table.Student_ID, Student_Name, Student_Reg, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date ='" + dateTimePickerDate.Text + "' AND Class_Name = '" + comboBoxDepartment.SelectedItem.ToString() + "';", dataGridViewMarkAttendance, sql);
                okay = true;
            }
            else
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg FROM Student_Table INNER JOIN Class_Table ON CLass_Table.Class_ID = Student_Table.Class_ID WHERE Class_Name = '" + comboBoxDepartment.SelectedItem.ToString() + "';", dataGridViewMarkAttendance, sql);
                okay = false;
            }
        }

        private void tabPageMarkAttendance_Leave(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedIndex != -1)
            {
                string status;
                bool attendanceUpdated = false;

                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxDepartment.SelectedItem.ToString(), sql))
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        Attendance.Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);

                        attendanceUpdated = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        Attendance.Attendance.MarkAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);

                        attendanceUpdated = true;
                    }
                }

                if (attendanceUpdated)
                {
                    MessageBox.Show("Attendance has been saved.", "Attendance Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        /*private void tabPageMarkAttendance_Leave(object sender, EventArgs e)
        {
            if(comboBoxDepartment.SelectedIndex != -1)
            {
                string status;
                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxDepartment.SelectedItem.ToString(), sql))
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        Attendance.Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        Attendance.Attendance.MarkAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);
                    }
                }
            }
        }*/
        private void dataGridViewMarkAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (comboBoxDepartment.SelectedIndex != -1)
            {
                if (Attendance.Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxDepartment.SelectedItem.ToString(), sql) && okay)
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (row.Cells["Column5"].Value.ToString() == "present")
                            row.Cells["Column4"].Value = true;
                        else
                            row.Cells["Column4"].Value = false;
                    }
                }

            }
        }

        private void comboBoxDepartment_Click(object sender, EventArgs e)
        {
            comboBoxDepartment.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxDepartment, sql);
        }

        private void dataGridViewMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
