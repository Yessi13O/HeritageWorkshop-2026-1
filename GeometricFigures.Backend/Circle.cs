namespace GeometricFigures.Backend;

public class Circle : GeometricFigure

{   //Field
    private double _r;

    //Property
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    //Constructor
    public Circle(string name, double r) : base()
    {
        Name = name;
        R = r;
    }

    //Validation
    private double ValidateR(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Radius R must be greater than 0.");
        return value;
    }

    //Area calculation
    public override double GetArea() => Math.PI * _r * _r;

    //Calculating the perimeter
    public override double GetPerimeter() => 2 * Math.PI * _r;
}

