
public class ChecklistGoal: Goal //inherits from the base class Goal
{
    // Member Variable
    private int _amountCompleted;// how many times the goal has been completed so far.
    private int _target;// how many times the goal needs to be completed to count as “done.”
    private int _bonus;// extra points awarded if the goal is finished completely

    // Construction(runs when create a ChecklistGoal object.)
    //amountComplete (optional, default is 0) → starting progress if the goal was already partially done.
    public ChecklistGoal(string goalName, string description, int points, int target, int bonus, int amountComplete = 0)
        : base(goalName, description, points) // call the base class constructor 
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountComplete;
    }

    //Method
    // Method to mark progress towards the goal
    public override int RecordEvent(GoalManager manager)
    {
        _amountCompleted++;//Increase the number of times completed by 1 
        manager.AddScore(_points); // Add the points for completing once to the user's total score
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        // Check if the target number of completions has been reached
        if (_amountCompleted == _target)
        {
            manager.AddScore(_bonus);// Add the bonus points to the user's score
            // Let the user know about the bonus points
            Console.WriteLine($"Bonus! You have earned {_bonus} extra points!");
        }

        return _points;
    }

    // Method to check if the goal is complete
    public override bool GoalIsComplete()
    {
        // Returns true if the amount completed is equal or more than the target
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
        //return _amountCompleted >= _target; (short version of if else)
    }

    // Method to display the goal's info in a readable format
    public override string DisplayGoalInfo()
    {
        // Create a checkbox string: [X] if complete, [ ] if not complete
        // ? means "if _isComplete is true" "[x]"
        // : means "otherwise" "[ ]"
        string checkbox = GoalIsComplete() ? "[X]" : "[ ]";
        // Return a formatted string showing the checkbox, name, description, and progress
        return $"{checkbox} {_goalName} ({_description})-- Currently completed: {_amountCompleted}/{_target}";
    }

    // Method to save the goal's data as a string (e.g., to save to a file)
    public override string SaveGoalData()
    {
        return $"ChecklistGoal: {_goalName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }
}

