public class Reference
{ // possible getters and setters

    private string _book;
    
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(String book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()//to go into scripture constructor
    {
        if (_endVerse == 0)
        {
            string myString = $" {_book} {_chapter}:{_verse}";
            return myString;
        }
        else
        {
            string myString = $" {_book} {_chapter}:{_verse}-{_endVerse}";
            return myString;
        }
            
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