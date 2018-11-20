using System;
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

        public ComparisonPage()
        {
            InitializeComponent();

            /*
             * This code is for the friend view
             */


            var color = Color.Red;
            var friendList = new List<Student>();
			var friendIDs = new List<string>();
            var timeBlocks = new List<timeBlock>();


            MySQLFunctions.getInfo($"SELECT friendID FROM friendtable WHERE userID = {userInfo.getCurrentUser()};", ref friendIDs);

			foreach(var p in friendIDs)
			{
				MySQLFunctions.getFriendInfo($"SELECT userID, firstname, lastname, email FROM usertable WHERE userID = {p};", ref friendList);

			}

			foreach (var t in friendList)
            {
                Button button = new Button();
                button.Name = t.StudentID;
                button.Text = t.firstName + " " + t.lastName;
                button.Location = new Point(10, friendPanel.Controls.Count * 25);
                button.Size = new Size(120,25);
                button.Font = new Font(button.Font.FontFamily, 12);
                button.Click += (s, e) => 
                {
                    timeBlocks.Clear();
                    //mon1.BackColor = System.Drawing.Color.Red;
                    MySQLFunctions.getTimeInfo($"SELECT startTime, day FROM timeblock WHERE userID = {t.StudentID};", ref timeBlocks);
                    foreach(var l in timeBlocks)
                    {
                        string day ="", time ="", combined="";
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
                        } catch (ArgumentException k)
                        {
                            MessageBox.Show(k.Message);
                        }
                    }
                    
                };

                friendPanel.Controls.Add(button);
            }
        }

        private void ComparisonPage_Load(object sender, EventArgs e)
        {

        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            AddFriends addfreinds = new AddFriends();
            addfreinds.ShowDialog();
        }

    }
}
