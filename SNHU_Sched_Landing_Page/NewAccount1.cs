using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNHU_Sched_Landing_Page
{
    public partial class NewAccount1 : Form
    {
        public NewAccount1()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }

        //Checking Email

        private void Email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(Email.Text);
                EmailColor.BackColor = Color.Green;
            }
            catch
            {
                EmailColor.BackColor = Color.Red;
            }
            EverythingGood();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text.Length > 21)
            {
                MessageBox.Show("The password must be between 8 and 20 characters");
                PasswordColor.BackColor = Color.Red;
            }
            else
            {
                if (Password.Text.Length < 8)
                {
                    PasswordColor.BackColor = Color.Red;
                }
                else
                {
                    PasswordColor.BackColor = Color.Green;
                }
            }
            EverythingGood();
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != ConfirmPassword.Text)
            {
                ConfirmPasswordColor.BackColor = Color.Red;
            }
            else
            {
                ConfirmPasswordColor.BackColor = Color.Green;

            }
            EverythingGood();
        }

        private void GradYear_TextChanged(object sender, EventArgs e)
        {
            int yearOfGraduation;
            if (Int32.TryParse(GradYear.Text, out yearOfGraduation))
            {
                if (yearOfGraduation < DateTime.Now.Year - 1)
                {
                    GradYearColor.BackColor = Color.Red;
                }
                else
                {
                    GradYearColor.BackColor = Color.Green;
                }


            }
            else
            {
                GradYearColor.BackColor = Color.Red;
            }
            EverythingGood();
        }

        private void StudentID_TextChanged(object sender, EventArgs e)
        {
            int studentID;
            if (StudentID.TextLength == 7)
            {
                if (Int32.TryParse(StudentID.Text, out studentID))
                {
                    StudentIDColor.BackColor = Color.Green;
                }
                else
                {
                    StudentIDColor.BackColor = Color.Red;
                }
            }
            else
            {
                StudentIDColor.BackColor = Color.Red;
            }
            EverythingGood();
        }

        private void EverythingGood()
        {
            if (EmailColor.BackColor == Color.Green && PasswordColor.BackColor == Color.Green && ConfirmPasswordColor.BackColor == Color.Green
                && GradYearColor.BackColor == Color.Green && StudentIDColor.BackColor == Color.Green)
            {
                SignUpButton.BackColor = Color.Green;
            }
            else
            {
                SignUpButton.BackColor = Color.Gray;
            }
        }
    }
}
