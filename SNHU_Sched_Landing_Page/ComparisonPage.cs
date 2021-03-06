﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;

namespace SNHU_Sched_Landing_Page
{
    public partial class ComparisonPage : Form
    {   
        public class Student
        {
            public Student() { }

            public string StudentID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public class timeBlock
        {
            public timeBlock() { }
            public string startTime { get; set; }
            public string day { get; set; }
        }

        Color color = Color.Red; //comparison color
        Color friendNOTSelected = Color.White; //default friend color
        Color friendSelected = Color.LawnGreen; //friend selected color
        Color buttonBackgroundColor = Color.White;

        public ComparisonPage()
        {
            InitializeComponent();

           


            var friendList = new List<Student>(); //List of all the users friends
			var timeBlocks = new List<timeBlock>(); //List of all friends available times
			var selectedFriendList = new List<string>();// List of all friends you have selected to comapare
			var friendIDs = new List<string>(); //List of IDs of all friends of current user

			selectedFriendList.Add(userInfo.getCurrentUser().ToString());

            MySQLFunctions.getInfo($"SELECT friendID FROM friendtable WHERE userID = {userInfo.getCurrentUser()};", ref friendIDs);

			foreach(var p in friendIDs)
			{
				MySQLFunctions.getFriendInfo($"SELECT userID, firstname, lastname, email FROM usertable WHERE userID = {p};", ref friendList);

			}

			showOverlap(ref timeBlocks, ref selectedFriendList);

			foreach (var t in friendList)
            {
                Button button = new Button();
                button.Name = t.StudentID;
                button.Text = t.firstName + " " + t.lastName;
                button.Location = new Point(10, friendPanel.Controls.Count * 25);
                button.Size = new Size(120,25);
                button.Font = new Font(button.Font.FontFamily, 12);
				button.BackColor = friendNOTSelected;
                button.ForeColor = Color.Black;
                button.Click += (s, e) => 
                {
					//Changes color of buttons to show election
					if (button.BackColor == friendNOTSelected)
					{

						selectedFriendList.Add(t.StudentID.ToString());
						button.BackColor = friendSelected;
					}
					else
					{
						selectedFriendList.Remove(t.StudentID.ToString());
						button.BackColor = friendNOTSelected;
					}
					showOverlap(ref timeBlocks, ref selectedFriendList);
                    
                };

                friendPanel.Controls.Add(button);
            }
        }

        private void ComparisonPage_Load(object sender, EventArgs e)
        {

        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
			this.Hide();
			transition.openFriendSeach();
			this.Close();
        }


		private void showOverlap(ref List<timeBlock> timeBlocks, ref List<string> friends)
		{
			foreach (Label s in this.Controls.OfType<Label>())
			{
				if (s.Name[3] == '1' || s.Name[3] == '2' || s.Name[3] == '3' || s.Name[3] == '4' || s.Name[3] == '5' 
					|| s.Name[3] == '6' || s.Name[3] == '7' || s.Name[3] == '8')
				{
					s.BackColor = buttonBackgroundColor;
				}
			}
			timeBlocks.Clear();

			foreach (var f in friends) { 
				MySQLFunctions.getTimeInfo($"SELECT startTime, day FROM timeblock WHERE userID = {f};", ref timeBlocks);

				foreach (var l in timeBlocks)
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
						this.Controls[combined].BackColor = color;
					}
					catch (ArgumentException k)
					{
						MessageBox.Show(k.Message);
					}
				}
			}
		}

		private void openScheduleView_Click(object sender, EventArgs e)
		{
			this.Hide();
			transition.openClassView();
			this.Close();
		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			userInfo.setCurrentUser(0);

			this.Hide();
			transition.openHomePage();
			this.Close();
		}
	}
}


