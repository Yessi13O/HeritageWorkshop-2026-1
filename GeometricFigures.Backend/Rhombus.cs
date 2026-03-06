namespace GeometricFigures.Backend;

public class Rhombus : Square
{   
    //Fields

    private double _d1;
    private double _d2;

    //Propertys
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

    //Constructor
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    //Validations
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

    //Area calculation
    public override double GetArea() => (_d1 * _d2) / 2.0;

    //Calculating the perimeter
    public override double GetPerimeter() => 4 * A;
}