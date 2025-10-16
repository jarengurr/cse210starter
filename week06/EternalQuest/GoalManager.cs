using Microsoft.VisualBasic;

public class GoalManager
{
    private List<Goal> _myGoals = new List<Goal>();
    private int _score;


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

            Console.WriteLine($" You have {_score} points");
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
            Console.WriteLine($"{i + 1} {_myGoals[i].GetShortName()}");
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

                EternalGoal myGoal4 = new EternalGoal("holdName", "holdDesc", "holdPoints");
                Console.WriteLine(myGoal4.GetType());
                break;

            default:
                Console.WriteLine("Please enter a number between 1 and 4");
                break;
        }
    }


    public void RecordEvent()
    {
        Console.WriteLine("The Goals are: ");
        ListGoalNames();
        string holdRead = Console.ReadLine();
        int holdNum = Convert.ToInt32(holdRead);
        _myGoals[holdNum-1].RecordEvent();
        _score = _score + Convert.ToInt32(_myGoals[holdNum-1].GetPoints());
        string holdType = Convert.ToString(_myGoals[holdNum-1].GetType());
        if ( holdType !="CheckListGoal")
        {
            //Console.WriteLine("im in");
        }

    }

    public void SaveGoals()
    {
        using (StreamWriter myFile = new StreamWriter("Info.txt",false))
        {
            myFile.WriteLine(_score);
            foreach (Goal hold in _myGoals)
            {
                myFile.WriteLine(hold.GetStringRepresentational());
            }
                
        }
    }

    public void LoadGoals()
    {
        string fileName = "info.txt";
        int target = -1;
        int bonus = -1;

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string aLine in lines)
        {
            string[] word = aLine.Split("*");
            int holdIt = word.Length;
            if ( holdIt == 1)
            {
                _score = Convert.ToInt32(word[0]);
            }
            if (word[0] == "Eternal Goal")
            {
                EternalGoal myGoal = new EternalGoal(word[1], word[2], word[3]); //word1 = name, word2 = desc, word3 = points
               
            }
            if (word[0] == "Simple Goal")
            {
                SimpleGoal myGoal = new SimpleGoal(word[1], word[2], word[3]); //word1 = name, word2 = desc, word3 = points
                _score = Convert.ToInt32(word[0]);
                myGoal.SetIsComplete(Convert.ToBoolean(word[4]));                
            }
            if (word[0] == "CheckList Goal")
            {
                CheckListGoal myGoal = new CheckListGoal(word[1], word[2], word[3], Convert.ToInt32(word[4]), Convert.ToInt32(word[5]), Convert.ToInt32(word[6]));
                //word1 = name, word2 = desc, word3 = points, word4= target, word5 = bonus, word6 = what is completed
                target = Convert.ToInt32(word[4]);
                bonus = Convert.ToInt32(word[5]);
                
            }



        }
        

    }






}