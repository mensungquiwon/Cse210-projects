using System;
using System.ComponentModel;

public class Swimming : Activity
{
    private int _laps; // number of 50-meter laps

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert 50m laps to miles
        double meters = _laps * 50.0;
        return meters / 1609.34; // miles
    }

    public override double GetSpeed()
    {
        double hours = GetMinutes() / 60.0;
        return GetDistance() / hours; // mph
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance; // min per mile
    }


}