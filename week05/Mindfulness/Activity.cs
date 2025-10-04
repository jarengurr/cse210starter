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
//
        //}
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
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
    }

    public void ShowCountDown(int seconds)
    {
       
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