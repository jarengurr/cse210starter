public abstract class Activity
{
    private string _date; // "02/15/2025"
    private double _activityLength; // in minutes


    public Activity(string myDate, double myActLength)
    {
        _date = myDate;
        _activityLength = myActLength;
    }
    public abstract double GetDistance();


    public abstract double GetSpeed();



    public abstract double GetPace();



    public virtual void GetSummary()
    {

    }
    public double GetActLength()
    {
        return _activityLength;
    }
    
    public string GetDate()
    {
        return _date;
    }

}