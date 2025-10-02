using System;
public class Video
{
    private string _title;
    private string _author;
    private int _time; // in seconds
    private int _commentCount;
    private List<Comments> _comments = new List<Comments>();


    public Video(string mainTitle, string theAuthor, int length)
    {
        _title = mainTitle;
        _author = theAuthor;
        _time = length; // in seconds
    }

    public void addComments(Comments theComment)
    {
        _comments.Add(theComment);
        _commentCount = _commentCount = 1;
    }


}