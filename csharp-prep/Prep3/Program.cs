using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();

        string keep_playing = "yes";

        while (keep_playing == "yes")
        {
            int magicnumber = randomGenerator.Next(1,101);

            int count = 0;
            int guess = -1;
            
            while (guess != magicnumber)
            {
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                count = count + 1;

                if (guess > magicnumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicnumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                }
            }
            Console.WriteLine($"Guess count: {count}");
            Console.WriteLine();
            Console.Write("Do you want to keep playing (yes/no)?");
            keep_playing = Console.ReadLine();
        }

    }
}