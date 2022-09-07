using NUnit.Framework;

namespace SummatorTest
{
    using Summator;
    public class SummatorTests
    {
        [Test]
        public void TestSumTwoNumbers()
        {
            var sum = Summator.Sum(new int[] { 1, 2 });
            Assert.AreEqual(3, sum);
        }
    }
}