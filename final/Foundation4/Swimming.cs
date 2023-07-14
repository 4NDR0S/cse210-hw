class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, double lenght, int laps) : base (date, lenght)
    {
        _laps = laps;
    }

    public override double GetDistance() // in kilometers
    {
        return _laps * 50 / 1000; 
    }

    public override double GetSpeed()
    {
        return ( GetDistance() / _lenght ) * 60;
    }

    public override double GetPace()
    {
        return _lenght / GetDistance();
    }
}