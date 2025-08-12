using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // Member variables
    private List<Goal> _goals = new List<Goal>(); // List to store all goals
    private int _score = 0; // user's total score (points earned)

    // Constructor
    public GoalManager()
    {
        // Initialize if needed
    }

    // Show current total points
    public void DisplayInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    // display the names of all the goals in the _goals list
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        //go through every goal in the _goals list, i starts at 0, because lists are zero-indexed 
        // Keep looping while i is less than the total number of goals
        for (int i = 0; i < _goals.Count; i++)
        {
            //Get the goal name from the goal object
            //call GetGoalName() instead of trying to access _goalName directly
            string goalName = _goals[i].GetGoalName();

            // Show the goal number (i+1 makes it readable starting from 1)
            Console.WriteLine($"{i + 1}. {goalName}");
        }
    }

    // List detailed information about each goal
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        //go through every goal in the _goals list, i starts at 0, because lists are zero-indexed 
        // Keep looping while i is less than the total number of goals
        for (int i = 0; i < _goals.Count; i++)
        {
            //Call DisplayGoalInfo() to get the details for this goal
            string goalDetails = _goals[i].DisplayGoalInfo();
            // Show the goal number (i+1 so it starts at 1 for humans)
            // plus the goal details
            Console.WriteLine($"{i + 1}. {goalDetails}");
        }
    }

    // Create a new goal based on user input
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }
    }

    // Record that a goal was completed and update score
    public void RecordEvent()
    {
        //Check if there are any goals to work with
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
            return; // Stop here because there’s nothing to mark as complete
        }

        // Show all goals by name
        Console.WriteLine("Here is a list of your goals:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? Enter number:");
        string userInput = Console.ReadLine(); // Get their input as text
        int choice = int.Parse(userInput); // Convert it into a number  
                                            //Adjust because our list starts at 0, but the user sees 1-based numbering
        int goalIndex = choice - 1;

        // Check if choice is valid
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;// Stop the method — don’t try to mark something that doesn’t exist
        }

        //Tell the specific goal to mark progress
        _goals[goalIndex].RecordEvent(this);
    }

    // adds points to the player's total score
    public void AddScore(int points)
    {
        // Add the points to the current score
        _score = _score + points;

        Console.WriteLine($"{points} points added! Your total score is now {_score}.");
    }

    // save the user's score and goals to a text file
    public void SaveGoals()
    {
        //Ask the user for the file name
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        //Open the file for writing
        // "using" makes sure the file is closed automatically when done
        using (StreamWriter writer = new StreamWriter(filename))
        {
            //Save the total score as the first line in the file
            writer.WriteLine(_score);
            //Loop through each goal and save its data
            foreach (Goal goal in _goals)
            {
                // Each goal knows how to save itself using its own method
                string goalData = goal.SaveGoalData();
                writer.WriteLine(goalData);
            }
        }

        Console.WriteLine("Your goals have been saved successfully!");
    }

    // Load goals and score from file
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // Check if the file exists
        if (!File.Exists(filename))
        {
            Console.WriteLine("Sorry, the file does not exist.");
            return; // Exit the method because there is nothing to load
        }

        // Read all the lines from the file into an array of strings
        string[] lines = File.ReadAllLines(filename);
        // The first line is the total score, convert it from text to an integer
        _score = int.Parse(lines[0]);
        // Clear the current goals list so we can add fresh data
        _goals.Clear();

        // Start reading the goals from the second line (index 1)
        for (int i = 1; i < lines.Length; i++)
        {
            // Each line has a goal type, followed by a colon, then goal data
            // Split the line into two parts at the colon
            string[] parts = lines[i].Split(':');

            // The first part is the type of goal (e.g., "SimpleGoal")
            string type = parts[0];
            // The second part contains the goal details separated by commas
            string[] data = parts[1].Split(',');


            // Based on the type, create the appropriate Goal object
            if (type == "SimpleGoal")
            {
                // Create a new SimpleGoal object using the data parts

                _goals.Add(new SimpleGoal(
                    data[0].Trim(),             // Goal name
                    data[1].Trim(),             // Description
                    int.Parse(data[2]),         // Points
                    bool.Parse(data[3])         // Whether it is complete
                ));
            }
            else if (type == "EternalGoal")
            {
                // Create a new EternalGoal object using the data parts
                _goals.Add(new EternalGoal(
                    data[0].Trim(),             // Goal name
                    data[1].Trim(),             // Description
                    int.Parse(data[2])          // Points
                ));
            }
            else if (type == "ChecklistGoal")
            {
                // Create a new ChecklistGoal object using the data parts
                _goals.Add(new ChecklistGoal(
                    data[0].Trim(),             // Goal name
                    data[1].Trim(),             // Description
                    int.Parse(data[2]),         // Points
                    int.Parse(data[4]),         // Target count
                    int.Parse(data[3]),         // Bonus points
                    int.Parse(data[5])          // Amount completed so far
                ));
            }
            else
            {
                Console.WriteLine($"Unknown goal type: {type}");
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
