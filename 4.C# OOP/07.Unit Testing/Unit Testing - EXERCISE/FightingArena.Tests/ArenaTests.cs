namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Xml.Linq;

    [TestFixture]
    public class ArenaTests
    {

        // EnrollTest --------------------------------------------------------------
        [Test]
        public void WarriorEnrolAlreadyInArena()
        {
            Arena arena = new Arena();

            Warrior warrior = new Warrior("Ganev", 30, 100);

            Warrior warrior2 = new Warrior("Ganev", 30, 100);

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>
                (() => arena.Enroll(warrior2), "Warrior is already enrolled for the fights!");
        }

        [Test]
        public void WarriorEnrolToInArena()
        {
            Arena arena = new Arena();

            Warrior warrior = new Warrior("Ganev", 30, 100);

            arena.Enroll(warrior);

            Assert.AreEqual(arena.Count, 1);
        }

        // Warrrior Fight Test -------------------------------------------------------
        [Test]
        public void AttackerIsNull()
        {
            Arena arena = new Arena();

            Warrior attacker = new Warrior("Ganev", 50, 100);

            Warrior deffender = new Warrior("Jivko", 20, 90);


            Assert.Throws<InvalidOperationException>
                (() => arena.Fight("Ilko", deffender.Name), $"There is no fighter with name Ilko enrolled for the fights!");
        }

        [Test]
        public void DeffenderIsNull()
        {
            Arena arena = new Arena();

            Warrior attacker = new Warrior("Ganev", 50, 100);

            Warrior deffender = new Warrior("Jivko", 20, 90);


            Assert.Throws<InvalidOperationException>
                (() => arena.Fight(attacker.Name, "Simeon"), $"There is no fighter with name Simeon enrolled for the fights!");
        }

        [Test]
        public void AttackerFightDeffender()
        {
            Arena arena = new Arena();

            Warrior attacker = new Warrior("Ganev", 50, 100);

            Warrior deffender = new Warrior("Jivko", 20, 90);

            arena.Enroll(attacker);
            arena.Enroll(deffender);
            arena.Fight(attacker.Name, deffender.Name);
            Assert.AreEqual(deffender.HP, 40);

            
        }


    }

}
