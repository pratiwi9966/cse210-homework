public class MathAssignment : Assignment
{
    // Member variables 
    private string _textbookSection;
    private string _problems;

    // Constructor: 
    //  only the base class (Assignment) knows how to store studentName and topic. 
    // The derived class shouldn't (and can't) access the private fields of the base class directly.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic) // these 2 variables are from "Assignment class",
    // means “Hey base class"Assignment class", you take care of your own part.”
    {
        // And then the derived class handles its own variable
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}