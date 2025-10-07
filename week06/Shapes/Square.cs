public class Square : Shapes
{
    double _side;


    public override double GetArea()
    {

        return _side * _side;

    }

    public void SetSide(double aSide)
    {
        _side = aSide;
    }


}