namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        public static List<Person> people;
        [SetUp]
        public void SetUp()
        {
            people = new List<Person>();
            people.Add(new Person(12121212, "Gosho"));
            people.Add(new Person(12121213, "Pesho"));
            people.Add(new Person(12121214, "Alex"));
            people.Add(new Person(12121215, "Sra6o"));
            people.Add(new Person(12121216, "Petranka"));
            people.Add(new Person(12121217, "Ivan"));
            people.Add(new Person(12121218, "Dragan"));
            people.Add(new Person(12121219, "Dani"));
            people.Add(new Person(12121220, "Mar4in"));
            people.Add(new Person(12121221, "Marto"));
            people.Add(new Person(12121222, "Simon"));
            people.Add(new Person(12121223, "Ivo"));
            people.Add(new Person(12121224, "Dari"));
            people.Add(new Person(12121225, "Vergil"));
            people.Add(new Person(12121226, "Vili"));
            people.Add(new Person(12121227, "Ronaldo"));
        }

        [Test]
        public void ConstructorShouldAdd16People()
        {
            Database database = new Database(people.ToArray());
            FieldInfo data = database.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(x => x.Name == "persons");

            Person[] actualData = (Person[])data.GetValue(database);
            Person[] expectedData = people.ToArray();

            int actualCount = database.Count;
            int expectedCount = people.Count;
            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);
        }
        [Test]
        public void ConstructorShouldNotAddMoreThan16People()
        {
            people.Add(new Person(12, "Bobo"));
            Assert.Throws<ArgumentException>(() =>
            {
                Database db = new Database(people.ToArray());
            }, "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void CountShouldReturnCorrectNumberOfPeople()
        {
            Database db = new Database(people.ToArray());
            int actualCount = db.Count;
            int expectedCount = people.Count;
            Assert.AreEqual(expectedCount, actualCount, "Count should be the same");

        }

        [Test]
        public void CountShouldReturnZeroWithNoElements()
        {
            Database db = new Database();
            int actualCount = db.Count;
            int expectedValue = 0;
            Assert.AreEqual(expectedValue, actualCount);
        }

        [Test]
        public void AddShouldAddAllPeople()
        {
            Database database = new Database();
            foreach (var person in people)
            {
                database.Add(person);
            }
            FieldInfo data = database.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(x => x.Name == "persons");

            Person[] actualData = (Person[])data.GetValue(database);
            Person[] expectedData = people.ToArray();

            int expectedCount = people.Count();
            int actualCount = actualData.Length;
            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddShouldNotAddMoreThan16People()
        {
            people.Add(new Person(1212, "Bono"));
            Database db = new Database();
            Assert.Throws<InvalidOperationException>(() => 
            {
                foreach (var person in people)
                {
                    db.Add(person);
                }
            }, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void AddShouldNotAddPeopleWithSameName()
        {
            Database db = new Database();
            db.Add(new Person(1212, "Gosho"));
            Assert.Throws<InvalidOperationException>(() => 
            {
                db.Add(new Person(1213, "Gosho"));
            }, "There is already user with this username!");

        }

        [Test]
        public void AddShouldNotAddPeopleSameID()
        {
            Database db = new Database();
            db.Add(new Person(1212, "Gosho"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                db.Add(new Person(1212, "Peho"));
            }, "There is already user with this Id!");
        }

        [Test]
        public void FindByNameShouldReturnPerson()
        {
            Database database = new Database(people.ToArray());
            Person newPerson = database.FindByUsername("Ronaldo");
            Assert.That(newPerson, Is.Not.Null);
        }

        [Test]
        public void FindShouldReturnNullWhenNoMatch()
        {
            Database database = new Database(people.ToArray());
            Assert.Throws<InvalidOperationException>(() =>
            {
                Person person = database.FindByUsername("Dimitri4ka");
            }, "No user is present by this username!");
        }

        [Test]
        public void FindShouldThrowExceptionWithNullParameter()
        {
            Database database = new Database(people.ToArray());
            Assert.Throws<ArgumentNullException>(() =>
            {
                Person person = database.FindByUsername(null);
            }, "Username parameter is null!");
        }

        [Test]
        public void FinsShouldThrowExceptionWithEmptyParameter()
        {
            Database database = new Database(people.ToArray());
            Assert.Throws<ArgumentNullException>(() =>
            {
                Person person = database.FindByUsername(String.Empty);
            }, "Username parameter is null!");
        }

        [Test]
        public void FindShouldThrowExceptionWhenNoPersonFound()
        {
            Database database = new Database(people.ToArray());
            Assert.Throws<InvalidOperationException>(() =>
            {
                Person person = database.FindById(1111111111);
            }, "No user is present by this ID!");
        }

        [Test]

        public void FindByIdShouldThrowExceptionWithNegativeId()
        {
            Database database = new Database(people.ToArray());
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Person person = database.FindById(-1);
            }, "Id should be a positive number!");
        }

        [Test]
        public void FindByIdShouldReturnPerson()
        {
            Database database = new Database(people.ToArray());
            Person person = database.FindById(12121212);
            Assert.That(person, Is.Not.Null);
        } 
    }
}