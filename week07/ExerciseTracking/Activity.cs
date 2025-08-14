using System;
using System.Collections.Generic;

public abstract class Activity
{ 
    // member variables
    private DateTime _date;
    private int _lengthInMinutes;

    // Constructor to initialize date and length
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Property to get the date of the activity
    public DateTime Date
    {
        get
        {
            // Return the value stored in the _date field
            return _date;
        }
    }

    // Property to get the length of the activity in minutes
    public int LengthInMinutes
    {
        get
        {
            // Return the value stored in the _lengthInMinutes field
            return _lengthInMinutes;
        }
    }

    // Abstract methods 
    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // mph 
    public abstract double GetPace();     // min per mile 

    // Get summary (available to all derived classes)
    public virtual string GetSummary()
    {
        // this → Refers to the current object instance.
        // GetType() → A built-in method that returns a Type object describing this object’s class.
        // .Name → A built-in property of the Type class that gives just the class name as a string
        // Example: If this object is from the Running class, this will be "Running".
        // string typeText = this.GetType().Name;

        //"F2" rounds the number to 2 decimal places
         string summary = $"{_date:dd MMM yyyy} {this.GetType().Name} ({LengthInMinutes} min) - " +
                     $"Distance: {GetDistance():F2} miles, " +
                     $"Speed: {GetSpeed():F2} mkh, " +
                     $"Pace: {GetPace():F2} min per mile";
        return summary;
        
    }
}