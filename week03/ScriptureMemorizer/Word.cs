public class Word
{
    private string _text;
    private bool _isHidden;



    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            string newWord = "";
            int holdWordCount = _text.Length;
            int i;
            for (i = 0; i < holdWordCount; i++)
            {
                newWord = newWord + "_";
            }

            return newWord;
        }
            
        else
            return _text;

        
    }
}