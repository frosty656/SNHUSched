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
    public partial class ChangeAccountInfo : Form
    {
        public ChangeAccountInfo()
        {
            InitializeComponent();
        }

        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            var comparedPassword = MySQLFunctions.GenerateHash(ChangeEmailPassword.Text, ChangeEmailCurrentEmail.Text);

            if (ChangeEmailNewEmail.Text.Contains("@snhu.edu"))
            {
                if (comparedPassword == MySQLFunctions.getPass(ChangeEmailCurrentEmail.Text))
                {
                    MySQLFunctions.SQLCommand($"UPDATE usertable SET email = '{ChangeEmailNewEmail.Text}' WHERE userID = {userInfo.getCurrentUser()}");

                    MySQLFunctions.SQLCommand($"UPDATE usertable SET password = '{MySQLFunctions.GenerateHash(ChangeEmailPassword.Text, ChangeEmailNewEmail.Text)}' WHERE userID = {userInfo.getCurrentUser()}");
                }
                else
                {
                    MessageBox.Show("Current Email or password is wrong");
                }
            } else
            {
                MessageBox.Show("New email is invalid");
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
			string oldhashedPass = MySQLFunctions.getPass(userInfo.getCurrentEmail()); ;

			if(ChangePasswordCurrentPassword.Text != "" && ChangePasswordNew.Text != "" && ChangePasswordConfirmNew.Text!= "")
			{
				if (ChangePasswordNew.Text == ChangePasswordConfirmNew.Text)
				{
					if (MySQLFunctions.GenerateHash(ChangePasswordNew.Text, userInfo.getCurrentEmail()) == oldhashedPass)
					{
						MySQLFunctions.SQLCommand($"UPDATE usertable SET password = " +
							$"'{MySQLFunctions.GenerateHash(ChangePasswordNew.Text, userInfo.getCurrentEmail())}' WHERE userID = {userInfo.getCurrentUser()}");

					}
					else
					{
						MessageBox.Show("Current password is incorrect");
					}
				}
				else
				{
					MessageBox.Show("Passwords must match");
				}
			}
			else
			{
				MessageBox.Show("Please fill in all the fields");
			}

        }

		private void ChangeNameButton_Click(object sender, EventArgs e)
		{
			if (ChangeNameFirstName.Text != "" && ChangeNameLastName.Text != "")
			{
				MySQLFunctions.SQLCommand($"UPDATE usertable SET firstname = '{ChangeNameFirstName.Text}' WHERE userID = {userInfo.getCurrentUser()}");
				MySQLFunctions.SQLCommand($"UPDATE usertable SET lastname = '{ChangeNameLastName.Text}' WHERE userID = {userInfo.getCurrentUser()}");
			}
			else
			{
				MessageBox.Show("Name cannot be blank");
			}
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			transition.openClassView();
			this.Close();
		}
	}
}
