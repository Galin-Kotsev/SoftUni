using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            //Planet Name Test
            [Test] 
            public void PlanetNameTest()
            { 
                Planet planet = new Planet("Zemq", 10); 
            
                Assert.AreSame("Zemq", planet.Name);
            }

            [Test]
            [TestCase("")]
            [TestCase(null)]
            public void PlanetNameTestIsNullOrEmpty(string name)
            {
                Planet planet;

                Assert.Throws<ArgumentException>(() =>
                planet = new Planet(name, 10), "Invalid planet Name");
            }

            // Planet Budget Test
            [Test]
            public void PlanetBudgerTest()
            {
                Planet planet = new Planet("Zemq", 11.1);

                Assert.AreEqual(11.1, planet.Budget);
            }

            [Test]
            public void PlanetBudgetTestCantBeBelowZero()
            {
                Planet planet;

                Assert.Throws<ArgumentException>(() =>
                planet = new Planet("Zemq", -1), "Budget cannot drop below Zero!");
            }

            // Profit Method test
            [Test]
            public void PlanetProfitMethodTest()
            {
                Planet planet = new Planet("Zemq", 12);

                planet.Profit(2);

                Assert.AreEqual(planet.Budget,14);
            }

            //Spend Method Test
            [Test]
            public void PlanetSpendFundsMethodTest_OK()
            {
                Planet planet = new Planet("Zemq", 12);

                planet.SpendFunds(2);

                Assert.AreEqual(planet.Budget, 10);
            }

            [Test]
            public void PlanetSpendFundsMethodTest_Fail()
            {
                Planet planet = new Planet("Zemq", 12);

                //planet.SpendFunds(14);

                Assert.Throws<InvalidOperationException>(() =>
             planet.SpendFunds(14), $"Not enough funds to finalize the deal.");
            }

            // Add Weapon Method

            [Test]
            public void PlanetAddWeaponMethodTest_Exists()
            {
                Planet wp = new Planet("Zemq", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);

                wp.AddWeapon(weapon);

                Assert.Throws<InvalidOperationException>(() =>
                wp.AddWeapon(weapon), $"There is already a { weapon.Name} weapon.");
            }

            [Test]
            public void PlanetAddWeaponMethodTest_OK()
            {
                Planet wp = new Planet("Zemq", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);

                wp.AddWeapon(weapon);

                //Assert.AreEqual (wp.Count, 1);
                Assert.IsTrue(wp.Weapons.Contains(weapon));
            }

            // Remove Weapon Method

            [Test]
            public void PlanetRemoveWeaponMethodTest_OK()
            {
                Planet wp = new Planet("Zemq", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);
                Weapon weapon2 = new Weapon("Sword2", 10, 10);

                wp.AddWeapon(weapon);
                wp.AddWeapon(weapon2);
                wp.RemoveWeapon(weapon.Name);
                 
                Assert.AreEqual (wp.Weapons.Count,1);
                //Assert.IsTrue(wp.Contains(weapon));
            }

            // Upgrade Method Test

            [Test]
            public void UpgradeWeaponTest_Fail()
            {
                Planet wp = new Planet("Zemq", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);

                Assert.Throws<InvalidOperationException>(() 
                    => wp.UpgradeWeapon(weapon.Name), $"{weapon.Name} does not exist in the weapon repository of {wp.Name}");
            }

            [Test]
            public void UpgradeWeaponTest_OK()
            {
                Planet wp = new Planet("Zemq", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);

                wp.AddWeapon (weapon);
                wp.UpgradeWeapon (weapon.Name);

                Assert.AreEqual(weapon.DestructionLevel, 11);
            }


            [Test]
            public void OpponentDestruction_OK()
            {
                Planet planet = new Planet("Zemq", 10);
                Planet planet2 = new Planet("Mars", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);
                Weapon weapon2 = new Weapon("Sword", 10, 2);

                planet.AddWeapon (weapon);
                planet2.AddWeapon (weapon2);


                Assert.AreEqual($"{planet2.Name} is destructed!", planet.DestructOpponent(planet2));
            }

            [Test]
            public void OpponentDestruction_Fail()
            {
                Planet planet = new Planet("Zemq", 10);
                Planet planet2 = new Planet("Mars", 10);

                Weapon weapon = new Weapon("Sword", 10, 10);
                Weapon weapon2 = new Weapon("Sword", 10, 11);

                planet.AddWeapon(weapon);
                planet2.AddWeapon(weapon2);


                Assert.Throws<InvalidOperationException>(()=> planet.DestructOpponent(planet2),$"{planet2.Name} is too strong to declare war to!");
            }

            //Weapon Name Test
            [Test]
            public void WeaponNameTest()
            {
                Weapon weapon = new Weapon("Sword",10,10);

                Assert.AreSame("Sword", weapon.Name);
            }

            //Weapon Price Test
            [Test]
            public void WeaponPriceTest()
            {
                Weapon weapon = new Weapon("Sword", 10.10, 10);

                Assert.AreEqual(10.10, weapon.Price);
            }

            [Test]
            public void WeaponPriceTest_fail()
            {
                Weapon weapon;

                Assert.Throws< ArgumentException>(()=> new Weapon("Sword", -1, 10) ,"Price cannot be negative.");
            }

            //Weapon DestructionLevel Test
            [Test]
            public void WeaponDestructionLevelTest()
            {
                Weapon weapon = new Weapon("Sword", 10, 10);

                Assert.AreEqual(10, weapon.DestructionLevel);
            }

            [Test]
            public void NuclearTest_OK()
            {
                Weapon weapon = new Weapon("NuclearBomb", 10, 11);

                Assert.IsTrue(weapon.IsNuclear);
            }

            [Test]
            public void NuclearTest_Fail()
            {
                Weapon weapon = new Weapon("NuclearBomb", 10, 9);

                Assert.IsFalse(weapon.IsNuclear);
            }

        }
    }
}
