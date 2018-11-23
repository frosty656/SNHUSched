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
	public partial class ClassInformation : Form
	{
		public ClassInformation()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private string getInfo()
		{
			return "end";
		}

		public class classInfo
		{
			public classInfo() { }
			public string startTime { get; set; }
			public string day { get; set; }
			public string classID { get; set; }
			public string professor { get; set; }
			public string building { get; set; }
			public string roomNumber { get; set; }
		}


		private void LoginHome_Load(object sender, EventArgs e)
        {

            var classList = new List<classInfo>();

            MySQLFunctions.getDetailedClassInfo($"SELECT classID, startTime, day, building, roomnumber, professor FROM timeblock WHERE userID LIKE " +
				$"{userInfo.getCurrentUser()};", ref classList);
			int index = 0;
			string lastClass = "";
			foreach (var t in classList)
			{
				string day = "", time = "", combined = "";
				switch (t.day)
				{
					case "Monday":
						day = "mon";
						break;
					case "Tuesday":
						day = "tue";
						break;
					case "Wednesday":
						day = "wed";
						break;
					case "Thursday":
						day = "thu";
						break;
					case "Friday":
						day = "fri";
						break;
				}
				switch (t.startTime)
				{
					case "8:00am":
						time = "1";
						break;
					case "9:30am":
						time = "2";
						break;
					case "11:00am":
						time = "3";
						break;
					case "12:30pm":
						time = "4";
						break;
					case "2:00pm":
						time = "5";
						break;
					case "3:30pm":
						time = "6";
						break;
					case "5:00pm":
						time = "7";
						break;
					case "6:30pm":
						time = "8";
						break;
				}

				combined = day + time;

				try
				{
					this.Controls[combined].BackColor = newColor(index);
					this.Controls[combined].Text = t.classID;
					this.Controls[combined].Click += (s, z) =>
					{
						classnameLabel.Text = t.classID + " Details:";
						profLabel.Text = "Professor: " + t.professor;
						buildingLabel.Text = "Building: " + t.building;
						roomLabel.Text = "Room: " + t.roomNumber;

					};

				}
				catch (ArgumentException k)
				{
					MessageBox.Show(k.Message);
				}

				if (lastClass == t.classID)
				{
					index++;
				}

				lastClass = t.classID;
			}

        }

        private void button1_Click(object sender, EventArgs e)
        {
			this.Hide();
			transition.openComparePage();
			this.Close();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			transition.openScheduleInput();
			this.Close();
		}

		private void logout_Click(object sender, EventArgs e)
		{
			userInfo.setCurrentUser(0);
			this.Hide();
			transition.openHomePage();
			this.Close();
		}

		private Color newColor(int index)
		{
			switch (index)
			{
				case 1:
					return Color.Plum;
				case 2:
					return Color.Orange;
				case 3:
					return Color.Blue;
				case 4:
					return Color.Pink;
				case 5:
					return Color.MediumPurple;
				case 6:
					return Color.Green;
				case 7:
					return Color.Gray;
				case 8:
					return Color.SandyBrown;
				default:
					return Color.Red;
			}
		}
	}
}
