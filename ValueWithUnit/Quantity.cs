namespace BlackFox.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Unit
    {
        public abstract string Symbol { get; }
    }

    abstract class Quantity
    {
        public abstract string Name { get; }
    }
    abstract class BaseQuantity : Quantity { }
    abstract class DerivedQuantiy : Quantity { }
}
