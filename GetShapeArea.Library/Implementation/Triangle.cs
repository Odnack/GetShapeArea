using GetShapeArea.Library.Constant;
using GetShapeArea.Library.Contract;
using GetShapeArea.Library.Helper;

namespace GetShapeArea.Library.Implementation;

public class Triangle : Figure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public double A
    {
        get => _a;
        private init
        {
            NumberHelper.ThrowIfLessZero(value);
            _a = value;
        }
    }

    public double B
    {
        get => _b;
        private init
        {
            NumberHelper.ThrowIfLessZero(value);
            _b = value;
        }
    }

    public double C
    {
        get => _c;
        private init
        {
            NumberHelper.ThrowIfLessZero(value);
            _c = value;
        }
    }

    public bool IsRectangular { get; private set; }

    public Triangle(double a, double b, double c)
    {
        if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            throw new ArgumentException("Стороны не могут образовать треугольник.");

        A = a;
        B = b;
        C = c;

        CheckRectangular();
    }

    public override double GetArea()
    {
        var s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    private void CheckRectangular()
    {
        var aSquared = A * A;
        var bSquared = B * B;
        var cSquared = C * C;

        IsRectangular = Math.Abs(aSquared - (bSquared + cSquared)) < NumberConstant.SmallNumber
                        || Math.Abs(bSquared - (aSquared + cSquared)) < NumberConstant.SmallNumber
                        || Math.Abs(cSquared - (aSquared + bSquared)) < NumberConstant.SmallNumber;
    }
}