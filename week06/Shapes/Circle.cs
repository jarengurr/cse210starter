public class Circle : Shapes
{
    private double _radius;

    public override double GetArea()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return .5;
    }
}