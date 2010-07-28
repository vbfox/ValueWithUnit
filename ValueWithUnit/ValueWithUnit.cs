namespace BlackFox.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Globalization;

    public struct ValueWithUnit : IValueWithUnit
    {
        readonly Unit unit;
        public Unit Unit { get { return unit; } }

        readonly double value;
        public double Value { get { return value; } }

        public ValueWithUnit(double value, Unit unit)
        {
            if (unit == null) throw new ArgumentNullException("unit");

            this.unit = unit;
            this.value = value;
        }

        ValueWithUnit ToBaseUnit()
        {
            return default(ValueWithUnit);
        }

        IValueWithUnit IValueWithUnit.ToBaseUnit()
        {
            return ToBaseUnit();
        }

        public override string ToString()
        {
            return ToStringCore("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (format == null) throw new ArgumentNullException("format");
            if (provider == null) throw new ArgumentNullException("provider");

            return ToStringCore(format, provider);
        }

        public string ToString(string format)
        {
            if (format == null) throw new ArgumentNullException("format");

            return ToStringCore(format, CultureInfo.CurrentCulture);
        }

        public string ToString(IFormatProvider provider)
        {
            if (provider == null) throw new ArgumentNullException("provider");

            return ToStringCore("G", provider);
        }

        string ToStringCore(string format, IFormatProvider provider)
        {
            return string.Format("{0} {1}", value.ToString(format, provider), unit.Symbol);
        }
    }
}
