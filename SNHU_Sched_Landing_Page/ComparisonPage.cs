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
    public partial class ComparisonPage : Form
    {

        string[] studentIDs = new string[200];
        string[] firstNames = new string[200];
        string[] lastNames = new string[200];
        string[] friendsList = new string[200];
        
        private class Student
        {
            public Student() { }

            public string StudentID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public ComparisonPage()
        {
            InitializeComponent();

            MySQLFunctions.getInfo($"SELECT friendID FROM friendtable WHERE userID = {userInfo.getCurrentUser()};", ref friendsList);

            for (int i = 0; i < friendsList.Length; i++)
            {
                if (friendsList[i] == null) { break; }
                getPersonInfo(friendsList[i]);
            }

            var studentList = new List<Student>();

            for (int i = 0; i < studentIDs.Length; i++)
            {
                if (studentIDs[i] == null) { MessageBox.Show("BREAKING"); break; }
                studentList.Add(new Student() { StudentID = studentIDs[i], firstName = firstNames[i], lastName = lastNames[i] });
            }

 

            foreach (var t in studentList)
            {
                Button button = new Button();
                button.Name = t.StudentID;
                button.Text = t.firstName + " " + t.lastName;
                button.Location = new Point(10, friendPanel.Controls.Count * 25);
                button.Size = new Size(120,25);
                button.Font = new Font(button.Font.FontFamily, 12);
                button.Click += (s, e) => 
                {
                    MessageBox.Show(t.firstName + " " + t.lastName);
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

        void getPersonInfo(string friendID)

        { 
            MySQLFunctions.getInfo($"SELECT userID FROM usertable WHERE userID = {friendID};", ref studentIDs);
            MySQLFunctions.getInfo($"SELECT firstname FROM usertable WHERE userID = {friendID};", ref firstNames);
            MySQLFunctions.getInfo($"SELECT lastname FROM usertable WHERE userID = {friendID};", ref lastNames);

        }
    }
}
