public class Rectangle : Shapes
{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }

    public void SetInfo(double length, double width)
    {
        _length = length;
        _width = width;
    }
}