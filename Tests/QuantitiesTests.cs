namespace BlackFox.Units.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using BlackFox.Units;

    public class QuantitiesTests
    {
        [Test]
        public void BaseQuantitiesSI()
        {
            Assert.That(Length.BaseUnit, Is.EqualTo(Length.Units.Metre));
            Assert.That(Mass.BaseUnit, Is.EqualTo(Mass.Units.Kilogram));
        }
    }
}
