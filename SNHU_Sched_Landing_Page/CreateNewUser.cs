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
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            bool notAlreadyInDatabase = true;
			if (SignUpButton.BackColor == Color.Green)
			{
				//Get first and last name from email
				string email = Email.Text;
				string firstName = email.Split('.')[0];
				string lastName = email.Split('.')[1];
				lastName = lastName.Split('@')[0];


                try
                {
                    NewUser(Int32.Parse(StudentID.Text), firstName, lastName, Email.Text, MySQLFunctions.GenerateHash(Password.Text, Email.Text));
                } catch (ArgumentException)
                {
                    return;
                }


                userInfo.setCurrentUser(Int32.Parse(StudentID.Text));


                this.Hide();
                transition.openScheduleInput();
                this.Close();
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if(Email.Text.Contains("@snhu.edu"))
            {
				
                EmailColor.BackColor = Color.Green;
            }
            else
            {
                EmailColor.BackColor = Color.Red;
            }
            EverythingGood();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
			ConfirmPassword.Text = "";
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

		private void NewUser(int uniqueID, string firstName, string lastName, string email, string password)
		{
			MySQLFunctions.SQLCommand($"INSERT INTO usertable VALUES ('{uniqueID}', '{firstName}', '{lastName}', '{email}', '{password}')");

		}
	}
}