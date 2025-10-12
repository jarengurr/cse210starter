using Microsoft.VisualBasic;

public class GoalManager
{
    List<Goal> _myGoals = new List<Goal>();
    int _score;


    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        int holdNum = 0;
        string holdRead;



        while (holdNum != 6)
        {


            Console.WriteLine();
            Console.WriteLine("Please select one of the choices:  ");
            Console.WriteLine("1. Create a new goal ");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6, Quit ");
            holdRead = Console.ReadLine();
            if (holdRead == "")
                holdRead = Console.ReadLine();
            holdNum = Convert.ToInt32(holdRead); // check number


            switch (holdNum)
            {
                case 1:
                    CreateGoal();


                    break;
                case 2:

                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();


                    break;
                case 4:

                    LoadGoals();
                    break;
                case 5:

                    RecordEvent();
                    break;
                case 6:
                    holdNum = 6;
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 6");
                    break;
            }




        }
    }

    public void DisplayPlayerTotal()
    {
        Console.WriteLine($"Total points are {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i< _myGoals.Count; i++)
        {
            Console.WriteLine(_myGoals[i].GetShortName());
        }
    }

    public void ListGoalDetails()
    {
         for (int i = 0; i< _myGoals.Count; i++)
        {
            Console.WriteLine(_myGoals[i].GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        string holdRead;
        int holdNum = 0;
        string holdName;
        string holdDesc;
        string holdPoints;
        int holdBonusTimes;
        int holdBonusPoints;




        Console.WriteLine();
        Console.WriteLine("Please select one of the choices:  ");
        Console.WriteLine("1. Simple Goal (One event goal)");
        Console.WriteLine("2. Checklist Goal (limited number of events)");
        Console.WriteLine("3. Eternal Goal ( unlimited events)");
        Console.WriteLine("4. Skip");
        Console.Write("  ENTER HERE:> ");
        holdRead = Console.ReadLine();
        if (holdRead == "")
            holdRead = Console.ReadLine();
        holdNum = Convert.ToInt32(holdRead); // check number


        switch (holdNum)
        {
            case 1:

                Console.WriteLine("What is your goals name? ");
                holdName = Console.ReadLine();
                Console.WriteLine("Please give a short description of your goal. ");
                holdDesc = Console.ReadLine();
                Console.WriteLine("How many point will be given when goal is completed? ");
                holdPoints = Console.ReadLine();


                SimpleGoal myGoal = new SimpleGoal(holdName, holdDesc, holdPoints);
                _myGoals.Add(myGoal);
                myGoal = null;

                break;
            case 2:

                Console.WriteLine("What is your goals name? ");
                holdName = Console.ReadLine();
                Console.WriteLine("Please give a short description of your goal. ");
                holdDesc = Console.ReadLine();
                Console.WriteLine("How many point will be given when goal is completed? ");
                holdPoints = Console.ReadLine();
                Console.WriteLine("You will recieve a bonus if you complete this goal how many times? ");
                holdBonusTimes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"What is the bonus for completing your goal {holdBonusTimes} times?  ");
                holdBonusPoints = Convert.ToInt32(Console.ReadLine());
                CheckListGoal myGoal2 = new CheckListGoal(holdName, holdDesc, holdPoints, holdBonusTimes, holdBonusPoints, 0);
                _myGoals.Add(myGoal2);
                myGoal2 = null;

                break;
            case 3:

                Console.WriteLine("What is your goals name? ");
                holdName = Console.ReadLine();
                Console.WriteLine("Please give a short description of your goal. ");
                holdDesc = Console.ReadLine();
                Console.WriteLine("How many points will be given when goal is completed? ");
                holdPoints = Console.ReadLine();


                EternalGoal myGoal3 = new EternalGoal(holdName, holdDesc, holdPoints);
                _myGoals.Add(myGoal3);
                myGoal3 = null;

                break;
            case 4:


                break;

            default:
                Console.WriteLine("Please enter a number between 1 and 4");
                break;
        }
    }


    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        using (StreamWriter myFile = new StreamWriter("Info.txt",false))
        {
            foreach (Goal hold in _myGoals)
            {
                myFile.WriteLine(hold.GetStringRepresentational());
            }
                
        }
    }

    public void LoadGoals()
    {
        
    }






}