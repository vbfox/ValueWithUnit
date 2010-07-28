namespace BlackFox.Units
{
    using System;

    public interface IValueWithUnit
    {
        Unit Unit { get; }
        double Value { get; }

        IValueWithUnit ToBaseUnit();

        string ToString(string format, IFormatProvider provider);
        string ToString(string format);
        string ToString(IFormatProvider provider);
    }
}
