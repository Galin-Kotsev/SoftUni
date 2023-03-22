using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyHelth()
        {
            Axe axe = new Axe(1,10);
            Dummy dummy = new Dummy(10,10);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(9));
        }

        [Test]
        public void DummyDeadTest()
        {
            Axe axe = new Axe(1, 10);
            Dummy dummy = new Dummy(1, 10);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(0));
        }


        [Test]
        public void DummyDeadAttackFail()
        {
            Axe axe = new Axe(1, 10);
            Dummy dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(5), "Dummy is dead.");
        }


        

        [Test]
        public void DummyDeadTest_2()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(0));
        }

        [Test]
        public void DummyDeadTestFail()
        {
            Axe axe = new Axe(9, 10);
            Dummy dummy = new Dummy(10, 10);
            
            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() =>
                dummy.GiveExperience(), "Target is not dead."
            );
        }

        [Test]
        public void DummyDeadTestFail_2()
        {
            Axe axe = new Axe(2, 10);
            Dummy dummy = new Dummy(3, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() =>
                dummy.GiveExperience(), "Target is not dead.");
        }

        [Test]
        public void DummyDeadGiveXP()
        {
            Axe axe = new Axe(2, 10);
            Dummy dummy = new Dummy(2, 10);

            axe.Attack(dummy);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
        }

        [Test]
        public void DummyDeadGiveXP_2()
        {
            Axe axe = new Axe(5, 10);
            Dummy dummy = new Dummy(5, 10);

            axe.Attack(dummy);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
        }

        [Test]
        public void DummyDeadCantGiveXP()
        {
            Axe axe = new Axe(2, 10);
            Dummy dummy = new Dummy(3, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(), "Target is not dead.");
        }

        [Test]
        public void DummyDeadCantGiveXP_2()
        {
            Axe axe = new Axe(5, 10);
            Dummy dummy = new Dummy(9, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(), "Target is not dead.");
        }
    }
}