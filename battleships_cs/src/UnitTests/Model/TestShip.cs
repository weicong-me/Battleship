using NUnit.Framework;
using System;

namespace MyGame
{
	[TestFixture ()]
	public class TestShip
	{
		Ship testShip;
		[SetUp()]
		public void init()
		{
			testShip = new Ship (ShipName.Submarine);
		}

		[Test ()]
		public void TestHit ()
		{
			testShip.Hit ();
			Assert.IsTrue (testShip.Hits == 1);
		}

		[Test ()]
		public void TestName ()
		{
			Assert.IsTrue (testShip.Name == "Submarine");
		}


	}
}

