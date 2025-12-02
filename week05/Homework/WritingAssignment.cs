public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Example: "The Causes of World War II by Mary Waters"
        string studentName = GetStudentName(); // from base class
        return $"{_title} by {studentName}";
    }
}
