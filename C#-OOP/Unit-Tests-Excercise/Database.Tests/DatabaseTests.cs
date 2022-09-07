namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;
        [SetUp]
        public void SetUp()
        {
            this.db = new Database();
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorShoudAddLessThan16Elements(int[] elementsToAdd)
        {
            Database database = new Database(elementsToAdd);

            int[] actualData = database.Fetch();
            int[] expectedData = elementsToAdd;

            int expectedCount = elementsToAdd.Length;
            int actualCount = database.Count;

            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void ConstructorShouldThrowExceptionMoreThan16Elements(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database database = new Database(elementsToAdd);
            }, "Array's capacity must be exactly 16 integers!");
            
        }

        [TestCase(new int[] { 1, 2, 3})]
        public void CountReturnsCorrectNumber(int[] elementsToAdd)
        {
            Database database = new Database(elementsToAdd);
            int actualCount = database.Count;
            int expectedCount = elementsToAdd.Length;

            Assert.AreEqual(expectedCount, actualCount, "Count should return count of added elements");
        }
        [Test]
        public void CountReturnZeroByNoElements()
        {
            this.db = new Database();
            int actualCount = this.db.Count;
            int expectedCount = 0;

            Assert.AreEqual(expectedCount, actualCount, "Amount of elements should be zero");
        }

        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void MethodAddShouldAddLessThan16Elements(int[] elementsToAdd)
        {
            foreach (var item in elementsToAdd)
            {
                this.db.Add(item);
            }

            int[] actualData = db.Fetch();
            int[] expectedData = elementsToAdd;

            int expectedCount = elementsToAdd.Length;
            int actualCount = db.Count;

            CollectionAssert.AreEqual(expectedData, actualData);
            Assert.AreEqual(expectedCount, actualCount);
        }
        
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void MethodAddShouldNotAddLessThan16Elements(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() => 
            {
                foreach (var item in elementsToAdd)
                {
                    this.db.Add(item);
                }
            }, "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 })]
        public void RemoveShouldRemoveLastElementFromDataBase(int[] elementsToAdd)
        {
            Database database = new Database(elementsToAdd);
            List<int> elements = new List<int>(elementsToAdd);

            database.Remove();
            elements.RemoveAt(elements.Count - 1);

            int[] actualData = database.Fetch();
            int[] expectedData = elements.ToArray();

            int actualCount = database.Count;
            int expectedCount = actualData.Length;
            CollectionAssert.AreEqual(expectedData, actualData, "Should physically remove items from the Database");
            Assert.AreEqual(expectedCount, actualCount, "Count should decrease by 1");
        }
        
        [Test]
        public void RemoveShouldNotWorkWhenZeroElements()
        {
            Assert.Throws<InvalidOperationException>(() => 
            {
                this.db.Remove();
            }, "The collection is empty!");
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCopyArray(int[] elementsToAdd)
        {
            foreach (int el in elementsToAdd)
            {
                this.db.Add(el);
            }

            int[] actualResult = this.db.Fetch();
            int[] expectedResult = elementsToAdd;

            CollectionAssert.AreEqual(expectedResult, actualResult,
                "Fetch should return copy of the existing data!");
        }
    }
}
