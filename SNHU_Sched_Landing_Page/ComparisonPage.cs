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
        string[] friendArray = new string[200];
        
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

            MySQLFunctions.getInfo($"SELECT friendID FROM friendtable WHERE userID = {userInfo.getCurrentUser()};", ref friendArray);

            var friendList = new List<Student>();

            for (int i = 0; i < friendArray.Length; i++)
            {
                if (friendArray[i] == null) { break; }

                string connectionString = null;
                MySqlConnection cnn;
                connectionString = $"server=localhost;database=jacobdb;uid=root;pwd={MySQLFunctions.MYSQLPassword};";
                cnn = new MySqlConnection(connectionString);

                string query = $"SELECT userID, firstname, lastname, email FROM usertable WHERE userID = {friendArray[i]};";

                MySqlCommand cmd = new MySqlCommand(query, cnn);

                MySqlDataReader dr;

                cnn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var userID = dr["userID"];
                    var firstname = dr["firstname"];
                    var lastname = dr["lastname"];
                    var email = dr["email"];

                    friendList.Add(new Student() { StudentID = userID.ToString(), firstName = firstname.ToString(), lastName = lastname.ToString() });
                }

                dr.Close();
                cnn.Close();
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

    }
}
