public class Reference
{ // possible getters and setters

    string _book;
    int _chapter;
    int _verse;
    int _endVerse;



    public string GetDisplayText()
    {
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