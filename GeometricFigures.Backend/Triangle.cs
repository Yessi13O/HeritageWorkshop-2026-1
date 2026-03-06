namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    //Fields

    private double _c;
    private double _h;

    //Propertys
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Constructor
    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

    //Validations
    private double ValidateC(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Side C must be greater than 0.");
        return value;
    }

    private double ValidateH(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Height H must be greater than 0.");
        return value;
    }

    //Area calculation
    public override double GetArea() => (B * _h) / 2.0;

    //Calculating the perimeter
    public override double GetPerimeter() => A + B + _c;
}