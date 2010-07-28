namespace BlackFox.Units.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using BlackFox.Units;
    using BlackFox.Units.Multiples;
    using System.Runtime.InteropServices;
    using System.Globalization;

    [TestFixture]
    public class ValuesWithUnitsTests
    {
        [Test]
        public void BaseQuantities()
        {
            var value = 3 * Length.Centimetre;

            Assert.That(value.Unit, Is.TypeOf<CentimetreUnit>());
            Assert.That(value.Unit, Is.EqualTo(Length.Centimetre));
        }
        /*
        [Test]
        public void BasicConstants()
        {
            var c = 299792458.0 * Length.Metre / Time.Second; // Speed of light in vacum

            var year = 31557600.0 * Time.Second; // Julian year
            var ly = c * year; // Light-Year

            Assert.That(ly.Unit, Is.EqualTo(Length.Metre));

            var au = 149597870.7 * Length.Kilometre; // Astronomical unit (distance between the Earth and the Sun)
            var pc = 3.085677E16 * Length.Metre; // Parsec

            var timeForLightToReachEarth = au / c;

            Assert.That(timeForLightToReachEarth.Unit, Is.EqualTo(Time.Second));
        }*/

        [Test]
        public void SizeOfSpecificValueWithUnitNotBiggerThanDouble()
        {
            Assert.That(Marshal.SizeOf(Metres.Zero), Is.EqualTo(Marshal.SizeOf(0.0)));
        }

        [Test]
        public void IsIequatable()
        {
            Assert.That(Metres.Zero is IEquatable<Metres>);
            Assert.That(Metres.Zero is IEquatable<IValueWithUnit>);
        }

        [Test]
        public void ImplicitCastFromUnitToValueWithUnit()
        {
            Metres m = Length.Metre;
            Kilometres km = Length.Metre;
        }

        [Test]
        public void MultiplyValueAndUnit()
        {
            var km = 42 * Length.Kilometre;
            Assert.That(km.Unit, Is.EqualTo(Length.Units.Kilometre));
            Assert.That(km.Value, Is.EqualTo(42));
        }

        [Test]
        public void ImplicitCastFromMultiples()
        {
            Metres m = 3*Length.Kilometre;
            Assert.That(m.Value, Is.EqualTo(3000));

            Centimetres cm = 5*Length.Kilometre;
            Assert.That(cm.Value, Is.EqualTo(500000));
        }

        [Test]
        public void ToStringIncludeSymbol()
        {
            Assert.That(Length.Metre.ToString(), Is.EqualTo("1 m"));
            Assert.That((500*Length.Kilometre).ToString(), Is.EqualTo("500 km"));
        }

        [Test]
        public void ToStringWithFormat()
        {
            Assert.That((500 * Length.Kilometre).ToString("0", CultureInfo.InvariantCulture), Is.EqualTo("500 km"));
            Assert.That((500 * Length.Kilometre).ToString("0.##", CultureInfo.InvariantCulture), Is.EqualTo("500 km"));
            Assert.That((500 * Length.Kilometre).ToString("0.0", CultureInfo.InvariantCulture), Is.EqualTo("500.0 km"));
            Assert.That((500 * Length.Kilometre).ToString("A0.0B", CultureInfo.InvariantCulture), Is.EqualTo("A500.0B km"));
        }

        [Test]
        public void ToStringWithCulture()
        {
            var fr = CultureInfo.GetCultureInfoByIetfLanguageTag("fr-FR");
            Assert.That((500 * Length.Kilometre).ToString("0", fr), Is.EqualTo("500 km"));
            Assert.That((500 * Length.Kilometre).ToString("0.##", fr), Is.EqualTo("500 km"));
            Assert.That((500 * Length.Kilometre).ToString("0.0", fr), Is.EqualTo("500,0 km"));
            Assert.That((500 * Length.Kilometre).ToString("A0.0B", fr), Is.EqualTo("A500,0B km"));
        }
    }
}