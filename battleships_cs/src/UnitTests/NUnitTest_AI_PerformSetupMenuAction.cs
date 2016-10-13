using NUnit.Framework;
using System;
namespace Application
{
	/*
	 * private const int SETUP_MENU_EASY_BUTTON = 0;
	 * private const int SETUP_MENU_MEDIUM_BUTTON = 1;
	 * private const int SETUP_MENU_HARD_BUTTON = 2;
	*/
	[TestFixture()]
	public class NUnitTest_PerformSetupMenuAction_Easy
	{
		[Test()]
		public void TestCase()
		{
			GameController.StartGame ();
			//Click EASY in the SETUP Menu
			MenuController.PerformSetupMenuAction (0);
			//The _aiSetting value in the GameController
			AIOption actual = AIOption.Easy;
			AIOption expected = GameController._aiSetting;
			Assert.AreEqual (expected, actual);
		}
	}

	public class NUnitTest_PerformSetupMenuAction_Medium
	{
		[Test ()]
		public void TestCase ()
		{
			GameController.StartGame ();
			//Click MEDIUM in the SETUP Menu
			MenuController.PerformSetupMenuAction (1);
			//The _aiSetting value in the GameController
			AIOption actual = AIOption.Medium;
			AIOption expected = GameController._aiSetting;
			Assert.AreEqual (expected, actual);
		}
	}

	public class NUnitTest_PerformSetupMenuAction_Hard
	{
		[Test ()]
		public void TestCase ()
		{
			GameController.StartGame ();
			//Click HARD in the SETUP menu
			MenuController.PerformSetupMenuAction (2);
			//The _aiSetting value in the GameController
			AIOption actual = AIOption.Hard;
			AIOption expected = GameController._aiSetting;
			Assert.AreEqual (expected, actual);
		}
	}
}

