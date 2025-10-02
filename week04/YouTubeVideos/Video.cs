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
        _commentCount = _commentCount + 1;
    }

    public int GetCommentCount()
    {
        return _commentCount;
    }

    public string GetVideoInfo()
    {
        string holdString = $" TITLE {_title} AUTHOR {_author} LENGTH {_time} Seconds WITH {_commentCount} Comments";
        return holdString;
    }

    public string GetComments()
    {
        string holdComments = "";
        for (int i = 0; i < _comments.Count(); i++)
        {
            holdComments =  holdComments + $" {i+ 1}.{_comments[i].GetComments()}   ";
        }
        return holdComments;
    }
}