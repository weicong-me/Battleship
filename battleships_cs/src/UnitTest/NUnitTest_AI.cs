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
			AIOption expected__aiSetting = AIOption.Medium;
			AIOption actual__aiSetting = GameController._aiSetting;
			Assert.AreEqual (expected__aiSetting, actual__aiSetting);
		}
	}
}

