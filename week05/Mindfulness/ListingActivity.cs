using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{

    List<string> _questions = new List<string>();

    public ListingActivity()
    {
        base.SetDesc("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
    }
    public string GetRandomPrompt()
    {
        return "";
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
    }

    public void AddQuestion(string theQuestion)
    {
        _questions.Add(theQuestion);
    }

}