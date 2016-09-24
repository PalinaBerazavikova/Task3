using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;

namespace UnitTests
{
    [TestClass]
    public class PositiveTests
    {
        private static double testPrice = 12.32;
        private static int[] testPriority = { 1,2,3,4};
        Desert testDesert = new Desert(testPrice);
        Drink testDrink = new Drink(testPrice);



        [TestMethod]
        public void TestPriority()
        {
            Assert.AreEqual(testDesert.Priority, testPriority[3]);
        }

        [TestMethod]
        public void TestDesertPrice()
        {
            Assert.AreEqual(testDesert.Price, testPrice);
        }
    }
}
