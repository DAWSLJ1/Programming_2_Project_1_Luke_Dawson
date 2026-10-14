namespace TaskFour
{
    [TestClass]
    public class WhaleTests
    {
        [TestMethod]
        public void Test_Set_Whale_Weight()
        {
            Whale whale = new Whale("Blue Whale", 150000, 26.9);

            // Write task 4, step 1 here
            Assert.Equals(150000, whale.AvgWeight);
        }

        [TestMethod]
        public void Test_Set_Length()
        {
            Whale whale = new Whale("Blue Whale", 150000, 26.9);

            // Write task 4, step 2 here
            Assert.AreEqual(26.9, whale.AvgLength);
        }

        [TestMethod]
        public void Test_Set_Name()
        {
            Whale whale = new Whale("Blue Whale", 150000, 26.9);

            // Write task 4, step 3 here
            Assert.AreSame("Blue Whale", whale.Name);
        }

        [TestMethod]
        public void Test_Krill()
        {
            Whale whale = new Whale("Blue Whale", 150000, 26.9);

            //write task 4, step 4 here
            whale.Krill();
            Assert.AreEqual(150000, whale.AvgWeight);
        }
    }
}
