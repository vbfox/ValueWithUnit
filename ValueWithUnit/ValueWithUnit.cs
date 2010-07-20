namespace BlackFox.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public struct ValueWithUnit : IValueWithUnit
    {
        readonly Unit unit;
        public Unit Unit { get { return unit; } }

        readonly double value;
        public double Value { get { return value; } }

        public ValueWithUnit(Unit unit, double value)
        {
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
    }
}
