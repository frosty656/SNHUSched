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
	public partial class Schedule_Input : Form
	{

        string classStartTime, day1, day2;

		public Schedule_Input()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ClassStartTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			classStartTime = ClassStartTime.Text;
		}

		private void AddAnotherClass_Click(object sender, EventArgs e)
		{
			uploadClass(classStartTime, ClassID.Text);

			ClassID.Text = "";
            firstDay.Text = "";
            secondDay.Text = "";
			ClassStartTime.SelectedIndex = -1;
		}

        private void firstDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            day1 = firstDay.Text;
        }

        private void secondDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            day2 = secondDay.Text;
        }

        private void Done_Click(object sender, EventArgs e)
		{
			uploadClass(classStartTime, ClassID.Text);

            LoginHome loginHome = new LoginHome();
            loginHome.ShowDialog();

        }

		private void uploadClass(string time, string classID)
		{
            string nextblock = "";

            //Fill the block that the user has specified
            MySQLFunctions.SQLCommand($"INSERT INTO timeblock VALUES ({userInfo.getCurrentUser()}, '{classID}', '{time}', UUID(), '{day1}')");

            if (day2 != "")
            {
                MySQLFunctions.SQLCommand($"INSERT INTO timeblock VALUES ({userInfo.getCurrentUser()}, '{classID}', '{time}', UUID(), '{day2}')");
            }

            //If it is a double block get the next block and fill it
            if (doubleBlockcheckBox1.Checked)
            {
                switch (time)
                {
                    case "8:00am":
                        nextblock = "9:30am";
                        break;
                    case "9:30am":
                        nextblock = "11:00am";
                        break;
                    case "11:00am":
                        nextblock = "12:30pm";
                        break;
                    case "12:30pm":
                        nextblock = "2:00pm";
                        break;
                    case "2:00pm":
                        nextblock = "3:30pm";
                        break;
                    case "3:30pm":
                        nextblock = "5:00pm";
                        break;
                    case "5:00pm":
                        nextblock = "6:30pm";
                        break;
                    case "6:30pm":
                        MessageBox.Show("There is no block after this");
                        break;
                }
                MySQLFunctions.SQLCommand($"INSERT INTO timeblock VALUES ({userInfo.getCurrentUser()}, '{classID}', '{nextblock}', UUID(), '{day1}')");

                if (day2 != "")
                {
                    MySQLFunctions.SQLCommand($"INSERT INTO timeblock VALUES ({userInfo.getCurrentUser()}, '{classID}', '{nextblock}', UUID(), '{day2}')");
                }
            }

        }
    }

}
