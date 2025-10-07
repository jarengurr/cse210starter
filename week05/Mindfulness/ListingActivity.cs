using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{

    private List<string> _questions = new List<string>();

    public ListingActivity()
    {
        base.SetDesc("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
        base.SetName("Listing Activity");
         
    }
    public string GetRandomPrompt()
    {
        int randNum;
        int maxNum;
        maxNum = _questions.Count;
        Random randomNumber = new Random();
        randNum = randomNumber.Next(0,maxNum);
        return _questions[randNum];
    }

    public List<string> GetListFromUser(List<string> holdList)
    {
        return holdList;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine();
        base.DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" How long, in seconds, would you like for your session? ");
        int holdTime = Convert.ToInt32(Console.ReadLine());
        base.SetDuration(holdTime);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        string holdPrompt = GetRandomPrompt();
        Console.WriteLine(holdPrompt);
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.WriteLine();
        string holdNewLine;
        int J = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(holdTime);

        while (DateTime.Now < endTime)
        {
            holdNewLine = Console.ReadLine();
            if (holdNewLine != "")
            {
                J = J + 1;
            }
        }
        Console.WriteLine($"You listed {J} items!");
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(7);

    }

    public void AddQuestion(string theQuestion)
    {
        _questions.Add(theQuestion);
    }

}