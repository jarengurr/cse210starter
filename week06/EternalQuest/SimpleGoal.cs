public class SimpleGoal : Goal
{

    bool _isComplete;


    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {

    }

    public override bool IsComplete() // if points = zero then iscomplete is false
    {
        return _isComplete;
           
    }

    public override string GetStringRepresentational()
    {

        string fileString = $"Simple Goal*{base.GetShortName()}*{base.GetDesc()}*{base.GetPoints()}";
        return fileString;
    }




}