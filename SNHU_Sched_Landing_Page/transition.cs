using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNHU_Sched_Landing_Page
{
	class transition
	{
		public static void openFriendSeach()
		{
			AddFriends page = new AddFriends();
			page.ShowDialog();
		}
		public static void openComparePage()
		{
			ComparisonPage page = new ComparisonPage();
			page.ShowDialog();
		}
		public static void openClassView()
		{
			LoginHome page = new LoginHome();
			page.ShowDialog();
		}
		public static void openNewAccount()
		{
			NewAccount1 page = new NewAccount1();
			page.ShowDialog();
		}
		public static void openScheduleInput()
		{
			Schedule_Input2 page = new Schedule_Input2();
			page.ShowDialog();
		}
		public static void openHomePage()
		{
			HomePage page = new HomePage();
			page.ShowDialog();
		}

	}
}
