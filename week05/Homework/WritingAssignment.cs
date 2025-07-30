public class WritingAssignment : Assignment
{
    // Member variable
    private string _title;

    // Constructor
    // Call the constructor in the Assignment class and give it studentName and topic, 
    // because those belong to the base class.
    // in other word, I need all 3 values. I’ll give 2 to the parent, and I’ll handle 1 myself.
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        // And the derived class handles its own variable
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}