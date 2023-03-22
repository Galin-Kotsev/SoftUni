namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        [TestCase("jivko")]
        [TestCase("Jivko")]
        public void FindByUserNameDoestExist(string user)
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasan");

            db.Add(person);

            Assert.Throws<InvalidOperationException>
                (() => db.FindByUsername(user), "No user is present by this username!");
        }

        [Test]
        public void FindUserCorrect()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasam");

            db.Add(person);

            Assert.AreEqual(db.FindByUsername("Hasam").UserName, person.UserName);
        }

        [Test]
        public void FindByUserNameDoestExist_null_Test()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasan");

            db.Add(person);

            Assert.Throws<ArgumentNullException>
                (() => db.FindByUsername(null), "Username parameter is null!");
        }

        [Test]
        public void AddUserExist()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasam");

            db.Add(person);

            Assert.Throws<InvalidOperationException>
                (() => db.Add(person), "There is already user with this username!");
        }

        [Test]
        public void AddUserCorrect()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasam");

            db.Add(person);

            Assert.AreEqual(1, db.Count);
        }

        [Test]
        public void AddIdExist()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasam");

            Person person2
                = new Person(1, "Jivko");

            db.Add(person);

            Assert.Throws<InvalidOperationException>(() =>
            db.Add(person2), "There is already user with this Id!");
        }

        [Test]
        public void FindIdCorrect()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasam");

            db.Add(person);

            Assert.AreEqual(db.FindById(1).Id, person.Id);
        }


        [Test]
        public void Remove()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasam");

            db.Add(person);
            db.Remove();

            Assert.AreEqual(0, db.Count);

        }

        [Test]
        public void RemoveInvalid()
        {
            Database db = new Database();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void FindByIdDoestExist()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasan");

            db.Add(person);

            Assert.Throws<InvalidOperationException>
                (() => db.FindById(2), "No user is present by this ID!");
        }

        [Test]
        public void FindById_NegativeId()
        {
            Database db = new Database();

            Person person
                = new Person(1, "Hasan");

            db.Add(person);

            Assert.Throws<ArgumentOutOfRangeException>
                (() => db.FindById(-2), "Id should be a positive number!");
        }

        [Test]
        public void AddToMaxCapacity()
        {
            Person[] people = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                people[i] = new Person(i, $"Hasan{i}");
            }

            Database db = new Database(people);

            Person person17 = new Person(17, "Hasan17");

            Assert.Throws<InvalidOperationException>(() => db.Add(person17), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void AddToMaxCapacity_2()
        {
            Person[] people = new Person[17];

            Database db = new Database();

            for (int i = 0; i < 17; i++)
            {
                people[i] = new Person(i, $"Hasan{i}");
            }

            Assert.Throws<ArgumentException>(() => db = new Database(people), "Provided data length should be in range [0..16]!");
        }
    }
}