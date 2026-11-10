
public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}