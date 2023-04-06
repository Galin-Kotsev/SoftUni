using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        // Test Capacity
        
        [Test]
        public void CapaccityTest()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);

            shop.Add(phones);

            Assert.AreEqual(shop.Capacity, 3);
        }

        [Test]
        public void CapacityTest_Fail()
        {
            Shop shop;

            Assert.Throws<ArgumentException>(()=> new Shop(-1), "Invalid capacity.");
        }

        //Smartphones Count Test
        [Test]
        public void CountTest()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);
            Smartphone phones2 = new Smartphone("Sony2", 5000);
            Smartphone phones3 = new Smartphone("Sony3", 5000);

            shop.Add(phones);
            shop.Add(phones2);
            shop.Add(phones3);

            Assert.AreEqual(shop.Count, 3);
        }


        [Test]
        public void SmartPhoneAlreadyExistTest()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);
            Smartphone phones2 = new Smartphone("Sony2", 5000);
            Smartphone phones3 = new Smartphone("Sony2", 5000);

            shop.Add(phones);
            shop.Add(phones2);

            Assert.Throws<InvalidOperationException>(() 
                => shop.Add(phones3), $"The phone model {phones.ModelName} already exist.");
        }

        [Test]
        public void SmartPhoneCapacityMaxedOut()
        {
            Shop shop = new Shop(2);

            Smartphone phones = new Smartphone("Sony", 5000);
            Smartphone phones2 = new Smartphone("Sony2", 5000);
            Smartphone phones3 = new Smartphone("Sony3", 5000);

            shop.Add(phones);
            shop.Add(phones2);

            Assert.Throws<InvalidOperationException>(() => shop.Add(phones3), $"The shop is full.");
        }

        // SmartPhone Remove from PhoneList
        [Test]
        public void SmartPhoneRemoveTestDoestExist()
        {
            Shop shop = new Shop(2);

            Smartphone phones = new Smartphone("Sony", 5000);
            Smartphone phones2 = new Smartphone("Sony2", 5000);

            shop.Add(phones);
            shop.Add(phones2);

            Assert.Throws<InvalidOperationException>(() 
                => shop.Remove("Sony3"), $"The phone model {phones.ModelName} doesn't exist.");
        }

        [Test]
        public void SmartPhoneRemoveCountTest()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);
            Smartphone phones2 = new Smartphone("Sony2", 5000);
            Smartphone phones3 = new Smartphone("Sony3", 5000);

            shop.Add(phones);
            shop.Add(phones2);
            shop.Add(phones3);

            shop.Remove("Sony3");

            Assert.IsTrue( shop.Count == 2 );
        }

        //Phone Test

        [Test]
        public void SmartPhoneTestModelDoestExist()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);
            Smartphone phones2 = new Smartphone("Sony2", 5000);
            Smartphone phones3 = new Smartphone("Sony3", 5000);

            shop.Add(phones);
            shop.Add(phones2);
            shop.Add(phones3);

            Assert.Throws<InvalidOperationException>(() 
                => shop.TestPhone("Sony4", 5000), $"The phone model {phones.ModelName} doesn't exist.");
        }

        [Test]
        public void SmartPhoneTestBaterryLevelToLow()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);

            shop.Add(phones);

            phones.CurrentBateryCharge = 3000;

            Assert.Throws<InvalidOperationException>(()
                => shop.TestPhone("Sony", 5000), $"The phone model {phones.ModelName} is low on batery.");
        }

        //ChargePhone test
        [Test]
        public void SmartPhoneChargeBatteryTest_Fail()
        {
            Shop shop = new Shop(3);

            Smartphone phones = new Smartphone("Sony", 5000);

            shop.Add(phones);

            Assert.Throws<InvalidOperationException>(()
                => shop.ChargePhone("Sony2"), $"The phone model {phones.ModelName} doesn't exist.");
        }

        [Test]
        public void SmartPhoneChargeBatteryTest_Ok()
        {
            Shop shop = new Shop(1);

            Smartphone phones = new Smartphone("Sony", 3000);

            shop.Add(phones);

            shop.TestPhone("Sony" , 2000);

            Assert.AreEqual(phones.CurrentBateryCharge, 1000);
        }

        [Test]
        public void SmartPhoneChargeBatteryTest_MAX()
        {
            Shop shop = new Shop(1);

            Smartphone phones = new Smartphone("Sony", 5000);

            shop.Add(phones);
            shop.ChargePhone("Sony");


            Assert.AreEqual(phones.MaximumBatteryCharge , 5000);
        }
    }
}