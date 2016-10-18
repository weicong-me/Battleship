using System;
using NUnit.Framework;
namespace MyGame
{
	[TestFixture]
	public class TestHits
	{
		[Test]
		public void TestHitTileNoShip ()
		{
			BattleShipsGame battle = new BattleShipsGame ();
			Player test = new Player (battle);
			AttackResult actual = test.PlayerGrid.HitTile (0, 0);

			Assert.AreEqual ("missed", actual.Text, "should return as 'missed' ");
		}
		[Test]
		public void TestHitTileHitShip () 
		{
			BattleShipsGame battle = new BattleShipsGame ();
			Player test = new Player (battle);

			test.PlayerGrid.MoveShip (0, 0, ShipName.Submarine, Direction.LeftRight);

			AttackResult actual = test.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("hit something!", actual.Text, "should return 'hit something!'");
			
		}

		[Test]
		public void TestHitTileDestroyShip ()
		{
			BattleShipsGame battle = new BattleShipsGame ();
			Player test = new Player (battle);

			test.PlayerGrid.MoveShip (0, 0, ShipName.Tug, Direction.LeftRight);

			AttackResult actual = test.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("destroyed the enemy's", actual.Text, "should return destroyed the enemy's ");

		}
	}
}
