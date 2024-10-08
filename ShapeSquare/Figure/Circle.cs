using ShapeSquare.AbstractClasses;
using System;

namespace ShapeSquare.Figure
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius) : base(radius * radius * Math.PI) 
        {
            if (radius <= 0)
                throw new ArgumentException("The radius is incorrect");
            _radius = radius;
        }

        public double Radius { get { return _radius; }  set { _radius = value; } }
    }
}
