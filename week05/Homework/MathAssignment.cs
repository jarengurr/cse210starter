public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string stdName, string myTopic, string myBook, string myProblem) : base(stdName, myTopic)
    {
        _problems = myProblem;
        _textbookSection = myBook;

    }

    public string GetHomeworkList()
    {
        string holdString = $" Section {_textbookSection}  Problems{ _problems}";
        return holdString;
    }
}