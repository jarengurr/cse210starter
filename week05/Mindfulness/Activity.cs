using System.Security.AccessControl;

public class Activity
{

    private string _name;
    private string _description;
    private int _duration;


    public Activity()
    {
        //_name = name;
        //_description = description;
       // _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        string endMsg = "You have done a good job.";
        Console.WriteLine(endMsg);
        ShowSpinner(7);//Thread.Sleep(3000);
        Console.WriteLine($"You have completed the {_name} in {_duration} seconds");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> holdStrings = new List<string>();
        holdStrings.Add("|");
        holdStrings.Add("/");
        holdStrings.Add("-");
        holdStrings.Add("\\");
        holdStrings.Add("|");
        holdStrings.Add("/");
        holdStrings.Add("-");
        holdStrings.Add("\\");

        //foreach (string s in holdStrings)
        //{
        //    Console.Write(s);
        //    Thread.Sleep(1000);
        //    Console.Write("\b \b");
        Console.CursorVisible = false;// make cursor invisible
        //}
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            // Console.Write(".");
            //Thread.Sleep(1000);
            string holdInfo = holdStrings[i];
            Console.Write(holdInfo);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= holdStrings.Count)
            {
                i = 0;
            }
        }
        Console.CursorVisible = true;// make cursor visible
    }

    public void ShowCountDown(int seconds)
    {
         for (int i = seconds; i > 0; i--)
            {

                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
       

    }
    protected void SetDesc(string desc)
    {
        _description = desc;
    }

    protected void SetName(string name)
    {
        _name = name;
    }

    protected void SetDuration(int theNum)
    {
        _duration = theNum;
    }

    protected int GetDuration()
    {
        return _duration;
    }
}