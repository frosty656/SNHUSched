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
	public partial class Schedule_Input : Form
	{

		string classStartTime;

		public Schedule_Input()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ClassStartTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			classStartTime = ClassStartTime.Text;
		}

		private void AddAnotherClass_Click(object sender, EventArgs e)
		{
			uploadClass(classStartTime, ClassID.Text);

			ClassID.Text = "";
			ClassStartTime.SelectedIndex = -1;
		}

		private void Done_Click(object sender, EventArgs e)
		{
			uploadClass(classStartTime, ClassID.Text);

		}

		private void uploadClass(string time, string classID)
		{
				string connectionString = null;
				MySqlConnection cnn;
				connectionString = "server=localhost;database=jacobdb;uid=root;pwd=*/x-y7UG_cq&;";
				cnn = new MySqlConnection(connectionString);

				try
				{
					cnn.Open();
					MySqlCommand cmd = new MySqlCommand();
					cmd.Connection = cnn;
					cmd.CommandText = $"INSERT INTO timeblock VALUES ('1', '{classID}', '{time}', UUID())";
					cmd.ExecuteNonQuery();

				}
				catch (MySqlException ex)
				{
				Console.WriteLine(ex);
				}
				cnn.Close();
		}
	}

}
