public class Rectangle : Shapes
{
    double _length;
    double _width;

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