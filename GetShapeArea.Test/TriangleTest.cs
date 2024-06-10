using GetShapeArea.Library.Constant;
using GetShapeArea.Library.Implementation;

namespace GetShapeArea.Test;

[TestFixture]
public class TriangleTest
{
    [Test]
    public void Constructor_ValidSides_CreatesTriangle()
    {
        const double a = 3;
        const double b = 4;
        const double c = 5;

        var triangle = new Triangle(a, b, c);

        Assert.Multiple(() =>
        {
            Assert.That(triangle.A, Is.EqualTo(a));
            Assert.That(triangle.B, Is.EqualTo(b));
            Assert.That(triangle.C, Is.EqualTo(c));
        });
    }

    [Test]
    public void Constructor_InvalidSides_ThrowsArgumentException()
    {
        const double a = 1;
        const double b = 2;
        const double c = 3;

        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Test]
    public void GetArea_ValidSides_ReturnsCorrectArea()
    {
        const double a = 3;
        const double b = 4;
        const double c = 5;
        var triangle = new Triangle(a, b, c);
        const double expectedArea = 6; // Площадь треугольника со сторонами 3, 4 и 5

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(expectedArea).Within(NumberConstant.SmallNumber));
    }

    [Test]
    public void IsRectangular_ValidRightTriangle_ReturnsTrue()
    {
        const double a = 3;
        const double b = 4;
        const double c = 5;
        var triangle = new Triangle(a, b, c);

        var isRectangular = triangle.IsRectangular;
        
        Assert.That(isRectangular, Is.True);
    }

    [Test]
    public void IsRectangular_NotRightTriangle_ReturnsFalse()
    {
        const double a = 3;
        const double b = 4;
        const double c = 6;
        var triangle = new Triangle(a, b, c);

        var isRectangular = triangle.IsRectangular;

        Assert.That(isRectangular, Is.False);
    }

    [Test]
    public void Constructor_NegativeSide_ThrowsArgumentException()
    {
        const double a = -3;
        const double b = 4;
        const double c = 5;

        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}