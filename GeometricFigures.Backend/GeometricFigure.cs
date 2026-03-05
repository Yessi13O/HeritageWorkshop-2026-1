using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        public GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),15:N5}   Perimiter: {GetPerimeter(),15:N5}";
        }
    }
}