using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // Event # 1
        Address addressL1 = new Address("Los Eucaliptos 150", "Lima");
        Lectures L1 = new Lectures("Leader Training", "This training is about: 'The emotional well-being of members'.", "07/08/2023", "7:00 pm.", addressL1, "Sandra Ramirez", 140);
        L1.DisplayStandard();
        L1.DisplayFull(L1);
        L1.DisplayShort(L1);

        // Event # 2
        Address addressR1 = new Address("1299 E Santa Clara St", "San Jose");
        Receptions R1 = new Receptions("Graduation", "Graduation Party class of 2023.", "07/20/2023", "5:50 pm.", addressR1, "Reception_20@gmail.com");
        R1.DisplayStandard();
        R1.DisplayFull(R1);
        R1.DisplayShort(R1);

        // Event # 3
        Address addressO1 = new Address("Newark Country Club 300 W Main St", "Newark");
        Outdoor O1 = new Outdoor("Family Evening at Newark Country Club", "Join us for a family evening with food, games, and dancing.", "08/11/2023", "1:45 pm.", addressO1, "25°C");
        O1.DisplayStandard();
        O1.DisplayFull(O1);
        O1.DisplayShort(O1);
    }
}