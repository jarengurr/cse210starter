public class Goal
{
    private string _shortName; // short name of goal
    private string _description; // description of goal
    private string _points; // points per event
    //int _completePoints; // total of points per event or completion



    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        //_completePoints = 0;
    }


    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        string holdString;
        if (IsComplete())
            holdString = $"[X]  {_shortName}   {_description}";
        else
            holdString = $"[ ]  {_shortName}   {_description}";
             


                return holdString;
    }

    public virtual string GetStringRepresentational()
    {
        return "";
    }


    public string GetShortName()
    {
        return _shortName;
    }

    protected string GetDesc()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

   







}