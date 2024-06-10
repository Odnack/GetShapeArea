using GetShapeArea.Library.Contract;
using GetShapeArea.Library.Helper;

namespace GetShapeArea.Library.Implementation;

public class Circle : Figure
{
    private readonly double _radius;
    public double Radius
    {
        get => _radius;
        private init
        {
            NumberHelper.ThrowIfLessZero(value);
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}