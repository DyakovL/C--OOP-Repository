using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {

        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(10, 10);
            dummy = new Dummy(10, 10);
        }

        [Test]
        public void DummyLossesHealthWhenAttacked()
        {
            axe = new Axe(5, 10);

            axe.Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(5), "Target is dead");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy), "Dummy is not dead");
        }

        [Test]
        public void DeadDummyCanGiveExp()
        {
            axe.Attack(dummy);

            //Assert.That(dummy.IsDead(), dummy.GiveExperience() ,"Dummy is alive");
            Assert.That(dummy.GiveExperience(), Is.Positive, "Dummy is alive");
        }

        [Test]
        public void AliveDummyCanNotGiveExp()
        {
            Dummy dummy = new Dummy(13, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}