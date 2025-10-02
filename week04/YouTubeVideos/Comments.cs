
public class Comments
{
    private string _person;
    private string _text;

    public Comments(string person, string text)
    {
        _person = person;
        _text = text;
    }

    public string GetComments()
    {
        string holdString = $" {_text}  by  {_person}";
        return holdString;
    }



}