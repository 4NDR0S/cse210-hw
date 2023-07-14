class Activity
{
    protected string _date;
    protected double _lenght;

    public Activity(string date, double lenght)
    {
        _date = date;
        _lenght = lenght; // in minutes
    }

    public void GetSumary(Activity x)
    {
        if (x is Running)
        {
            Console.WriteLine($"{_date} Running ({_lenght} min) - Distance {GetDistance().ToString("F2")} km, Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace().ToString("F2")} min per km)");
        }

        if (x is Cycling)
        {
            Console.WriteLine($"{_date} Cycling ({_lenght} min) - Distance {GetDistance().ToString("F2")} km, Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace().ToString("F2")} min per km)");
        }

        if (x is Swimming)
        {
            Console.WriteLine($"{_date} Swimming ({_lenght} min) - Distance {GetDistance().ToString("F2")} km, Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace().ToString("F2")} min per km)");
        }
    }
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
}