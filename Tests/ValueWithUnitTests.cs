namespace BlackFox.Units.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;

    [TestFixture]
    public class ValueWithUnitTests
    {
        [Test]
        public void BaseStructCtor()
        {
            var v = new ValueWithUnit();
            Assert.That(v.Value, Is.EqualTo(0.0));
            Assert.That(v.Unit, Is.EqualTo(NoUnit.Instance));
        }

        [Test]
        public void NormalCtor()
        {
            var v = new ValueWithUnit(0.0, Time.Units.Second);
            Assert.That(v.Value, Is.EqualTo(0.0));
            Assert.That(v.Unit, Is.EqualTo(Time.Units.Second));
        }

        [Test]
        public void CtorThrowOnNullUnit()
        {
            Assert.Throws<ArgumentNullException>(() => new ValueWithUnit(0.0, null));
        }
    }
}
