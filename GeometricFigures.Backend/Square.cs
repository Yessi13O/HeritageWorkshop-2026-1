using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a) : base()
        {
            Name = name;
            A = a;
        }

        private double ValidateA(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side A must be greater than 0.");
            return value;
        }

        public override double GetArea() => _a * _a;

        public override double GetPerimeter() => 4 * _a;
    }
}