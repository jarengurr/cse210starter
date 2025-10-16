public  class Cycling : Activity
{
    private double _speed;

    public Cycling(string myDate, int myActLength, float mySpeed) : base(myDate, myActLength)
    {
        _speed = mySpeed;
    }

    public override double GetDistance()
    {
        double holdDistance = _speed * GetActLength();

        return holdDistance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

        
    public override double GetPace()
    {
        return 60/_speed;
    }

}