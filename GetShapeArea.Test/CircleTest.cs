using GetShapeArea.Library.Constant;
using GetShapeArea.Library.Implementation;

namespace GetShapeArea.Test;

[TestFixture]
public class CircleTest
{
    [Test]
    public void Constructor_ValidRadius_CreatesCircle()
    {
        const double radius = 5;

        var circle = new Circle(radius);

        Assert.That(circle.Radius, Is.EqualTo(radius));
    }

    [Test]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        const double radius = -5;

        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    public void GetArea_ValidRadius_ReturnsCorrectArea()
    {
        const double radius = 3;
        var circle = new Circle(radius);
        const double expectedArea = Math.PI * radius * radius;

        var area = circle.GetArea();

        Assert.That(area, Is.EqualTo(expectedArea).Within(NumberConstant.SmallNumber));
    }
}