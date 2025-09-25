using System.Data.Common;


public class Entry()
{
    public string _date;
    public string _promptText;
    public string _entryText;

    //PromptGenerator myGenerator = new PromptGenerator();

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
        Console.WriteLine($"{_date} THE QUESTION: {_promptText} ENTRY TEXT: {_entryText}");

    }

    public void EnterTextOnly()
    {
        Console.WriteLine("Enter Text to answer the question here:>  ");
       
        _entryText = Console.ReadLine();
        _promptText = "No question";    
        _date = DateTime.Now.ToString();

    }
     public void EnterTextPlusQuestion(string promptText)
    {
        _promptText = promptText;
        Console.WriteLine(_promptText);
        Console.WriteLine("Enter Text to answer the question here:>  ");
        _entryText = Console.ReadLine();
      
        _date = DateTime.Now.ToString();

    }





}