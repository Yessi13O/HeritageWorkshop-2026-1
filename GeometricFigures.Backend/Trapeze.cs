using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        private double ValidateD(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side D must be greater than 0.");
            return value;
        }

        public override double GetArea() => (B + _d) * H / 2.0;

        public override double GetPerimeter() => A + B + C + _d;
    }
}