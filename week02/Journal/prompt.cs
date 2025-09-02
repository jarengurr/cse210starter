
public class PromptGenerator()
{
    public List<string> _prompts = new List<string>();
    public string[] _myList;
    public int count = 0; // count keeps amount of questions


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
        string[] prompts2 = System.IO.File.ReadAllLines(filename);
        int hold;
        hold = prompts2.Count();
        for (int i = 1; i < hold; i++)
        {

        }
        
        Console.WriteLine(prompts2[1]);
        // hold = _myList.Count();
        hold = prompts2.Count();
        Console.WriteLine(prompts2[2]);
        Console.WriteLine(prompts2[3]);
        Console.WriteLine(prompts2[4]);
        Console.WriteLine(prompts2[5]);
        
        Console.WriteLine(hold);
        
    }  


}



