using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;
using Restaurant;

namespace Tests
{

    [TestFixture]
    public class PositiveTests
    {
        static double testPrice = 12.32;
        static Drink testDrink;
        public Desert testDesert;

        [SetUp]
        public void BeforeTests()
        {
            double testPrice = 12.32;
            int[] testPriority = { 1, 2, 3, 4 };
            testDesert = new Desert(testPrice);

            testDrink = new Drink(testPrice);
        }

        [Test]
        public void TestPriority([Values(testDesert.Priority, 2, 3)] int actPriority, [Values("A", "B")] string s)
        {
            Assert.AreEqual(actPriority, testPriority[3]);
        }

        [TestMethod]
        public void TestDesertPrice([Values(testDesert.Price, 2, 3)] Dish testDish, [Values("A", "B")] string s)
        {
            Assert.AreEqual(testDesert.Price, testPrice);
        }
    }
}
}
