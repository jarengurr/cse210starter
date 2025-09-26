public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();


    public Scripture(Reference myRef, string scriptText)
    {


        string[] myWords = scriptText.Split(" ");
        Console.WriteLine(myWords[0]);
        Console.WriteLine(myWords[1]);
        Console.WriteLine(myWords[2]);
    }
    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "25";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}