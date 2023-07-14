class Running : Activity
{
    private double _distance; // in kilometers
    public Running(string date, double lenght, double distance) : base (date, lenght)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }

    public override double GetPace()
    {
        return _lenght / _distance;
    }
}