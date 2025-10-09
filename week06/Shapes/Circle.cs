public class Circle : Shapes
{
    private double _radius;

    
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return area;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }
}