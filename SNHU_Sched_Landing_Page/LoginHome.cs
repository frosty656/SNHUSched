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
	public partial class LoginHome : Form
	{
		public LoginHome()
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


        private void LoginHome_Load(object sender, EventArgs e)
        {
            string[] classList = new string[20];
            string classesString = "";

            MySQLFunctions.getInfo($"SELECT classID FROM timeblock WHERE userID LIKE {userInfo.getCurrentUser()};", ref classList);


            for (int i = 0; i < classList.Length; i++)
            {
                classesString += classList[i] + "\n";
            }

            ClassListLabel.Text = classesString;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
