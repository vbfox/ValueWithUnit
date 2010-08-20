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

        [Test]
        public void MultiplyWithDouble()
        {
            var v = new ValueWithUnit(5.0, Time.Units.Second);
            v *= 10.0;

            Assert.That(v.Value, Is.EqualTo(50.0));
            Assert.That(v.Unit, Is.EqualTo(Time.Units.Second));
        }

        [Test]
        public void DivideWithDouble()
        {
            var v = new ValueWithUnit(5.0, Time.Units.Second) / 2.0;
            
            Assert.That(v.Value, Is.EqualTo(2.5));
            Assert.That(v.Unit, Is.EqualTo(Time.Units.Second));
        }

        [Test]
        public void ToBaseUnit()
        {
            IValueWithUnit v = new ValueWithUnit(1000, Time.Units.Millisecond);
            
            Assert.That(v.Value, Is.EqualTo(1000.0));
            Assert.That(v.Unit, Is.EqualTo(Time.Units.Millisecond));

            var b = v.ToBaseUnit();

            Assert.That(b.Value, Is.EqualTo(1.0));
            Assert.That(b.Unit, Is.EqualTo(Time.Units.Second));
        }
    }
}
