using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

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

    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

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

    public override double GetArea() => (B * _h) / 2.0;

    public override double GetPerimeter() => A + B + _c;
}