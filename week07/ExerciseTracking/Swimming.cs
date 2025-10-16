public class Swimming : Activity
{
    private double _numLaps;
    //lap = 50 meters
    public Swimming(string myDate, double myActLength, double myLaps) : base(myDate, myActLength)
    {
        _numLaps = Convert.ToDouble(myLaps);
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming({GetActLength()} min)-Distance {GetDistance()} miles, Speed {GetSpeed()} MPH, Pace: {GetPace()} min per mile");
    }

    public override double GetDistance()
    {
        double newDist;
        newDist = (_numLaps * .03106856);

        return newDist;
    }

    public override double GetSpeed()
    {
        double holdSpeed = ((_numLaps * .03106856) / GetActLength()) * 60;
        return 4;
    }

    public override double GetPace()
    {
        return GetActLength() / (_numLaps * .03106856);
    }





}