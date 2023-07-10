using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List <Activity> _activities = new List<Activity>();
        Running R1 = new Running("03 Nov 2023", 30, 4.8);
        // R1.GetSumary(R1);
        _activities.Add(R1);

        Cycling C1 = new Cycling("09 Nov 2023", 25, 6.5);
        // C1.GetSumary(C1);
        _activities.Add(C1);

        Swimming S1 = new Swimming("01 Dec 2023", 40, 620);
        // S1.GetSumary(S1);
        _activities.Add(S1);

        foreach (Activity x in _activities)
        {
            x.GetSumary(x);
        }

    }
}

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
        return GetDistance() / _lenght;
    }
}