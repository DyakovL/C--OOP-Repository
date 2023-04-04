using System.Linq;

namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;

    [TestFixture]
    public class CarManagerTests
    {
        [SetUp]
        public void Setup()
        {
            Car car = new Car("VW", "Golf", 7.3, 80);
        }

        [TearDown]
        public void TearDown()
        {
            Car car = null;
        }

        [Test]
        public void CreateCar()
        {
            Car car = new Car("VW", "Golf", 7.3, 80);

            Assert.AreEqual(car.Make, "VW");
            Assert.AreEqual(car.Model, "Golf");
            Assert.That(car.FuelConsumption, Is.EqualTo(7.3));
            Assert.That(car.FuelCapacity, Is.EqualTo(80));
        }

        [TestCase(null)]
        [TestCase("")]
        public void CarMakeNullOrEmptyException(string make)
        {
            ArgumentException message =
                Assert.Throws<ArgumentException>(() =>
                {
                    Car car = new Car(make, "Golf", 7.3, 80);
                });

            Assert.That(message.Message, Is.EqualTo("Make cannot be null or empty!"));
        }


        [TestCase(null)]
        [TestCase("")]
        public void CarModelNullOrEmptyException(string model)
        {
            ArgumentException message =
                Assert.Throws<ArgumentException>(() =>
                {
                    Car car = new Car("VW", model, 7.3, 80);
                });

            Assert.That(message.Message, Is.EqualTo("Model cannot be null or empty!"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CarFuelConsumptionIsZeroOrLessThanZeroException(double fuelConsumption)
        {
            ArgumentException message =
                Assert.Throws<ArgumentException>(() =>
                {
                    Car car = new Car("VW", "Golf", fuelConsumption, 80);
                });

            Assert.That(message.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CarFuelCapacityIsZeroOrLessThanZeroException(double fuelCapacity)
        {
            ArgumentException message =
                Assert.Throws<ArgumentException>(() =>
                {
                    Car car = new Car("VW", "Golf", 7.3, fuelCapacity);
                });

            Assert.That(message.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-0.357)]
        public void CarRefuelAmountIsZeroOrLessThanZeroException(double fuelAmount)
        {

            Car car = new Car("VW", "Golf", 7.3, 90);
            

            ArgumentException message =
                Assert.Throws<ArgumentException>(() => car.Refuel(fuelAmount));
            

            Assert.That(message.Message, Is.EqualTo("Fuel amount cannot be zero or negative!"));
        }
    }
}