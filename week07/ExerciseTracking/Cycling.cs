
public class Cycling : Activity
{
    // Member variable
    private double _speed; // speed in mph

    // Constructor
    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    //Override Methods
    public override double GetDistance()
    {
        // Distance = speed * (minutes/60)
        return _speed * (LengthInMinutes / 60.0);
        //Since LengthInMinutes is in minutes, divide by 60.0 to convert it to hours.
    }

    public override double GetSpeed()
    {
        return _speed; // mph
    }

    public override double GetPace()
    {
        // Avoid dividing by zero
        if (_speed == 0)
        {
            return 0;
        }

        // Pace = 60 / speed   
        return 60 / _speed; // min per mile
    }
}