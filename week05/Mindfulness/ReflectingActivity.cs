using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();




    public ReflectingActivity()
    {
        base.SetDesc("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you relize the power you have to effect other aspect of your life");
        base.SetName("Reflecting Activity");
         
    }
    public string GetRandomPrompt()
    {
        int randNum;
        int maxNum;
        maxNum = _prompts.Count;
        Random randomNumber = new Random();
        randNum = randomNumber.Next(0,maxNum);

        return _prompts[randNum];
    }

    public string GetRandomQuestion()
    {
         int randNum;
        int maxNum;
        maxNum = _prompts.Count;
        Random randomNumber = new Random();
        randNum = randomNumber.Next(0,maxNum);
        return _questions[randNum];
    }

    public void Run()
    {

        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine();
        Console.WriteLine();
        base.DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" How long, in seconds, would you like for your session? ");
        int holdTime = Convert.ToInt32(Console.ReadLine());
        base.SetDuration(holdTime);
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        //Console.WriteLine(GetRandomPrompt());
        Console.CursorVisible = false;
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to contune. ");
        Console.Read();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in:  ");
        ShowCountDown(4);
        Console.WriteLine();
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(holdTime);
        
        while (DateTime.Now < endTime)
        {
            Console.CursorVisible = false;
            Console.Write(GetRandomQuestion());
            ShowSpinner(5);
            Console.WriteLine();

        }
        Console.CursorVisible = true;// make cursor visible
        Console.WriteLine();


        DisplayEndingMessage();

    }

    public void DisplayPrompt()
    {
        string holdPrompt;
        holdPrompt = GetRandomPrompt();
        Console.WriteLine(holdPrompt);
    }
    public void DisplayQuestions()
    {

    }
    public void AddPrompt(string aPrompt)
    {
        _prompts.Add(aPrompt);
    }

    public void AddQuestion(string aQuestion)
    {
        _questions.Add(aQuestion);
    }

}