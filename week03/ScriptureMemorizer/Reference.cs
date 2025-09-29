public class Reference
{ // possible getters and setters

    private string _book;
    
    private int _chapter;
    private int _verse;
    private int _endVerse;



    public string GetDisplayText()
    {
        Console.Write($" {_book} {_chapter}:{_verse  }");
        return "yy";
    }
    public void SetBook(string theBook)
    {
        _book = theBook;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetChapter(int theChapter)
    {
        _chapter = theChapter;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public void SetVerse(int theVerse)
    {
        _verse = theVerse;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public void SetEndVerse(int theEndVerse)
    {
        _endVerse = theEndVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

   
}