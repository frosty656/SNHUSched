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

		string classStartTime;

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
			ClassStartTime.SelectedIndex = -1;
		}

		private void Done_Click(object sender, EventArgs e)
		{
			uploadClass(classStartTime, ClassID.Text);

            LoginHome loginHome = new LoginHome();
            loginHome.ShowDialog();

        }

		private void uploadClass(string time, string classID)
		{
			MySQLFunctions.SQLCommand($"INSERT INTO timeblock VALUES ({userInfo.getCurrentUser()}, '{classID}', '{time}', UUID())");
		}
    }

}
