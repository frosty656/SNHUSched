using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNHU_Sched_Landing_Page
{
    class userInfo
    {
        private static int currentUserID;

        public static void setCurrentUser(int userID)
        {
            currentUserID = userID;
        }

        public static int getCurrentUser()
        {
            return currentUserID;
        }
    }
}
