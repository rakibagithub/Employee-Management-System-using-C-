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
    public partial class FormLogin : Form
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                               Initial Catalog = Attendance_Management_System;
                               Integrated Security = True;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Check = Attendance.Attendance.IsValidNamePass(textBoxName.Text.Trim(), textBoxPassword.Text.Trim(), sql);
            if(textBoxName.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty)
            {
                if(Check != "")
                {
                    FormMain formMain = new FormMain();
                    formMain.Username = textBoxName.Text;
                    formMain.Role = Check;
                    textBoxName.Clear();
                    textBoxPassword.Clear();
                    pictureBoxHide_Click(sender, e);
                    textBoxName.Focus();
                    pictureBoxError.Hide();
                    labelError.Hide();
                    formMain.ShowDialog();
                }
                else
                {
                    pictureBoxError.Show();
                    labelError.Show();
                }
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();   
            formForgotPassword.ShowDialog();
        }
    }
}
