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
using MySql.Data.MySqlClient;
using MySql;


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
				if (GenerateHash(passwordInput.Text, usernameInput.Text) == getPass(usernameInput.Text))
				{
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

		private void SQLCommand(string command)
		{
			string connectionString = null;
			MySqlConnection cnn;
			connectionString = "server=localhost;database=jacobdb;uid=root;pwd=1pl4ym1d;";
			cnn = new MySqlConnection(connectionString);

			try
			{
				cnn.Open();
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = cnn;
				cmd.CommandText = command;
				cmd.ExecuteNonQuery();
			}
			catch (MySqlException ex)
			{
				MySqlErrorMessage(ex.Number);

			}
		}

		private void MySqlErrorMessage(int errorNum)
		{
			switch (errorNum)
			{
				case 1062:
					MessageBox.Show("This email or ID is already in use");
					break;
				default:
					MessageBox.Show("There was an unknown error");
					break;
			}

		}

		private static string GenerateHash(string value, string salt)
		{
			byte[] data = System.Text.Encoding.ASCII.GetBytes(salt + value);
			data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
			return Convert.ToBase64String(data);
		}

		private string getPass(string email)
		{

			string connectionString = null;
			MySqlConnection cnn;
			connectionString = "server=localhost;database=jacobdb;uid=root;pwd=*/x-y7UG_cq&;";
			cnn = new MySqlConnection(connectionString);

			string query = $"SELECT password FROM usertable WHERE email LIKE '{email}';";

			MySqlCommand cmd = new MySqlCommand(query, cnn);

			MySqlDataReader dr;

			cnn.Open();
			dr = cmd.ExecuteReader();

			string storedPass = string.Empty;

			while (dr.Read())
			{
				storedPass = dr.GetString(0);
				Console.WriteLine(storedPass);
			}
			cnn.Close();

			return storedPass;
		}

		private void DeleteMe_Click(object sender, EventArgs e)
		{
			Schedule_Input scheduleInput = new Schedule_Input();
			scheduleInput.ShowDialog();
		}
	}
}
