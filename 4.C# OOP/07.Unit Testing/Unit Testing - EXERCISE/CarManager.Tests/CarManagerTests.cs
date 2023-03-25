namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        // Car Create Test--------------------------------------------------------------------
        [Test]
        public void CarCreateNullTest()
        {
            Car car = new Car("Vw", "Golf", 5, 45);
            Assert.IsNotNull(car);
        }

        // MAKE TEST--------------------------------------------------------------------------
        [Test]
        public void CarConstructorMakeTest_True()
        {
            Car car = new Car("VW","GOLF", 3 ,30);

            Assert.AreEqual(car.Make, "VW");
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CarMakeCantBeNullOrEmpy(string make)
        {
            Car car;

            Assert.Throws<ArgumentException>(()=> 
            car = new Car(make, "GOLF", 3, 30), "Make cannot be null or empty!");
        }

        // MODEL TEST-------------------------------------------------------------------------

        [Test]
        public void CarConstructorModelTest_True()
        {
            Car car = new Car("VW", "GOLF", 3, 30);

            Assert.AreEqual(car.Model, "GOLF");
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void CarModelCantBeNullOrEmpy(string model)
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            car = new Car("VW", model, 3, 30), "Model cannot be null or empty!");
        }

        // FUELCONSUMPTION TEST---------------------------------------------------------------

        [Test]
        public void CarConstructorConsumptionTest_True()
        {
            Car car = new Car("VW", "GOLF", 3, 30);

            Assert.AreEqual(car.FuelConsumption, 3);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarConstructorConsumptionIsNegativeOrZero(double fuelConsumption)
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            car = new Car("VW", "GOLF", fuelConsumption, 30), "Fuel consumption cannot be zero or negative!");
        }

        // FUELAMOUNT TEST----------------------------------------------------------------------

        [Test]
        public void CarConstructorFuelAmountTest_True()
        {
            Car car = new Car("VW", "GOLF", 3, 30);

            Assert.AreEqual(car.FuelAmount, 0);
        }

        // FUELCAPACITY TEST---------------------------------------------------------------------

        [Test]
        public void CarConstructorCapacityTest_True()
        {
            Car car = new Car("VW", "GOLF", 3, 30);

            Assert.AreEqual(car.FuelCapacity, 30);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarConstructorCapacityTestZeroOrNegative(double capacity)
        {
            Car car;

            Assert.Throws<ArgumentException>(() =>
            car = new Car("VW", "GOLF", 3, capacity), "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        public void FuelCapacityOverFillCheckTest()
        {
            Car car = new Car("VW", "GOLF", 3, 30);

            car.Refuel(50);

            Assert.AreEqual(car.FuelCapacity, 30);
        }

        // REFUEL METHOD TEST--------------------------------------------------------------------

        [Test]
        public void CarRefuelTest_True()
        {
            Car car = new Car("VW", "GOLF", 3, 40);

            car.Refuel(1);

            Assert.AreEqual(car.FuelAmount, 1);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CarRefuelZeroOrNegative(double refuel)
        {
            Car car = new Car("VW", "GOLF", 3, 30);

            Assert.Throws<ArgumentException>(() =>
            car.Refuel(refuel), "Fuel amount cannot be zero or negative!");
        }

        // DRIVE METHOD TEST------------------------------------------------------------------------

        [Test]
        public void CarDriveTestIfFuelMore()
        {
            Car car = new Car("VW", "GOLF", 9, 20);

            car.Refuel(10);
            car.Drive(100);

            Assert.AreEqual(car.FuelAmount, 1);
        }

        public void CarDriveTestIfFuelEqual()
        {
            Car car = new Car("VW", "GOLF", 10, 20);

            car.Refuel(10);
            car.Drive(100);

            Assert.AreEqual(car.FuelAmount, 10);
        }

        [Test]
        [TestCase(100)]
        [TestCase(110)]
        public void CarDriveTestIfFuelLess(double distance)
        {
            Car car = new Car("VW", "GOLF", 10, 20);

            car.Refuel(9);

            Assert.Throws<InvalidOperationException>(() =>
            car.Drive(distance), "You don't have enough fuel to drive!");
        }

    }
}