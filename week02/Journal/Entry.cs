using System.Data.Common;
using System.Net.Mail;

public class Entry()
{
    string _date;
    string _promptText;
    string _entryText;

    PromptGenerator myGenerator = new PromptGenerator();

    public string getDate()
    {
        return _date; 
    }

    public void setDate(string newDate)
    {
        _date = newDate;
    }

    public string getPrompt()
    {
        return _promptText;
    }

    public void setPrompt(string newPromptText)
    {
        _promptText = newPromptText;
    }

    public string getEntryText()
    {
        return _entryText;
    }

    public void setEntryText(string newEntryText)
    {
        _entryText = newEntryText;
    }
    public void Display()
    {

        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }

    public void EnterTextOnly()
    {
        Console.WriteLine("Enter Text with no question here:>  ");
        _entryText = Console.ReadLine();
        _promptText = "No question";

        _date = DateTime.Now.ToString("DD/MM/YYYY");

    }
     public void EnterTextPlusQuestion()
    {
        
        _promptText = myGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.WriteLine("Enter Text to answer the question here:>  ");
        _entryText = Console.ReadLine();
       
        _date = DateTime.Now.ToString("DD/MM/YYYY");

    }





}