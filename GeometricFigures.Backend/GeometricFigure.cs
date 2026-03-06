namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{   
    //Property
    public string Name { get; set; } = string.Empty;

    //Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),15:N5}   Perimiter: {GetPerimeter(),15:N5}";
    }
}