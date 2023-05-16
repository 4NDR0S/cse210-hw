using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // this print 1/1
        Console.WriteLine(f1.GetDecimalValue()); // this print 1

        Fraction f2 = new Fraction(5); // this calls the #2 constructor public Fraction(int Numbercomplete)
        Console.WriteLine(f2.GetFractionString()); //print 5/1
        Console.WriteLine(f2.GetDecimalValue()); // print 5

        Fraction f3 = new Fraction(3 , 4); // calls the #3 constructor public Fraction(int top, int bottom)
        Console.WriteLine(f3.GetFractionString()); // print 3/4
        Console.WriteLine(f3.GetDecimalValue()); // print 0.75 (3 divide by 4)

        Fraction f4 = new Fraction(1, 3); // #3 constructor
        Console.WriteLine(f4.GetFractionString()); // print 1/3
        Console.WriteLine(f4.GetDecimalValue()); // print 0.3333...
    }

}