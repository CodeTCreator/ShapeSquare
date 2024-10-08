
namespace ShapeSquare.AbstractClasses
{
    public abstract class Shape
    {
        private double _area;
        public double Area { get { return _area; }}
        protected Shape(double area ) => this._area = area;
    }
}
