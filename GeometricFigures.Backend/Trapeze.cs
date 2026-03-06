namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    //Field

    private double _d;

    //Property
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    //Constructor
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }

    //Validation
    private double ValidateD(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Side D must be greater than 0.");
        return value;
    }

    //Area calculation
    public override double GetArea() => (B + _d) * H / 2.0;

    //Calculating the perimeter
    public override double GetPerimeter() => A + B + C + _d;
}