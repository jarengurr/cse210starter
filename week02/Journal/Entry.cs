using System.Data.Common;


public class Entry()
{
    public string _date;
    public string _promptText;
    public string _entryText;

    //PromptGenerator myGenerator = new PromptGenerator();

    public string GetDate()
    {
        return _date; 
    }

    public void SetDate(string newDate)
    {
        _date = newDate;
    }

    public string GetPrompt()
    {
        return _promptText;
    }

    public void SetPrompt(string newPromptText)
    {
        _promptText = newPromptText;
    }

    public string GetEntryText()
    {
        return _entryText;
    }


        public void SetEntryText(string newEntryText)
    {
        _entryText = newEntryText;
    }
    public void Display()
    {
        Console.WriteLine($"{_date} THE QUESTION: {_promptText} ENTRY TEXT: {_entryText}");

    }

    public void EnterTextOnly(Journal myJournal)
    {
        Console.WriteLine("Enter Text to answer the question here:>  ");

        _entryText = Console.ReadLine();
        _promptText = "No question";
        _date = DateTime.Now.ToString();
        Entry myWords2 = new Entry(); // second entry just to add to journal then set to null
        myWords2.SetDate(_date);
        myWords2.SetEntryText(_entryText);
        myWords2.SetPrompt(_promptText);
        myJournal.AddEntry(myWords2);
        myWords2 = null;


    }
    public void EnterTextPlusQuestion(string promptText, Journal myJournal)
    {
        _promptText = promptText;
        Console.WriteLine(_promptText);
        Console.WriteLine("Enter Text to answer the question here:>  ");
        _entryText = Console.ReadLine();

        _date = DateTime.Now.ToString();
        
         Entry myWords2 = new Entry(); // second entry just to add to journal then set to null
        myWords2.SetDate(_date);
        myWords2.SetEntryText(_entryText);
        myWords2.SetPrompt(_promptText);
        myJournal.AddEntry(myWords2);
        myWords2 = null;


    }





}