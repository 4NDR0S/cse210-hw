public class Assigment
{
    private string _studentName;
    private string _topic;

    public Assigment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        string text = $"{_studentName} - {_topic}";
        return text;
    }

}