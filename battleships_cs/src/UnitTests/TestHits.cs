﻿using System;
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

			//moving ships into invalid positions and making sure they are off the grid

			try { test.PlayerGrid.MoveShip (10, 0, ShipName.Tug, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 1, ShipName.Submarine, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 2, ShipName.Destroyer, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 3, ShipName.Battleship, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 4, ShipName.AircraftCarrier, Direction.LeftRight); } catch (Exception ex) { }


			AttackResult actual = test.PlayerGrid.HitTile (0, 0);


			Assert.AreEqual ("missed", actual.Text, "should return as 'missed' ");
		}
		[Test]
		public void TestHitTileHitShip () 
		{
			BattleShipsGame battle = new BattleShipsGame ();
			Player test = new Player (battle);

			//moving ships into invalid positions and making sure they are off the grid

			try { test.PlayerGrid.MoveShip (10, 0, ShipName.Tug, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 1, ShipName.Submarine, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 2, ShipName.Destroyer, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 3, ShipName.Battleship, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 4, ShipName.AircraftCarrier, Direction.LeftRight); } catch (Exception ex) { }


			try { test.PlayerGrid.MoveShip (0, 0, ShipName.Submarine, Direction.LeftRight); } catch (Exception ex){ }

			AttackResult actual = test.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("hit something!", actual.Text, "should return 'hit something!'");
			
		}

		[Test]
		public void TestHitTileDestroyShip ()
		{
			BattleShipsGame battle = new BattleShipsGame ();
			Player test = new Player (battle);


			//moving ships into invalid positions and making sure they are off the grid

			try { test.PlayerGrid.MoveShip (10, 1, ShipName.Submarine, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 2, ShipName.Destroyer, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 3, ShipName.Battleship, Direction.LeftRight); } catch (Exception ex) { }
			try { test.PlayerGrid.MoveShip (10, 4, ShipName.AircraftCarrier, Direction.LeftRight); } catch (Exception ex) { }


			test.PlayerGrid.MoveShip (0, 0, ShipName.Tug, Direction.LeftRight);

			AttackResult actual = test.PlayerGrid.HitTile (0, 0);
			Assert.AreEqual ("destroyed the enemy's", actual.Text, "should return destroyed the enemy's ");

		}
	}
}
