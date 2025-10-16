public class Activity
{
    string _date; // "02/15/2025"
    int _activityLength; // in minutes


    public Activity(string myDate, int myActLength)
    {
        _date = myDate;
        _activityLength = myActLength;
    }

    public virtual void GetSummary()
    {

    }
    

}