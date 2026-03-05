namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        private double ValidateR(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Radius R must be greater than 0.");
            return value;
        }

        public override double GetArea() => Math.PI * _r * _r;

        public override double GetPerimeter() => 2 * Math.PI * _r;
    }
}

