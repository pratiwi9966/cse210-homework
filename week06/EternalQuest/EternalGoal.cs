
public class EternalGoal : Goal //inherits from the base class Goal
{
    // no Member variable

    // Constructor ( It runs when you create an EternalGoal.)
    public EternalGoal(string goalName, string description, int points)
        :base(goalName, description, points)// call the base class constructor
    { }

    //Method
    // Method to mark progress towards the goal,they get points (eternal goals never "complete")
    public override int RecordEvent(GoalManager manager)
    {
        //Call manager.AddScore(_points)to add the goal's points to the use's score (GoalManager handles score)
        manager.AddScore(_points);
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
    
    // Method to check if the goal is complete
    // Eternal goals never complete, so always return false
    public override bool GoalIsComplete()
    {
        return false; // Eternal goals never complete and can be recorded many times
    }

    // Method to display the goal's info in a readable format
    public override string DisplayGoalInfo()
    {
        return $"[ ] {_goalName} ({_description})";
    }

    // Method to save the goal's data as a string (e.g., to save to a file)
    public override string SaveGoalData()
    {
        return $"EternalGoal: {_goalName}, {_description}, {_points}";
    }
}