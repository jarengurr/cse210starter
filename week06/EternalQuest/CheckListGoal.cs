using System.Reflection.Metadata.Ecma335;

public class CheckListGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;



    public CheckListGoal(string name, string description, string points,  int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        int myBonus = 0;
        _amountCompleted = _amountCompleted + 1;
        string holdPoints = GetPoints();
        int hold = Convert.ToInt32(holdPoints);
        if (IsComplete())
            hold = _bonus + myBonus;
            
        SetCompletePoints(hold);  
    }

    public override bool IsComplete() // complete when amountcompleteted = target
    {
        if (_target == _amountCompleted)
            return true;
        else
            return false;
    }

    public override string GetDetailsString()
    {
        string holdString;
        if (_amountCompleted == _target)
        {
            holdString = $"[X] {base.GetShortName()} {base.GetDesc()}   {_amountCompleted} / {_target}";
        }
        else
        {
            holdString = $"[ ] {base.GetShortName()} {base.GetDesc()}   {_amountCompleted} / {_target}";
             
        }
    
          return holdString;
    }

    public override string GetStringRepresentational()
    {
        string fileString = $"Simple Goal|{base.GetShortName()}|{base.GetDesc()}|{base.GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
        return fileString;
    }



}