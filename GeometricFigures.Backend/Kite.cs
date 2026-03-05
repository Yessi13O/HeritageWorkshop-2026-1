using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }

        private double ValidateB(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side B must be greater than 0.");
            return value;
        }

        public override double GetArea() => (D1 * D2) / 2.0;

        public override double GetPerimeter() => 2 * (A + _b);
    }
}
