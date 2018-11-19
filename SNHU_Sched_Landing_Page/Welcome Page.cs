using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SNHU_Sched_Landing_Page
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.AutoScroll = true;

        //    string[] list = Directory.GetFiles(@"C:\pictures", "*.jpg");
        //    PictureBox[] picturebox = new PictureBox[list.Length];
        //    int y = 0;
        //    for (int index = 0; index < picturebox.Length; index++)
        //    {
        //        this.Controls.Add(picturebox[index]);
        //        // Following three lines set the images(picture boxes) locations
        //        if (index % 3 == 0)
        //            y = y + 150; // 3 images per rows, first image will be at (20,150)
        //        picturebox[index].Location = new Point(index * 120 + 20, y);

        //        picturebox[index].Size = new Size(100, 120);
        //        picturebox[index].Image = Image.FromFile(list[index]);
        //    }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (usernameInput.Text != "" && passwordInput.Text != "")
			{
				if (MySQLFunctions.GenerateHash(passwordInput.Text, usernameInput.Text) == MySQLFunctions.getPass(usernameInput.Text))
				{
                    userInfo.setCurrentUser(MySQLFunctions.getUserIDFromEmail(usernameInput.Text));
					LoginHome loginHome = new LoginHome();
					loginHome.ShowDialog();
				}
				else
				{
					MessageBox.Show("Email and password do not match");
				}
			}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            NewAccount1 newAccount = new NewAccount1();
            newAccount.ShowDialog();
        }

		private void DeleteMe_Click(object sender, EventArgs e)
		{
			//AddFriends scheduleInput = new AddFriends();
			//scheduleInput.ShowDialog();
		}
	}
}
