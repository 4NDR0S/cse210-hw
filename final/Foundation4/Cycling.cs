class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double lenght, double speed) : base (date, lenght)
    {
        _speed = speed;
    }

    public override double GetDistance() // in kilometers
    {
        return _speed / 60 * _lenght;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}