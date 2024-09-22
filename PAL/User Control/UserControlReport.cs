using DWA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWA.PAL.User_Control
{
    public partial class UserControlReport : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                               Initial Catalog = Attendance_Management_System;
                               Integrated Security = True;";
        public UserControlReport()
        {
            InitializeComponent();
        }

        public void FirstTab()
        {
            tabControlReport.SelectedTab = tabPageDepartmentReport;
        }
       
        private void tabPageEmployeeReport_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");
        }

        private void pictureBoxPrint1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint1, "Print");
        }

        private void comboBoxDepartment_Click(object sender, EventArgs e)
        {
            comboBoxDepartment.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxDepartment, sql);
        }

        private void comboBoxDepartment1_Click(object sender, EventArgs e)
        {
            comboBoxDepartment1.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxDepartment1, sql);
        }
        

        private void comboBoxRegNo_Click(object sender, EventArgs e)
         {
             if(comboBoxDepartment1.SelectedIndex != 1)
             {
                 comboBoxRegNo.Items.Clear();
                 Attendance.Attendance.FillComboBox("SELECT DISTINCT(Student_Reg) FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name = '" + comboBoxDepartment1.SelectedItem.ToString() + "';", comboBoxRegNo, sql);
             }
         }

       /* private void comboBoxRegNo_Click(object sender, EventArgs e)
        {
            if (comboBoxDepartment1.SelectedIndex != -1) // Check for a valid selection
            {
                comboBoxRegNo.Items.Clear();

                string selectedDepartment = comboBoxDepartment1.SelectedItem.ToString();
                string query = "SELECT DISTINCT(Student_Reg) FROM Student_Table " +
                               "INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID " +
                               "WHERE Class_Name = @SelectedDepartment;"; // Use parameterized query

                using (SqlConnection connection = new SqlConnection(sql)) // Use the declared 'sql' variable
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedDepartment", selectedDepartment); // Parameterized value

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxRegNo.Items.Add(reader["Student_Reg"].ToString());
                        }
                        reader.Close();
                    }
                    catch (SqlException ex)
                    {
                        // Handle exceptions (log, display error message, etc.)
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                // Handle case when no department is selected
                MessageBox.Show("Please select a department.");
            }
        }*/

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedIndex != -1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate.Text + "%' AND Class_Name = '" + comboBoxDepartment.SelectedItem.ToString() + "';", dataGridViewDepartmentAttendenceReport, sql);
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartment1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Class_Name = '" + comboBoxDepartment1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "';", dataGridViewEmployeeReport, sql);
        }

        private void comboBoxDepartment1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartment1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Class_Name = '" + comboBoxDepartment1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "';", dataGridViewEmployeeReport, sql);
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            if(comboBoxDepartment.SelectedIndex != -1)
            {
                var present = dataGridViewDepartmentAttendenceReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column5"].Value.ToString() == "Present");
                var absent = dataGridViewDepartmentAttendenceReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column5"].Value.ToString() == "Absent");

                easyHTMLReports.Clear();
                easyHTMLReports.AddImage(Resources.মহিলা_বিষয়ক_অধিদপ্তর, "width=100,style='float:right'");
                easyHTMLReports.AddString("<h1>Department of Women Affairs</h1>");
                easyHTMLReports.AddString("<h2><i>" +comboBoxDepartment.SelectedItem.ToString() + "</i></h2>");
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddDatagridView(dataGridViewDepartmentAttendenceReport);
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Total Employee: " + dataGridViewDepartmentAttendenceReport.Rows.Count.ToString());
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Present Employee: " + present.ToString());
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Absent Employee: " + absent.ToString());
                easyHTMLReports.ShowPrintPreviewDialog();
            }
        }

        private void dataGridViewDepartmentAttendenceReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxPrint1_Click(object sender, EventArgs e)
        {
            if (comboBoxDepartment1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                var present = dataGridViewEmployeeReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column10"].Value.ToString() == "Present");
                var absent = dataGridViewEmployeeReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column10"].Value.ToString() == "Absent");

                easyHTMLReports.Clear();
                easyHTMLReports.AddImage(Resources.মহিলা_বিষয়ক_অধিদপ্তর, "width=100,style='float:right'");
                easyHTMLReports.AddString("<h1>Department of Women Affairs</h1>");
                easyHTMLReports.AddString("<h2><i>" + comboBoxDepartment1.SelectedItem.ToString() + "</i></h2>");
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddDatagridView(dataGridViewEmployeeReport);
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Total Employee: " + dataGridViewEmployeeReport.Rows.Count.ToString());
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Presents: " + present.ToString());
                easyHTMLReports.AddLineBreak();
                easyHTMLReports.AddString("Absents: " + absent.ToString());
                easyHTMLReports.ShowPrintPreviewDialog();
            }
        }

        private void dataGridViewEmployeeReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
