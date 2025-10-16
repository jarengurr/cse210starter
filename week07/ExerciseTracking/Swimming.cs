public class Swimming : Activity
{
    double _numLaps;
    //lap = 50 meters
    public Swimming(string myDate, int myActLength, int myLaps) : base(myDate, myActLength)
    {
        _numLaps = Convert.ToDouble(myLaps);
    }

    public override void GetSummary()
    {

    }
    
    public int GetDistance()
    {
        double newDist;
        newDist = (_numLaps * 50) / (1000 * .62);

        return 6;
    }


}