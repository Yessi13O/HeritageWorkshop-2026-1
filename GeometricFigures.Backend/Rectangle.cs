namespace GeometricFigures.Backend;

public class Rectangle : Square
{   
    //Field

    private double _b;

    //Property
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    //Constructor
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    //Validation
    private double ValidateB(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Side B must be greater than 0.");
        return value;
    }

    //Area calculation
    public override double GetArea() => A * _b;

    //Calculating the perimeter
    public override double GetPerimeter() => 2 * (A + _b);
}