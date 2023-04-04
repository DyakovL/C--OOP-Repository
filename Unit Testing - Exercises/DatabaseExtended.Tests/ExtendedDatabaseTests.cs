using System;
using System.Security.Cryptography.X509Certificates;
using ExtendedDatabase;
using NUnit.Framework;

namespace DatabaseExtended.Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
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
        public  void AddTest()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");

            database.Add(person);
            
            Assert.AreEqual(1, database.Count);
        }

        [Test]

        public void AddUsernameExceptionTest()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");
            Person person1 = new Person(2, "Gosho");

            database.Add(person);

            InvalidOperationException message = Assert.Throws<InvalidOperationException>(() => database.Add(person1));

            Assert.AreEqual(message.Message, "There is already user with this username!");
        }

        [Test]

        public void AddIdExceptionTest()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");
            Person person1 = new Person(1, "Pesho");

            database.Add(person);

            InvalidOperationException message = Assert.Throws<InvalidOperationException>(() => database.Add(person1));

            Assert.AreEqual(message.Message, "There is already user with this Id!");
        }

        [Test]
        public void AddCapacityExceptionTest()
        {
            Database database = new Database();

            var people = new Person[]
            {
                new Person(1, "Gosho"),
                new Person(2, "Pesho"),
                new Person(3, "f"),
                new Person(4, "s"),
                new Person(5, "sfd"),
                new Person(6, "sdfe"),
                new Person(7, "v"),
                new Person(8, "a"),
                new Person(9, "y"),
                new Person(10, "octutt"),
                new Person(11, "z"),
                new Person(12, "b"),
                new Person(13, "m"),
                new Person(14, "k"),
                new Person(15, "l"),
                new Person(16, "hj"),
                new Person(17, "yhjkol"),
                new Person(18, "yhjkol2")

            };

            for (int i = 0; i < people.Length - 2; i++)
            {
                database.Add(people[i]);
            }

            InvalidOperationException message = Assert.Throws<InvalidOperationException>(() => database.Add(people[17]));

            Assert.AreEqual(message.Message, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void RemoveTest()
        {
            Database database = new Database();

            Person personOne = new Person(1, "Gosho");
            Person personTwo = new Person(2, "Pesho");

            database.Add(personOne);
            database.Add(personTwo);

            database.Remove();

            Assert.AreEqual(1, database.Count);
            Assert.That(database.FindByUsername("Gosho").UserName, Is.EqualTo("Gosho"));
        }

        [Test]
        public void RemoveTestException()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove(), "");
        }

        [Test]
        public void FindByUsernameValid()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");

            database.Add(person);

            Assert.That(database.FindByUsername("Gosho").UserName, Is.EqualTo("Gosho"));
        }

        [Test]
        public void FindByUserNameExceptionTest()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");
            Person person1 = new Person(2, "Pesho");

            database.Add(person1);
            database.Add(person);

            InvalidOperationException message =
                Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Grisho"));

            Assert.AreEqual(message.Message, "No user is present by this username!");
        }

        [TestCase(null)]
        [TestCase("")]
        public void FindByUserNameNullExceptionTest(string name)
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");
            Person person1 = new Person(2, "Pesho");

            database.Add(person1);
            database.Add(person);

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(name), "Username parameter is null!");
        }

        [Test]
        public void FindByIdValid()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");

            database.Add(person);

            Assert.That(database.FindById(1).Id, Is.EqualTo(1));
        }

        [Test]
        public void FindByIdNoUserFoundException()
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");
            Person person1 = new Person(2, "Pesho");

            database.Add(person1);
            database.Add(person);

            Assert.Throws<InvalidOperationException>(() => database.FindById(3), "No user is present by this ID!");
        }

        [TestCase(-1)]
        public void FindByNegativeIdException(int number)
        {
            Database database = new Database();
            Person person = new Person(1, "Gosho");
            Person person1 = new Person(2, "Pesho");

            database.Add(person1);
            database.Add(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(number), "Id should be a positive number!");
        }

        [Test]
        public void AddRangeException()
        {
            var persons = new Person[]
            {
                new Person(1818181818, "Gosho"),
                new Person(0258952323, "Pesho"),
                new Person(9486934989, "f"),
                new Person(9438508225, "s"),
                new Person(9305790325, "sfd"),
                new Person(9583823332, "sdfe"),
                new Person(2332434346, "v"),
                new Person(8943617631, "a"),
                new Person(9306746807, "y"),
                new Person(2394893239, "octutt"),
                new Person(9283583025, "z"),
                new Person(0392483290, "b"),
                new Person(2948390489, "m"),
                new Person(8523570523, "k"),
                new Person(2444342344, "l"),
                new Person(2343535355, "hj"),
                new Person(2532354353, "yhjkol"),
                new Person(2532354351, "yhjkol2")
            };

            Database database = new Database();

            Assert.Throws<ArgumentException>(() => database = new Database(persons), "Provided data length should be in range [0..16]!");
        }

    }
}