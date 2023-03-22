namespace Database.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void IfDataBeseCapacityIsMaxOut()
        {
            Database[] _databases = new Database[16];

            Assert.That(_databases.Count(), Is.EqualTo(16));
        }

        [Test]
        public void IfDataBeseCapacityIsMoreThenMAX()
        {
            Database database 
                = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.Throws<InvalidOperationException>(()=>  
            database.Add(1), "Array's capacity must be exactly 16 integers!");

        }

        [Test]
        public void AddSucess()
        {
            Database database
                = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            database.Add(1);

            Assert.That(database.Count ,Is.EqualTo(16));
        }

        [Test]
        public void AddFail()
        {
            Database database
                = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.Throws<InvalidOperationException>(() =>
            database.Add(1), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void RemoveSucess()
        {
            Database database
                = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            database.Remove();

            Assert.That(database.Count, Is.EqualTo(15));
        }

        [Test]
        public void RemoveFail()
        {
            Database database
                = new Database();

            Assert.Throws<InvalidOperationException>(() =>
            database.Remove(), "The collection is empty!");
        }

        [Test]
        public void FetchTest()
        {
            Database database
                = new Database(1, 2, 3);

            int[] ints = database.Fetch();

            Assert.That(ints.Count, Is.EqualTo(3));
        }
    }
}
