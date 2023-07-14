using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List <Activity> _activities = new List<Activity>();
        Running R1 = new Running("03 Nov 2023", 30, 4.8);  //Running(date, lenght, distance)
        // R1.GetSumary(R1);
        _activities.Add(R1);

        Cycling C1 = new Cycling("09 Nov 2023", 20, 15.3);  //Cycling(date, lenght, speed)
        // C1.GetSumary(C1);
        _activities.Add(C1);

        Swimming S1 = new Swimming("01 Dec 2023", 15, 40);  //Swimming(date, lenght, laps)
        // S1.GetSumary(S1);
        _activities.Add(S1);

        foreach (Activity x in _activities)
        {
            x.GetSumary(x);
        }

    }
}