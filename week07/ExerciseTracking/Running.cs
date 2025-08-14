
public class Running : Activity
{
    // Member variable
    private double _distance; // distance in miles

    // Constructor
    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed = (distance / minutes) * 60 to convert to per hour
        return (_distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        // Avoid dividing by zero
        if (_distance == 0)
        {
            return 0;// No distance means pace is zero
        }

        // Pace = minutes / distance
        return LengthInMinutes / _distance;
    }
}