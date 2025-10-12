using System.ComponentModel;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {
        
    }


    public override void RecordEvent()
    {

    }

    public override bool IsComplete() // never complete count times done
    {
        return false;
    }

   

    public override string GetStringRepresentational()
    {
        string fileString = $"Eternal Goal|{base.GetShortName}|{base.GetDesc}|{base.GetPoints}";
        return fileString;
    }


}