

public class Swimming : Activity
{
    // Member variable
    private int _laps; // number of laps

    // 1 lap = 50 meters
    private double _lapLengthMeters = 50;

    // Constructor
    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to miles (1 meter = 0.000621371 miles)
        double totalMeters = _laps * _lapLengthMeters;
        double totalMiles = totalMeters * 0.000621371;
        return totalMiles; // distance in miles  
    }   
    
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / LengthInMinutes) * 60; // speed in mph
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        
        // Avoid dividing by zero
        if (distance == 0)
        {
            return 0;
        }

        return LengthInMinutes / distance; // minutes per mile
    }
}
