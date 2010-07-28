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

    public class NoUnit : Unit
    {
        static NoUnit instance = new NoUnit();

        public static NoUnit Instance { get { return instance; } }

        public override string Symbol
        {
            get { return string.Empty; }
        }

        private NoUnit() { }
    }

    abstract class Quantity
    {
        public abstract string Name { get; }
    }
    abstract class BaseQuantity : Quantity { }
    abstract class DerivedQuantiy : Quantity { }
}
