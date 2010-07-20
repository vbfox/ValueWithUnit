namespace BlackFox.Units
{
    public interface IValueWithUnit
    {
        Unit Unit { get; }
        double Value { get; }

        IValueWithUnit ToBaseUnit();
    }
}
