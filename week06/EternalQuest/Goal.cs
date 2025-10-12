public class Goal
{
    string _shortName;
    string _description;
    string _points;


    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
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

        string holdString = $"[ ]  {_shortName}   {_description}";
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
    
     protected string GetPoints()
    {
        return "";
    }








}