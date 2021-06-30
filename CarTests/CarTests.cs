using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests

    {
        Car test_car;

        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(10, 10, .001);
        //    Assert.AreEqual(10, 11, .001);
        //    Assert.AreEqual(10, 10.0009, .001);
        //}


        //TODO: constructor sets gasTankLevel properly

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50, 4);
        }

        [TestMethod]
        public void TestInitialGasTank()
        {
            
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        public void TestNumberOfWheels()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50, 4);
            Assert.AreEqual(4, test_car.NumberOfWheels);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
