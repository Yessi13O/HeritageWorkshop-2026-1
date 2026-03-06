namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{   
    //Field
    
    private double _a;

    //Property
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    //Constructor
    public Square(string name, double a) : base()
    {
        Name = name;
        A = a;
    }

    //Validation
    private double ValidateA(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Side A must be greater than 0.");
        return value;
    }

    //Area calculation
    public override double GetArea() => _a * _a;

    //Calculating the perimeter
    public override double GetPerimeter() => 4 * _a;
}