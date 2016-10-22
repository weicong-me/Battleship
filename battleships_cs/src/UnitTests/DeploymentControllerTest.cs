using System;
using SwinGameSDK;
using NUnit.Framework;
namespace MyGame
{
    [TestFixture()]
    public class EmptyClass
    {
        public EmptyClass ()
        {
        }
		
        [Test ()]
        public void TestOrientation ()
        {
            Ship sub = new Ship (ShipName.Submarine);
            Direction _currentdirection = new Direction();
            _currentdirection = Direction.LeftRight;
            sub.Deployed (Direction.LeftRight, 5, 5);
            Assert.IsTrue (sub.Direction == _currentdirection);
            //Assert.IsTrue (sub.Column == 6);
        }

        //[Test ()]
        //public void TestShotCount ()
        //{
        //    BattleShipsGame bsg = new BattleShipsGame ();
        //    Player Jeff = new Player (bsg);
        //    Ship sub = new Ship (ShipName.Submarine);
        //    sub.Deployed (Direction.LeftRight, 5, 5);
        //    //Jeff.Shoot (5, 5);
        //    Assert.IsTrue (Jeff.Shots == 1);
        //}

        [Test ()]
        public void TestShipPlacement ()
        {
            Ship sub = new Ship (ShipName.Submarine);
            sub.Deployed (Direction.LeftRight, 5, 5);
            Assert.IsTrue (sub.Row == 5);
        }

        [Test ()]
        public void TestDIfficulty ()
        {
            BattleShipsGame bsg = new BattleShipsGame ();
            GameController.SetDifficulty (AIOption.Easy);
            GameController.StartGame ();
            Assert.IsNull (AIOption.Easy);
        }
    }
}
