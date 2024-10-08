using ShapeSquare.AbstractClasses;
using System;

namespace ShapeSquare.Figure
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC) :
            base(
                Math.Sqrt( ((sideA + sideB + sideC) / 2) * (((sideA + sideB + sideC) / 2) - sideA)
                    * (((sideA + sideB + sideC) / 2) - sideB) * (((sideA + sideB + sideC) / 2) - sideC)
                )
             )
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("One of the side isn't positive");
            if (sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
                throw new ArgumentException("It's not a triangle");
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        } 
        public double sideA {  get { return _sideA; } set { _sideA = value; } }
        public double sideB { get { return _sideB; } set { _sideB = value; } }
        public double sideC { get { return _sideC; } set { _sideC = value; } }


        public bool IsRightAngled()
        {
            double errorRate = 1E-8;
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= errorRate;
        }

    }
}
