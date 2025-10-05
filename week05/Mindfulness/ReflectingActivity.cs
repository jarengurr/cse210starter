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
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
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

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have somjething in mind, press enter to contune. ");
        Console.Read();
        Console.WriteLine("Now ponder on each of the folling questions as they related to this experience.");
        Console.WriteLine("You may begin in : ");


    }

    public void DisplayPrompt()
    {

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