using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;

namespace SNHU_Sched_Landing_Page
{
	public partial class SQLCommands : Component
	{
		public SQLCommands()
		{
			InitializeComponent();
		}

		public SQLCommands(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		private void NewUser(int uniqueID, string firstName, string lastName, string email, string password)
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
				cmd.CommandText = $"INSERT INTO usertable VALUES ('{uniqueID}', '{firstName}', '{lastName}', '{email}', '{password}')";
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
	}
}
