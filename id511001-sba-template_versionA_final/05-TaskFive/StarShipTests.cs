namespace TaskFive
{
    [TestClass]
    public class StarShipTests
    {
        // Bug 1
        [TestMethod]
        public void Test_TripleVolume()
        {
            StarShip starShip = new StarShip("Millenium Falcon", 5400, true);
            starShip.TripleVolume();
            Assert.AreEqual(16200, starShip.Volume);
        }

        // Bug 2
        [TestMethod]
        public void Test_Operating()
        {
            StarShip starShip = new StarShip("Millenium Falcon", 5400, true);
            starShip.ActivateShip();
            Assert.IsTrue(starShip.IsOperating);
        }

        // Bug 3
        [TestMethod]
        public void Test_GetInfo()
        {
            StarShip starShip = new StarShip("Millenium Falcon", 5400, true);
            string result = starShip.GetInfo();
            StringAssert.Contains(result, "True");
        }

        // Bug 4
        [TestMethod]
        public void Test_ResetVolume()
        {
            StarShip starShip = new StarShip("Millenium Falcon", 5400, true);
            starShip.ResetVolume();
            Assert.AreEqual(0, starShip.Volume);
        }

        // Bug 5
        [TestMethod]
        public void Test_IsLarge_Returns_false()
        {
            StarShip starShip = new StarShip("Millenium Falcon", 5400, true);
            Assert.IsFalse(starShip.IsLarge());
        }
    }
}
