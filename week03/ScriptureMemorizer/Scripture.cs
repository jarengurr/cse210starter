public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();
    


    public Scripture(Reference myRef, string scriptText)
    {
       
        _reference = myRef;
        string[] myWords = scriptText.Split(" ");
        //Console.WriteLine(myWords[0]);

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
        //Console.WriteLine(_words[10].GetDisplayText());
        //Console.WriteLine(myWords[0]);
    }
    public void HideRandomWords(int numberToHide)
    {
        int holdNum;
        Random randomNum = new Random();
        //for (int i = 0; i < (numberToHide); i++)
        //{
        //    holdNum = randomNum.Next(0, _words.Count + 1);
        //    _words[holdNum].Hide();// will set hidden to true
        //    Console.WriteLine(holdNum);
        //    Console.WriteLine(_words.Count);
        //}
        int i = 0;
        while (i < numberToHide)
        {
            holdNum = randomNum.Next(0, _words.Count);
            if (!_words[holdNum].IsHidden())
            {
                _words[holdNum].Hide();// will set hidden to true
                i = i + 1;
            }
                
            if (IsCompletelyHidden())
            {
                i = 3;
            }

        }
    }

    public string GetDisplayText()//some words visible some not visible
    {
        string holdScripture = "";
        for (int i = 0; i < _words.Count; i++)
        {
            holdScripture = holdScripture + " " + _words[i].GetDisplayText();
        }
        return holdScripture;
    }

    public bool IsCompletelyHidden()
    {
        int holdHidCount = 0;
        for (int i = 0; i < (_words.Count); i++)
        {//check each word and see if it is hidden
            if (_words[i].IsHidden())
            {
                holdHidCount = holdHidCount + 1;
            }
        }

        if (holdHidCount == _words.Count)
            return true;
        else
            return false;
    }
}