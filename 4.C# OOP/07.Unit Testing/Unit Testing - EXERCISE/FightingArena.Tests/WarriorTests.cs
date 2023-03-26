namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        //Warrior Name Test -----------------------------------------------------
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void WarriorNameTestNullOrEmpty(string name)
        {
            Warrior warrior;

            Assert.Throws<ArgumentException>
                (() => new Warrior(name, 30, 100), "Name should not be empty or whitespace!");
        }

        [Test]
        public void WarriorNameTestSuccess()
        {
            Warrior warrior = new Warrior("Ganev", 30, 100);

            Assert.AreEqual(warrior.Name, "Ganev");
        }

        //Warrior Damage Test ----------------------------------------------------

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void WarriorDamageTestZeroOrNegative(int damage)
        {
            Warrior warrior;

            Assert.Throws<ArgumentException>
                (() => new Warrior("Ganev", damage, 100), "Damage value should be positive!");
        }

        [Test]
        public void WarriorDamageTestSuccess()
        {
            Warrior warrior = new Warrior("Ganev", 1, 100);

            Assert.AreEqual(warrior.Damage, 1);
        }

        //Warrior HP Test ----------------------------------------------------

        [Test]
        public void WarriorHPTestCantBeNegative()
        {
            Warrior warrior;

            Assert.Throws<ArgumentException>
                (() => new Warrior("Ganev", 30, -1), "HP should not be negative!");
        }

        [Test]
        public void WarriorHPTestSuccess()
        {
            Warrior warrior = new Warrior("Ganev", 30, 1);

            Assert.AreEqual(warrior.HP, 1);
        }

        //Warrior cant attack if HP below 30 -----------------------------------

        [Test]
        [TestCase(30)]
        [TestCase(29)]
        public void WarriorHPBelow_30(int hp)
        {
            Warrior warrior = new Warrior("Ganev", 30, hp);

            Assert.Throws<InvalidOperationException>
                (() => warrior.Attack(warrior), "Your HP is too low in order to attack other warriors!");
        }

        //Warrior cant attack Warrior if HP below 30 ----------------------------

        [Test]
        [TestCase(30)]
        [TestCase(29)]
        public void WarriorCantAttackWarriorIfHPisBelow_30(int hp)
        {
            Warrior warrior = new Warrior("Ganev", 30, 100);
            Warrior warrior2 = new Warrior("Jivko", 30, hp);

            Assert.Throws<InvalidOperationException>
                (() => warrior.Attack(warrior2), 
                "Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!");
        }

        //Warrior cant attack a Stronger Warrior ----------------------------

        [Test]
        [TestCase(50)]
        [TestCase(31)]
        public void WarriorCantAttackStrongerWarrior(int hp)
        {
            Warrior warrior = new Warrior("Ganev", 30, hp);
            Warrior warrior2 = new Warrior("Jivko", 100, 100);

            Assert.Throws<InvalidOperationException>
                (() => warrior.Attack(warrior2),
                "You are trying to attack too strong enemy");
        }

        //Warrior attacks Warrior 2------------------------------------------
        [Test]
        public void WarriorAttackSucces()
        {
            Warrior warrior = new Warrior("Ganev", 50, 100 );
            Warrior warrior2 = new Warrior("Jivko", 45, 100);

            warrior.Attack(warrior2);

            Assert.AreEqual(warrior2.HP, 50);
        }

        //Warrior attacks Warrior 2 (Warrior 2 Below 0 Hp after Attack)----------------
        [Test]
        public void WarriorAttackSuccesWarrior2Below0HP()
        {
            Warrior warrior = new Warrior("Ganev", 60, 100);
            Warrior warrior2 = new Warrior("Jivko", 45, 50);

            warrior.Attack(warrior2);

            Assert.AreEqual(warrior2.HP, 0);
        }
    }
}