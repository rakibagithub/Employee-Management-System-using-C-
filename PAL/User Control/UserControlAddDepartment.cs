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
    public partial class UserControlAddDepartment : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                               Initial Catalog = Attendance_Management_System;
                               Integrated Security = True;";

        private string CID = "";
        public UserControlAddDepartment()
        {
            InitializeComponent();
        }

        private void IntegerType(KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxHmEmployee.Clear();
            textBoxMale.Clear();
            textBoxFemale.Clear();
            tabControlAddDepartment.SelectedTab = tabPageAddDepartment;
        }

        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxHmEmployee1.Clear();
            textBoxMale1.Clear();
            textBoxFemale1.Clear();
            CID = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name Like '%" + textBoxSearch.Text.Trim() + "%';", dataGridViewDepartment, sql);

        }
        */

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name LIKE '%" + textBoxSearch.Text.Trim() + "%';", dataGridViewDepartment, sql);
        }

        private void tabPageSearchDepartment_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMale_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Trim() == string.Empty || textBoxHmEmployee.Text.Trim() == string.Empty || textBoxMale.Text.Trim() == string.Empty || textBoxFemale.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First fill out all the fields. ", " Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddClass(textBoxName.Text.Trim(), textBoxHmEmployee.Text.Trim(), textBoxMale.Text.Trim(),textBoxFemale.Text.Trim(),sql);

                if(check)
                    ClearTextBox();
            }
        }

        private void tabPageUPDepartment_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageSearchDepartment_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table;", dataGridViewDepartment,sql);
            dataGridViewDepartment.Columns[0].Visible = false;
            labelCountDepartment.Text = dataGridViewDepartment.Rows.Count.ToString();
        }

        private void tabPageAddDepartment_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddDepartment_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void textBoxHmEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxFemale_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxHmEmployee1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxMale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxFemale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewDepartment.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxHmEmployee1.Text = row.Cells[2].Value.ToString();
                textBoxMale1.Text = row.Cells[3].Value.ToString();
                textBoxFemale1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHmEmployee1.Text.Trim() == string.Empty || textBoxMale1.Text.Trim() == string.Empty || textBoxFemale1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First fill out all the fields. ", " Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateClass(CID, textBoxName1.Text.Trim(), textBoxHmEmployee1.Text.Trim(), textBoxMale1.Text.Trim(), textBoxFemale1.Text.Trim(), sql);

                    if (check)
                        ClearTextBox();
                }
            }
            else
                MessageBox.Show("First select row from table.", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHmEmployee1.Text.Trim() == string.Empty || textBoxMale1.Text.Trim() == string.Empty || textBoxFemale1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First fill out all the fields. ", " Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you want to delete this department?", "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteClass(CID, sql);

                        if (check)
                            ClearTextBox1();
                    }
                }
            }
            else
                MessageBox.Show("First select row from table.", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
