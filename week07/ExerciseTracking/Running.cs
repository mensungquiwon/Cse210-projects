using System;

public class Running : Activity
{
    private double _distance; // total distance of the run (miles if using imperial)

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // mph = miles / hours
        double hours = GetMinutes() / 60.0;
        return _distance / hours;
    }

    public override double GetPace()
    {
        // minutes per mile
        return GetMinutes() / _distance;
    }

    // Optional richer summary (if you want one specific to Running)
    public new string GetSummary()
     {
        return $"{GetDate()} Running ({GetMinutes()} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace {GetPace():0.00} min/mi";
 }
}