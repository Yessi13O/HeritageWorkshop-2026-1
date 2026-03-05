using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        private double ValidateD1(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Diagonal D1 must be greater than 0.");
            return value;
        }

        private double ValidateD2(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Diagonal D2 must be greater than 0.");
            return value;
        }

        public override double GetArea() => (_d1 * _d2) / 2.0;

        public override double GetPerimeter() => 4 * A;
    }
}