using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DWA.PAL.User_Control
{
    public partial class UserControlAddEmployee : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                               Initial Catalog = Attendance_Management_System;
                               Integrated Security = True;";
        private string Gender = "", Role, ID = "";
        public UserControlAddEmployee()
        {
            InitializeComponent();
        }

        public void HideErrorPic()
        {
            pictureBoxErrorPho.Visible = false;
            pictureBoxErrorNID.Visible = false;
            pictureBoxErrorDOB.Visible = false;
            pictureBoxErrorEmail.Visible = false;
        }

        private void HideErrorPic1()
        {
            pictureBoxErrorPho1.Visible = false;
            pictureBoxErrorNID1.Visible = false;
            pictureBoxErrorDOB1.Visible = false;
            pictureBoxErrorEmail1.Visible = false;
        }

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxPass.Clear();
            maskedTextBoxpho.Text = "+00 000 00000000";
            maskedTextBoxpho.ForeColor = Color.DarkGray;
            maskedTextBoxNID.Text = "00000-0000000-0";
            maskedTextBoxNID.ForeColor = Color.DarkGray;
            maskedTextBoxDOB.Text = "00/00/0000";
            maskedTextBoxDOB.ForeColor = Color.DarkGray;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxEmail.Text = "rakiba@domain.com";
            textBoxEmail.ForeColor = Color.DarkGray;
            checkBoxRole.Checked = false;
            textBoxAdd.Clear();
            tabControlRegister.SelectedTab = tabPageAddUser;
        }

        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxPass1.Clear();
            maskedTextBoxpho1.Text = "+00 000 00000000";
            maskedTextBoxpho1.ForeColor = Color.DarkGray;
            maskedTextBoxNID1.Text = "00000-0000000-0";
            maskedTextBoxNID1.ForeColor = Color.DarkGray;
            maskedTextBoxDOB1.Text = "00/00/0000";
            maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            textBoxEmail1.Text = "rakiba@domain.com";
            textBoxEmail1.ForeColor = Color.DarkGray;
            checkBoxRole1.Checked = false;
            textBoxAdd1.Clear();
            ID = "";
        }

        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox.Select(0, 0);
            });
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsValidDate(string date)
        {
            DateTime d;
            bool chValidity;
            try
            {
                return chValidity = DateTime.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void tabPageAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxpho_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxErrorPhone_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxSearch, "Search");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "rakiba@domain.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "rakiba@domain.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }

            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "rakiba@domain.com")
                pictureBoxErrorEmail.Visible = true;
            else
                pictureBoxErrorEmail.Visible = false;
        }

        private void maskedTextBoxpho_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxpho.Text == "+00 000 00000000")
                maskedTextBoxpho.Text = "";
            if (!maskedTextBoxpho.MaskCompleted)
            {
                maskedTextBoxpho.ForeColor = Color.Black;
                Mask(maskedTextBoxpho);
            }
        }

        private void maskedTextBoxpho_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxpho.Text == "+")
            {
                maskedTextBoxpho.Text = "+00 000 00000000";
                maskedTextBoxpho.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxpho.MaskCompleted)
                maskedTextBoxpho.ForeColor = Color.DarkGray;
            if (!maskedTextBoxpho.MaskCompleted || maskedTextBoxpho.Text == "+00 000 00000000")
                pictureBoxErrorPho.Visible = true;
            else
                pictureBoxErrorPho.Visible = false;
        }

        private void maskedTextBoxNID_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxNID.Text == "00000-0000000-0")
                maskedTextBoxNID.Text = "";

            if (!maskedTextBoxNID.MaskCompleted)
            {
                maskedTextBoxNID.ForeColor = Color.Black;
                Mask(maskedTextBoxNID);
            }
        }

        private void maskedTextBoxNID_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxNID.Text == "-       -")
            {
                maskedTextBoxNID.Text = "00000-0000000-0";
                maskedTextBoxNID.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxNID.MaskCompleted)
                maskedTextBoxNID.ForeColor = Color.DarkGray;
            if (maskedTextBoxNID.Text == "00000-0000000-0" || !maskedTextBoxNID.MaskCompleted)
                pictureBoxErrorNID.Visible = true;
            else
                pictureBoxErrorNID.Visible = false;
        }

        private void maskedTextBoxDOB_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text == "00/00/0000")
                maskedTextBoxDOB.Text = "";
            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.Black;
                Mask(maskedTextBoxDOB);
            }
        }

        private void maskedTextBoxDOB_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text.Trim() == "/  /")
            {
                maskedTextBoxDOB.Text = "00/00/0000";
                maskedTextBoxDOB.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxDOB.MaskCompleted)
                maskedTextBoxDOB.ForeColor = Color.DarkGray;
            if (!IsValidDate(maskedTextBoxDOB.Text) || maskedTextBoxDOB.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB.Text) > DateTime.Now)
                pictureBoxErrorDOB.Visible = true;
            else
                pictureBoxErrorDOB.Visible = false;
        }

        private void maskedTextBoxDOB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maskedTextBoxDOB, "MM/DD/YY");
        }

        private void textBoxEmail_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBoxErrorEmail_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorEmail, "Invalid Email!");
        }

        private void pictureBoxErrorDOB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorDOB, "Invalid DOB!");
        }

        private void pictureBoxErrorPho_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorPho, "Invalid Phone No.!");
        }

        private void pictureBoxErrorNID_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorNID, "Invalid NID No.!");
        }

        private void maskedTextBoxPho1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxpho1.Text == "+00 000 00000000")
                maskedTextBoxpho1.Text = "";
            if (!maskedTextBoxpho1.MaskCompleted)
            {
                maskedTextBoxpho1.ForeColor = Color.Black;
                Mask(maskedTextBoxpho1);
            }
        }

        private void maskedTextBoxpho1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxpho1.Text == "+")
            {
                maskedTextBoxpho1.Text = "+00 000 00000000";
                maskedTextBoxpho1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxpho1.MaskCompleted)
                maskedTextBoxpho1.ForeColor = Color.DarkGray;
            if (!maskedTextBoxpho1.MaskCompleted || maskedTextBoxpho1.Text == "+00 000 00000000")
                pictureBoxErrorPho1.Visible = true;
            else
                pictureBoxErrorPho1.Visible = false;
        }

        private void maskedTextBoxpho1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void pictureBoxErrorPho1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorPho1, "Invalid Phone No.!");
        }

        private void maskedTextBoxNID1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxNID1.Text == "00000-0000000-0")
                maskedTextBoxNID1.Text = "";

            if (!maskedTextBoxNID1.MaskCompleted)
            {
                maskedTextBoxNID1.ForeColor = Color.Black;
                Mask(maskedTextBoxNID1);
            }
        }

        private void maskedTextBoxNID1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxNID1.Text == "-       -")
            {
                maskedTextBoxNID1.Text = "00000-0000000-0";
                maskedTextBoxNID1.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxNID1.MaskCompleted)
                maskedTextBoxNID1.ForeColor = Color.DarkGray;
            if (maskedTextBoxNID1.Text == "00000-0000000-0" || !maskedTextBoxNID1.MaskCompleted)
                pictureBoxErrorNID1.Visible = true;
            else
                pictureBoxErrorNID1.Visible = false;
        }

        private void pictureBoxErrorNID1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorNID1, "Invalid NID No.!");
        }

        private void maskedTextBoxDOB1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text == "00/00/0000")
                maskedTextBoxDOB1.Text = "";
            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.Black;
                Mask(maskedTextBoxDOB1);
            }
        }

        private void maskedTextBoxDOB1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text.Trim() == "/  /")
            {
                maskedTextBoxDOB1.Text = "00/00/0000";
                maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxDOB1.MaskCompleted)
                maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            if (!IsValidDate(maskedTextBoxDOB1.Text) || maskedTextBoxDOB1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now)
                pictureBoxErrorDOB1.Visible = true;
            else
                pictureBoxErrorDOB1.Visible = false;
        }

        private void pictureBoxErrorDOB1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorDOB1, "Invalid DOB!");
        }

        private void textBoxEmail1_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "rakiba@domain.com")
            {
                textBoxEmail1.Text = "";
                textBoxEmail1.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail1_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "")
            {
                textBoxEmail1.Text = "rakiba@domain.com";
                textBoxEmail1.ForeColor = Color.DarkGray;
            }

            if (!IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "rakiba@domain.com")
                pictureBoxErrorEmail1.Visible = true;
            else
                pictureBoxErrorEmail1.Visible = false;
        }

        private void pictureBoxErrorEmail1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorEmail1, "Invalid Email!");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser, sql);
            if (comboBoxSearchBy.SelectedIndex == 1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Pho LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser, sql);
            if (comboBoxSearchBy.SelectedIndex == 2)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_CNIC LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser, sql);
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table;", dataGridViewUser, sql);
            dataGridViewUser.Columns[0].Visible = false;
            labelCountUser.Text = dataGridViewUser.Rows.Count.ToString();
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            HideErrorPic();
            HideErrorPic1();
            ClearTextBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
                Gender = "Male";
            else
                Gender = "Female";
            if (checkBoxRole.Checked)
                Role = "Admin";
            else
                Role = "User";
            if (textBoxName.Text.Trim() == string.Empty || textBoxPass.Text.Trim() == string.Empty
                || !maskedTextBoxpho.MaskCompleted || maskedTextBoxpho.Text == "+00 000 00000000"
                || !maskedTextBoxNID.MaskCompleted || maskedTextBoxNID.Text == "00000-0000000-0"
                || !IsValidDate(maskedTextBoxDOB.Text) || maskedTextBoxDOB.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB.Text) > DateTime.Now
                || Gender == string.Empty
                || !IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "rakiba@domain.com")
                MessageBox.Show("Please fill out all fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                bool check = Attendance.Attendance.AddRole(textBoxName.Text.Trim(), textBoxPass.Text.Trim(),
                    maskedTextBoxpho.Text, maskedTextBoxNID.Text, maskedTextBoxDOB.Text, Gender, textBoxEmail.Text.Trim(),
                    Role, textBoxAdd.Text.Trim(), sql);
                if (check)
                    ClearTextBox();
            }
        }

        private void tabPageAddUser_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageUPUser_Leave(object sender, EventArgs e)
        {
            HideErrorPic1();
            ClearTextBox1();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxPass1.Text = row.Cells[2].Value.ToString();
                maskedTextBoxpho1.Text = row.Cells[3].Value.ToString();
                maskedTextBoxpho1.ForeColor = Color.Black;
                maskedTextBoxNID1.Text = row.Cells[4].Value.ToString();
                maskedTextBoxNID1.ForeColor = Color.Black;
                maskedTextBoxDOB1.Text = row.Cells[5].Value.ToString();
                maskedTextBoxDOB1.ForeColor = Color.Black;
                Gender = row.Cells[6].Value.ToString();
                if (Gender == "Male")
                    radioButtonMale1.Checked = true;
                else
                    radioButtonFemale1.Checked = true;
                textBoxEmail1.Text = row.Cells[7].Value.ToString();
                textBoxEmail1.ForeColor = Color.Black;
                Role = row.Cells[8].Value.ToString();
                if (Role == "Admin")
                    checkBoxRole.Checked = true;
                textBoxAdd1.Text = row.Cells[9].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonMale1.Checked)
                    Gender = "Male";
                else
                    Gender = "Female";
                if (checkBoxRole1.Checked)
                    Role = "Admin";
                else
                    Role = "User";
                if (textBoxName1.Text.Trim() == string.Empty || textBoxPass1.Text.Trim() == string.Empty
                    || !maskedTextBoxpho1.MaskCompleted || maskedTextBoxpho1.Text == "+00 000 00000000"
                    || !maskedTextBoxNID1.MaskCompleted || maskedTextBoxNID1.Text == "00000-0000000-0"
                    || !IsValidDate(maskedTextBoxDOB1.Text) || maskedTextBoxDOB1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "rakiba@domain.com")
                    MessageBox.Show("Please fill out all fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    bool check = Attendance.Attendance.UpdateUser(ID, textBoxName1.Text.Trim(), textBoxPass1.Text.Trim(),
                    maskedTextBoxpho1.Text, maskedTextBoxNID1.Text, maskedTextBoxDOB1.Text, Gender, textBoxEmail1.Text.Trim(),
                    Role, textBoxAdd1.Text.Trim(), sql);

                    if (check)
                        ClearTextBox1();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonMale1.Checked)
                    Gender = "Male";
                else
                    Gender = "Female";
                if (checkBoxRole1.Checked)
                    Role = "Admin";
                else
                    Role = "User";
                if (textBoxName1.Text.Trim() == string.Empty || textBoxPass1.Text.Trim() == string.Empty
                    || !maskedTextBoxpho1.MaskCompleted || maskedTextBoxpho1.Text == "+00 000 00000000"
                    || !maskedTextBoxNID1.MaskCompleted || maskedTextBoxNID1.Text == "00000-0000000-0"
                    || !IsValidDate(maskedTextBoxDOB1.Text) || maskedTextBoxDOB1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "rakiba@domain.com")
                    MessageBox.Show("Please fill out all fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you want to delete this user?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteUser(ID, sql);
                        if (check)
                            ClearTextBox1();
                    }
                }
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

