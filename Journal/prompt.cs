
public class PromptGenerator()
{
    public List<string> _prompts = new List<string>();
    public string[] _myList;
    public int count = 0;


    public void GetQuestion(string question)
    {
        _prompts[count] = question;
        count = count + 1;
    }


    public string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        return _prompts[randomNumber.Next(1, count + 1)];
    }

    public void GetFile()
    {
        string filename = "Journal.txt";
        string[] _prompts2 = System.IO.File.ReadAllLines(filename);
        int hold;

        hold = _prompts2.Count();
        Console.WriteLine(_prompts2[2]);
        hold = _myList.Count();
        Console.WriteLine(_myList[2]);
    }  


}



