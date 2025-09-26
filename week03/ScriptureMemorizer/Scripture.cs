public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();


    public Scripture(Reference myRef, string scriptText)
    {


        string[] myWords = scriptText.Split(" ");
        Console.WriteLine(myWords[0]);
       
        foreach (string singleWord in myWords)// 
        {
            if (singleWord != "")
            {
                Word aWord;//create new enty item to fill
                aWord = new Word(singleWord);
                _words.Add(aWord);// add each entry to journal
                aWord = null;
            }
        }
        Console.WriteLine(_words[10].GetDisplayText());
        Console.WriteLine(myWords[0]);
    }
    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()//some words visible some not visible
    {
        return "25";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}