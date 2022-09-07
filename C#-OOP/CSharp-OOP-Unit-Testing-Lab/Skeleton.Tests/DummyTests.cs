using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void LoosesHealthWhenAttacke()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(5);
            Assert.That(dummy.Health, Is.EqualTo(5), "Dummy doesn't take damage");
        }

        [Test]

        public void ThrowsExceptionWhenDead()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var dummy = new Dummy(10, 10);
                dummy.TakeAttack(11);
                dummy.TakeAttack(2);
            });

        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            var dummy = new Dummy(10, 10);
            dummy.TakeAttack(11);
            int experience = dummy.GiveExperience();
            Assert.AreEqual(10, experience);
        }

        [Test]
        public void AliveDummyDoesntGiveExperience()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var dummy = new Dummy(10, 10);
                dummy.GiveExperience();
            });
        }
    }
}