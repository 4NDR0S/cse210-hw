using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished");

        List<int> numbers = new List<int>();
        int usernum = -1;

        while (usernum  != 0)
        {
            Console.Write("Enter number: ");
            usernum = int.Parse(Console.ReadLine());
            if (usernum != 0)
            {
                numbers.Add(usernum);
            }
            
        }

        // sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"the max is: {max}");
    }
}