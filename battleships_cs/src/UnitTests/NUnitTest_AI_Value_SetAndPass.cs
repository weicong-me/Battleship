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
	public class NUnitTest_AI_Value_SetAndPass
	{
		[Test()]
		public void TestCase()
		{
			GameController.StartGame ();
			//Set AI difficulty
			GameController.SetDifficulty (AIOption.Easy);
			AIOption expected = AIOption.Easy;
			AIOption actual = GameController._aiSetting;
			Assert.AreEqual (expected, actual);
		}
	}

	public class NUnitTest_AI_Value_SetAndPass_Medium
	{
		[Test ()]
		public void TestCase ()
		{
			GameController.StartGame ();
			//Set AI difficulty
			GameController.SetDifficulty (AIOption.Medium);
			AIOption expected = AIOption.Medium;
			AIOption actual = GameController._aiSetting;
			Assert.AreEqual (expected, actual);
		}
	}

	public class NUnitTest_AI_Value_SetAndPass_Hard
	{
		[Test ()]
		public void TestCase ()
		{
			GameController.StartGame ();
			//Set AI difficulty
			GameController.SetDifficulty (AIOption.Hard);
			AIOption expected = AIOption.Hard;
			AIOption actual = GameController._aiSetting;
			Assert.AreEqual (expected, actual);
		}
	}
}

