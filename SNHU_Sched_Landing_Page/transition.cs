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
			FriendSearch page = new FriendSearch();
			page.ShowDialog();
		}
		public static void openComparePage()
		{
			ComparisonPage page = new ComparisonPage();
			page.ShowDialog();
		}
		public static void openClassView()
		{
			ClassInformation page = new ClassInformation();
			page.ShowDialog();
		}
		public static void openNewAccount()
		{
			CreateNewUser page = new CreateNewUser();
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
