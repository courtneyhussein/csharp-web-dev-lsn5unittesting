using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;
using System.Diagnostics;

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
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            //Console.WriteLine(test_car.GasTankLevel);
            test_car.Drive(50000);
            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(1);
            Assert.Fail("Gas is overflowing everywherrrre! JK can't add that much gas.");
        }



    }
}
