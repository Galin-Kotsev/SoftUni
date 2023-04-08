using NUnit.Framework;
using System;

namespace RobotFactory.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Factory NAME AND CAPACITY TEST
        [Test]
        public void FactoryName_Test()
        {
            Factory factory = new Factory("EON" , 10);

            Assert.AreEqual(factory.Name, "EON");
        }

        // Factory NAME AND CAPACITY TEST
        [Test]
        public void FactoryCapacity_Test()
        {
            Factory factory = new Factory("EON", 10);

            Assert.AreEqual(factory.Capacity, 10);
        }

        // Factory ADD ROBOT TO FACTORY
        [Test]
        public void FactoryAddRobotsCount_Test()
        {
            Factory factory = new Factory("EON", 1);
            Robot robot = new Robot("Terminator", 100 , 5);

            factory.Robots.Add(robot);

            Assert.AreEqual(factory.Robots.Count, 1);
        }

        // Factory SELL ROBOT
        [Test]
        public void FactorySellRobot_Test()
        {
            Factory factory = new Factory("EON", 1);
            Robot robot = new Robot("Terminator", 100, 5);
            Robot robot2 = new Robot("Terminator 2", 90, 5);

            factory.Robots.Add(robot);
            factory.Robots.Add(robot2);

            factory.SellRobot(90);

            Assert.AreEqual(factory.Robots.Count, 2);
        }

        [Test]
        public void FactorySellRobot2_Test()
        {
            Factory factory = new Factory("EON", 1);
            Robot robot = new Robot("Terminator", 100, 5);
            Robot robot2 = new Robot("Terminator 2", 90, 5);

            factory.Robots.Add(robot);
            factory.Robots.Add(robot2);

            Assert.AreEqual(factory.SellRobot(90), robot2);
        }



        // Factory Produce ROBOT
        [Test]
        public void FactoryProduce_Test()
        {
            Factory factory = new Factory("EON", 2);

            Robot robot = new Robot("Terminator", 100, 5);
            Robot robot2 = new Robot("Terminator 2", 90, 5);

            factory.Robots.Add(robot);
            factory.Robots.Add(robot2);


            Assert.AreEqual
                (factory.ProduceRobot("Terminator 3", 95, 5), $"The factory is unable to produce more robots for this production day!");

        }

        [Test]
        public void FactoryProduceOK_Test()
        {
            Factory factory = new Factory("EON", 3);

            Robot robot = new Robot("Terminator", 100, 5);
            Robot robot2 = new Robot("Terminator 2", 90, 5);

            factory.Robots.Add(robot);
            factory.Robots.Add(robot2);
            factory.ProduceRobot("Terminator 3", 95, 5);

            Assert.AreEqual
                (factory.Robots.Count, 3);

        }


            // ROBOT SUPPLEMENTS

            [Test]
        public void FactorySUPPLEMENTS_Test_OK()
        {
            Factory factory = new Factory("EON", 3);

            Assert.That("Supplement: ANANAS IS: 5", Is.EqualTo(factory.ProduceSupplement("ANANAS", 5)));

        }


        [Test]
        public void Upgrade_OK()
        {
            Factory factory = new Factory("EON", 3);

            Robot robot = new Robot("Terminator", 100, 5);

            Supplement supplement = new Supplement("BANAN", 5);


            Assert.IsTrue(factory.UpgradeRobot(robot, supplement));
        }

        [Test]
        public void Upgrade_OK2()
        {
            Factory factory = new Factory("EON", 3);

            Robot robot = new Robot("Terminator", 100, 5);

            Supplement supplement = new Supplement("BANAN", 5);
            factory.UpgradeRobot(robot, supplement);

            Assert.AreEqual(robot.Supplements.Count, 1);
        }

        [Test]
        public void Upgrade_Fail()
        {
            Factory factory = new Factory("EON", 3);

            Robot robot = new Robot("Terminator", 100, 5);

            Supplement supplement = new Supplement("BANAN", 3);


            Assert.IsFalse(factory.UpgradeRobot(robot, supplement));
        }


        [Test]
        public void RobotModel_Test()

        {
            Robot robot = new Robot("Terminator", 100, 5);

            Assert.AreEqual(robot.Model, "Terminator");
        }

        // Factory NAME AND CAPACITY TEST
        [Test]
        public void RobotPrice_Test()
        {
            Robot robot = new Robot("Terminator", 100, 5);

            Assert.AreEqual(robot.Price, 100);
        }

        [Test]
        public void RobotInterfaceStandard_Test()
        {
            Robot robot = new Robot("Terminator", 100, 5);

            Assert.AreEqual(robot.InterfaceStandard, 5);
        }
    }
}