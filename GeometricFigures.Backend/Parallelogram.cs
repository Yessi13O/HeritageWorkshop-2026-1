namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{   
    //Field

    private double _h;

    //Property
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Constructor
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    //Validation
    private double ValidateH(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Height H must be greater than 0.");
        return value;
    }

    //Area calculation
    public override double GetArea() => B * _h;

    //Calculating the perimeter
    public override double GetPerimeter() => 2 * (A + B);
}