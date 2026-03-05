using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        private double ValidateB(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side B must be greater than 0.");
            return value;
        }

        public override double GetArea() => A * _b;

        public override double GetPerimeter() => 2 * (A + _b);
    }
}