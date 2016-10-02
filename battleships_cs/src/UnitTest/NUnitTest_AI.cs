using NUnit.Framework;
using System;
namespace Application
{
	[TestFixture()]
	public class NUnitTest_AI
	{
		[Test()]
		public void TestCase()
		{
			GameController.StartGame ();

			AIOption expected__aiSetting_default = AIOption.Easy;
			AIOption actual__aiSetting_default = GameController._aiSetting;
			Assert.AreEqual (expected__aiSetting_default, actual__aiSetting_default);


			GameController.SetDifficulty (AIOption.Medium);
			AIOption expected__aiSetting_M = AIOption.Medium;
			AIOption actual__aiSetting_M = GameController._aiSetting;
			Assert.AreEqual (expected__aiSetting_M, actual__aiSetting_M);

			GameController.SetDifficulty (AIOption.Hard);
			AIOption expected__aiSetting_H = AIOption.Hard;
			AIOption actual__aiSetting_H = GameController._aiSetting;
			Assert.AreEqual (expected__aiSetting_H, actual__aiSetting_H);
		}
	}
}

