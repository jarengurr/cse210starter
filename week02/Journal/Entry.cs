using System.Data.Common;
using System.Net.Mail;

public class Entry()
{
    string _date;
    string _promptText;
    string _entryText;

     PromptGenerator myGenerator = new PromptGenerator();

    public void Display()
    {
        _date = "July 5 2025";


        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }

    public void EnterTextOnly()
    {
        Console.WriteLine("Enter Text here:>  ");
        _entryText = Console.ReadLine();
        _promptText = "none";
        _date = DateTime.Now.ToString("DD/MM/YYYY");

    }
     public void EnterTextPlusQuestion()
    {
        
        _promptText = myGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.WriteLine("Enter Text here:>  ");
        _entryText = Console.ReadLine();
       
        _date = DateTime.Now.ToString("DD/MM/YYYY");

    }





}