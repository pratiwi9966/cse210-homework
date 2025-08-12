using System;

    public abstract class Goal
    {
        // Member variable
        protected string _goalName;
        protected string _description;
        protected int _points;

        // Constructor
        public Goal(string goalName, string description, int points)
        {
            _goalName = goalName;
            _description = description;
            _points = points;
        }

        // let other classes safely get the goal's name
        public string GetGoalName()
        {
            return _goalName; // return the value stored in _goalName
        }

        // Abstract Method
        public abstract int RecordEvent(GoalManager manager);

        // Method to check if the goal is complete
        public abstract bool GoalIsComplete();

        // Method to display the goal's info in a readable format
        // if use 'abstract' there is no default behavior in the base class.
        // use 'virtual'means the base class provides a default version.
        public virtual string DisplayGoalInfo()
        {
            return $"{_goalName} ({_description})";
        }

        // Method to save the goal's data as a string (e.g., to save to a file)
        public abstract string SaveGoalData();

    }
