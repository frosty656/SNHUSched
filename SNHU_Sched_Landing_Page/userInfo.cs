using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNHU_Sched_Landing_Page
{
    class userInfo
    {
		public static int currentUserID;

		public static string userEmail;

        public static void setCurrentUser(int userID)
        {
            currentUserID = userID;
        }

        public static int getCurrentUser()
        {
            return currentUserID;
        }

		public static string getCurrentEmail()
		{
			return userEmail;
		}

		public static void setCurrentEmail(string email)
		{
			userEmail = email;
		}

    }
}
