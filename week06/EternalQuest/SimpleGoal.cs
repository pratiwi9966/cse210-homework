using System;
public class SimpleGoal : Goal //inherits from the base class Goal
{
    // Member Variable
    private bool _isComplete; // stores whether the goal is done (true) or not (false)

    // Constructor (A constructor runs when you create a new SimpleGoal.)
    public SimpleGoal(string goalName, string description, int points, bool isComplete = false)
        : base(goalName, description, points)
    {
        _isComplete = isComplete;
    }

    //Method (Override)
    public override int RecordEvent(GoalManager manager)
    {
        // _isComplete = true; //mark this simple goal as completed.
        // manager.AddScore(_points); //add the goal’s points to the user’s total (via the GoalManager object passed in).
        // Console.WriteLine($"Congratulations! You have earned {_points} points!");
        // return _points;

        if (!_isComplete) // Only add points if not complete yet
        {
            _isComplete = true;
            manager.AddScore(_points);
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    // Method to check if the goal is complete
    //Returns true if the goal is complete, otherwise false
    public override bool GoalIsComplete()
    {
        return _isComplete;
    }

    // Method to display the goal's info in a readable format
    public override string DisplayGoalInfo()
    {
        // Create a checkbox string: [X] if complete, [ ] if not complete
        // ? means "if _isComplete is true" "[x]"
        // : means "otherwise" "[ ]"
        string checkbox = _isComplete ? "[x]" : "[ ]";

        return $"{checkbox} {_goalName} ({_description})";
    }

    // Method to save the goal's data as a string (e.g., to save to a file)
    public override string SaveGoalData()
    {
        return $"SimpleGoal:{_goalName}, {_description}, {_points}, {_isComplete}";
    }

}