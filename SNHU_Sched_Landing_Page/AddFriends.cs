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
    public partial class AddFriends : Form
    {
        public AddFriends()
        {
            InitializeComponent();
            
        }
        int counter = 0;

        //
        // MAKE EVERYTHING USE LISTS ARRAYS ARE OVERWRITING EACHOTHER
        //

        private class Student
        {
            public Student() { }

            public string StudentID { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsPanel.Controls.Clear();
            var studentList = new List<Student>();

            var studentIDs = new List<string>();

            studentList.Clear();


            MySQLFunctions.getInfo("SELECT userID FROM usertable;", ref studentIDs);

            foreach( var p in studentIDs)
            {
                string connectionString = null;
                MySqlConnection cnn;
                connectionString = $"server=localhost;database=jacobdb;uid=root;pwd={MySQLFunctions.MYSQLPassword};";
                cnn = new MySqlConnection(connectionString);

                string query = $"SELECT userID, firstname, lastname, email FROM usertable WHERE userID = {p};";

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

                    studentList.Add(new Student() { StudentID = userID.ToString(), firstName = firstname.ToString(), lastName = lastname.ToString(), email = email.ToString() });
                }

                dr.Close();
                cnn.Close();
            }


            //Filter the list
            if (firstnameSearch.Text != "")
            {
                studentList = studentList.FindAll(s => s.firstName.Equals(firstnameSearch.Text));
            }
            if (lastnameSearch.Text != "")
            {
                studentList = studentList.FindAll(s => s.lastName.Equals(lastnameSearch.Text));
            }
            if (emailSearch.Text != "")
            {
                studentList = studentList.FindAll(s => s.email.Equals(emailSearch.Text));
            }


            int j = 0;
            foreach (var p in studentList)
            {
                Button btn = new Button();
                btn.Name = p.StudentID;
                btn.Text = "";
                btn.Size = new Size(20,20);
                btn.Location = new Point(10, j * 25 + 5);
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.Red;
                btn.Click += new EventHandler(this.MyButtonHandler);
                resultsPanel.Controls.Add(btn);
                counter++;

                //Show names
                Label lbl = new Label();
                lbl.Text = p.firstName + " " + p.lastName;
                lbl.Location = new Point(400, j * 25); //here is the location of the box
                lbl.Size = new Size(400,30);//here is the size of the box
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                resultsPanel.Controls.Add(lbl);

                //Show emails
                Label lbl2 = new Label();
                lbl2.Text = p.email;
                lbl2.Location = new Point(50, j * 25); //here is the location of the box
                lbl2.Size = new Size(400, 30); //here is the size of the box
                lbl2.TextAlign = ContentAlignment.MiddleCenter;
                resultsPanel.Controls.Add(lbl2);
                j++;
            }
           
        }

        void MyButtonHandler(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            

            if (DuplicateFriends(userInfo.getCurrentUser().ToString(), btn.Name))
            {
                bool success = true;
                try
                {
                    MySQLFunctions.SQLCommand($"INSERT INTO friendtable VALUES ('{userInfo.getCurrentUser()}', '{btn.Name}')");
                }
                catch
                {
                    success = false;
                }

                if (success)
                {
                    MessageBox.Show("Friend Added");
                }
            }
        }

        private bool DuplicateFriends(string userID, string friendID)
        {
            var test = new List<string>();

            MySQLFunctions.getInfo($"SELECT * FROM friendtable WHERE userID = {userID} AND friendID = {friendID}", ref test);

            if (friendID == userID)
            {
                MessageBox.Show("You cannot be friends with yourself");
                return false;
            }
            if (test.Count == 0)
            {
                return true;
            }

            MessageBox.Show("This matching already exists");
            return false;
        }

		private void backButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			transition.openComparePage();
			this.Close();
		}
	} 
}
