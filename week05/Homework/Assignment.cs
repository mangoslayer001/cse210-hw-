public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        // Example: "Samuel Bennett - Multiplication"
        return $"{_studentName} - {_topic}";
    }

    // Helper so derived classes can get the student's name
    public string GetStudentName()
    {
        return _studentName;
    }

    // (Optional) if you ever need the topic:
    public string GetTopic()
    {
        return _topic;
    }
}
