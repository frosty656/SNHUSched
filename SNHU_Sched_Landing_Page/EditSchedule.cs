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
	public partial class Schedule_Input2 : Form
	{
		public Schedule_Input2()
		{
			InitializeComponent();

            ColorButton.BackColor = Color.Red;
            colorDialog1.Color = Color.Red; //Default block color

            MySQLFunctions.getClassInfo($"SELECT day, starttime, colorA, colorR, colorG,colorB FROM timeblock WHERE userID = {userInfo.getCurrentUser()}", ref blockList);

			foreach (var l in blockList)
			{
				string day = "", time = "", combined = "";
				switch (l.day)
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
				switch (l.startTime)
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
                    this.Controls[combined].BackColor = Color.FromArgb(l.a,l.r,l.g,l.b); ;
				}
				catch (ArgumentException k)
				{
					MessageBox.Show(k.Message);
				}
			}
			blockList.Clear();

		}

		List<timeBlock> blockList = new List<timeBlock>();
		List<timeBlock> classesToDelete = new List<timeBlock>();

		public class timeBlock
		{
			public timeBlock() { }
			public string startTime { get; set; }
			public string day { get; set; }
            public int a { get; set; }
            public int r { get; set; }
            public int g { get; set; }
            public int b { get; set; }
        }

		//add class button
		private void button1_Click(object sender, EventArgs e)
		{
			if (classIDInput.Text != "")
			{
				foreach(var r in classesToDelete)
				{
					MySQLFunctions.SQLCommand($"DELETE FROM timeblock WHERE day = '{r.day}' AND starttime = '{r.startTime}'");
				}

				foreach (var p in blockList)
				{
					MySQLFunctions.SQLCommand($"INSERT INTO timeblock VALUES ({userInfo.getCurrentUser()}, '{classIDInput.Text}', " +
						$"'{p.startTime}', '{p.day}', '{buildingInput.Text}', '{roomInput.Text}', '{profInput.Text}', " +
                        $"'{colorDialog1.Color.A}', '{colorDialog1.Color.R}', '{colorDialog1.Color.G}', '{colorDialog1.Color.B}')");

				}
				blockList.Clear();

				//Allow user to see entire schedule old bocks are turned to orangered
				foreach (Button s in this.Controls.OfType<Button>())
				{
					if(s.BackColor == Color.Green)
					{
						s.BackColor = colorDialog1.Color;
					}
				}

				classIDInput.Text = "";
				profInput.Text = "";
				buildingInput.Text = "";
				roomInput.Text = "";

			} else
			{
				MessageBox.Show("The class name can not be blank");
			}
		}


		private void selectDayAndTime(object sender, EventArgs e)
		{
			string userday = "", time = "";

			userday = (sender as Button).Name.Substring(0, 3);
			time = (sender as Button).Name;
			time = time[3].ToString();

			switch (userday)
			{
				case "mon":
					userday = "Monday";
					break;
				case "tue":
					userday = "Tuesday";
					break;
				case "wed":
					userday = "Wednesday";
					break;
				case "thu":
					userday = "Thursday";
					break;
				case "fri":
					userday = "Friday";
					break;
			}
			switch (time)
			{
				case "1":
					time = "8:00am";
					break;
				case "2":
					time = "9:30am";
					break;
				case "3":
					time = "11:00am";
					break;
				case "4":
					time = "12:30pm";
					break;
				case "5":
					time = "2:00pm";
					break;
				case "6":
					time = "3:30pm";
					break;
				case "7":
					time = "5:00pm";
					break;
				case "8":
					time = "6:30pm";
					break;
			}

			if ((sender as Button).BackColor == Color.White)
			{

				blockList.Add(new timeBlock() { startTime = time, day = userday });
				
				(sender as Button).BackColor = Color.Green;
			}
			else if ((sender as Button).BackColor != Color.OrangeRed)
			{
				DialogResult result = MessageBox.Show("Do you want to override?", "There is already a block here", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
				{
					classesToDelete.Add(new timeBlock() {startTime = time, day = userday });

					blockList.Add(new timeBlock() { day = userday, startTime = time });

					(sender as Button).BackColor = Color.Green;
				}
				else
				{
					var itemToRemove = blockList.Single(r => r.startTime == time && r.day == userday);
					blockList.Remove(itemToRemove);
				}

            }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bool noOpenClasses = true;
			foreach(var button in this.Controls.OfType<Button>())
			{
				if (button.BackColor == Color.Green)
				{
					noOpenClasses = false;
					MessageBox.Show("You have still have a class that is not confirmed!");
				}
			}

			if (noOpenClasses)
			{
				this.Hide();
				transition.openClassView();
				this.Close();
			}

		}

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
            
                ColorButton.BackColor = colorDialog1.Color;
            }
        }
    }
}
