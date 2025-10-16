public class Running : Activity
{
    private double _distance;


    public Running(string myDate, double myActLength, double myDist) : base(myDate, myActLength)
    {
        _distance = myDist;
    }

    public override double GetSpeed()
    {
        double holdSpeed = _distance / GetActLength();

        return holdSpeed;

    }

    public override double GetDistance()
    {
        return _distance;
    }
    
    public override double GetPace()
    {
        double holdPace = _distance / GetActLength();
        return holdPace;
    }
        
    
    
        
    
    
        
    
}