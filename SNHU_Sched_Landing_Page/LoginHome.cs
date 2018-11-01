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
			cnn.Close();
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

        private void LoginHome_Load(object sender, EventArgs e)
        {

        }
    }
}
