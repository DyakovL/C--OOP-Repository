namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Database database = new Database();
        }
        [TearDown]
        public void TearDown()
        {
            Database database = null;
        }

        [Test]
        public void AddTest()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            database.Add(11);
            Assert.AreEqual(11, database.Count);
        }

        [Test]
        public void AddTestException()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.Throws<InvalidOperationException>(() => database.Add(11), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void Remove()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            database.Remove();

            Assert.AreEqual(15, database.Count);

        }

        [Test]
        public void RemoveTestException()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove(), "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void FetchTest()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7);

            int[] array = { 1, 2,3,4,5,6,7};

            
            Assert.AreEqual(array, database.Fetch());
        }
    }
}
