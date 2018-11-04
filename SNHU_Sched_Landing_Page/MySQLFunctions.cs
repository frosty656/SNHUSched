using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using System.Windows.Forms;

namespace SNHU_Sched_Landing_Page
{
	public static class MySQLFunctions
    {
        const string MYSQLPassword = "beach02";

		public static void SQLCommand(string command)
		{
			string connectionString = null;
			MySqlConnection cnn;
			connectionString = $"server=localhost;database=jacobdb;uid=root;pwd={MYSQLPassword};";
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
                Console.WriteLine(ex.Message);

				MySqlErrorMessage(ex.Number);

			}
			cnn.Close();
		}

		public static void MySqlErrorMessage(int errorNum)
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

		public static string GenerateHash(string value, string salt)
		{
			byte[] data = System.Text.Encoding.ASCII.GetBytes(salt + value);
			data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
			return Convert.ToBase64String(data);
		}

		public static string getPass(string email)
		{

			string connectionString = null;
			MySqlConnection cnn;
            connectionString = $"server=localhost;database=jacobdb;uid=root;pwd={MYSQLPassword};";
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

            dr.Close();
            cnn.Close();


			return storedPass;
		}

        public static void getInfo(string searchCommand, ref string[] array)
        {

            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=jacobdb;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = searchCommand;

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();


            int tracker = 0;

            while (dr.Read())
            {
                array[tracker] = dr.GetString(0);
                tracker++;
            }

            dr.Close();
            cnn.Close();

        }

        public static int getUserIDFromEmail(string email)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = $"server=localhost;database=jacobdb;uid=root;pwd={MYSQLPassword};";
            cnn = new MySqlConnection(connectionString);

            string query = $"SELECT userID FROM usertable WHERE email LIKE '{email}';";

            MySqlCommand cmd = new MySqlCommand(query, cnn);

            MySqlDataReader dr;

            cnn.Open();
            dr = cmd.ExecuteReader();

            string userID = string.Empty;


            while (dr.Read())
            {
                userID = dr.GetString(0);
                Console.WriteLine(userID);
            }

            dr.Close();
            cnn.Close();


            return Convert.ToInt32(userID);
        }

	}
}
