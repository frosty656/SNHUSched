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


        }
    }
}
