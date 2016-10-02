using NUnit.Framework;
using System;
using System.IO;

namespace MyGame
{
	[TestFixture ()]
	public class ResourcesTests
	{
		[Test ()]
		public void TestResourcesDirectory ()
		{
			Assert.IsTrue (Directory.Exists ("Resources"));
		}

		[Test ()]
		public void TestResourcesHighscores ()
		{
			Assert.IsTrue (File.Exists ("Resources/highscores.txt"));
		}

		[Test ()]
		public void TestResourcesDeploy ()
		{
			Assert.IsTrue (File.Exists ("Resources/images/deploy.jpg"));
		}
	}
}

