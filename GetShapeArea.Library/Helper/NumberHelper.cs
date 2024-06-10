namespace GetShapeArea.Library.Helper;

public class NumberHelper
{
    public static void ThrowIfLessZero(double number)
    {
        if(number <= 0)
            throw new ArgumentException("Радиус не может быть меньше или равен 0");
    }
}