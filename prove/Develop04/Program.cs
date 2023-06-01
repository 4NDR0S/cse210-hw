using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop04 World!");
        int number_choise = 0;

        while (number_choise != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Slect a choice from the menu: ");
            number_choise = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number_choise == 1)
            {
                Console.Clear();
                Activity breath = new Activity("Welcome to the Breathing Activity",
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breath.mensajeDeInicio();
                Console.WriteLine("How long, in seconds, would you like for your session?");
                int z = int.Parse(Console.ReadLine());
                breath._duration = z;
                breath.verificartiempo();

                Console.Clear();
                Console.WriteLine("Get ready...");
                breath.Loading();
                Console.WriteLine();

                // satarting with the breathing activity
                BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity",
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", z);

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(z);

                Thread.Sleep(1000);

                DateTime currentTime = DateTime.Now;  //if its less than 15 seconds
                if (currentTime < futureTime)
                {
                    breathingActivity.BreathingStart();
                    Console.WriteLine();
                    breathingActivity.Breathing();  //each each breathing exercise is 10 seconds
                }
                DateTime currentTime1 = DateTime.Now;  //if its more than 15 seconds
                if (currentTime1 < futureTime)
                {
                    Console.WriteLine();
                    breathingActivity.Breathing();
                }
                DateTime currentTime2 = DateTime.Now;  //if its more than 25 seconds
                if (currentTime2 < futureTime)
                {
                    Console.WriteLine();
                    breathingActivity.Breathing();
                }
                DateTime currentTime3 = DateTime.Now;  //if its more than 35 seconds
                if (currentTime3 < futureTime)
                {
                    Console.WriteLine();
                    breathingActivity.Breathing();
                }
                DateTime currentTime4 = DateTime.Now;  //if its more than 45 seconds
                if (currentTime4 < futureTime)
                {
                    Console.WriteLine();
                    breathingActivity.Breathing();
                }

                Console.WriteLine();
                Console.WriteLine("Well done!!");
                breath.Loading();
                breathingActivity.tempoBreathing();
                breath.Loading();
            }

            if (number_choise == 2)
            {
                Console.Clear();
                Activity reflecting = new Activity("Welcome to the Reflecting Activity",
                "This activity will help you reflect on times in your life when shown and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.mensajeDeInicio();
                Console.WriteLine("How long, in seconds, would you like for your session?");
                int z = int.Parse(Console.ReadLine());
                reflecting._duration = z;
                reflecting.verificartiempo();

                Console.Clear();
                Console.WriteLine("Get ready...");
                reflecting.Loading();
                Console.WriteLine();
        
                // satarting with the reflecting activity
                ReflectingActivity reflectingActivity = new ReflectingActivity("Welcome to the Reflecting Activity",
                "This activity will help you reflect on times in your life when shown and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                z);

                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine();
                Console.WriteLine(" --- Think of a time when you did something really dificult. ---");
                Console.WriteLine();
                Console.WriteLine("When you have something in mind, press enter to continue.");
                string pressEnter = (Console.ReadLine());

                // string pressEnter = "";
                if (pressEnter == "")
                {
                    reflectingActivity.PressEnter();
                    Console.Clear();

                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(z);

                    Thread.Sleep(1000);
        
                    DateTime currentTime = DateTime.Now;
                    if (currentTime < futureTime)
                    {
                    Console.Write("> ");
                    reflectingActivity.DisplayRandomPrompt();
                    reflecting.Loading();
                    Console.WriteLine();
                    }
                    
                    DateTime currentTime1 = DateTime.Now;
                    if (currentTime1 < futureTime)
                    {
                    Console.Write("> ");
                    reflectingActivity.DisplayRandomPrompt();
                    reflecting.Loading();
                    Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Well done!!");
                    Console.WriteLine();
                    reflectingActivity.tempoBreathing();
                    reflecting.Loading();
                    Console.Clear();
                    
                }

            }
        }



        
        
    }
}

public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    public List<string> animationString = new List<string>();

    public Activity( string nameActivity, string description)
    {
        _name = nameActivity;
        _description = description;
        
    }

    public void mensajeDeInicio()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }
    public void verificartiempo()
    {
        Console.WriteLine();
        Console.WriteLine($"{_duration}");
    }
    public void Loading()
    {
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
    }

}


public class BreathingActivity : Activity
{
    private int _tiempo;
    
    public BreathingActivity( string nameActivity, string description, int tiempo) : base (nameActivity, description)
    {
        _tiempo = tiempo;
    }

    public void tempoBreathing()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_tiempo} seconds of the Breathing Activity.");
    }

    public void BreathingStart()
    {
        Console.Write("Breathe in...");
        for (int i = 2; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.Write("Now breathe out...");
        for (int e = 3; e > 0; e--)
        {
            Console.Write(e);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

    }

    public void Breathing()
    {
        Console.Write("Breathe in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.Write("Now breathe out...");
        for (int e = 6; e > 0; e--)
        {
            Console.Write(e);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

    }
}

public class ReflectingActivity : Activity
{
    private int _tiempo;
    
    public List<string> promptList = new List<string>();
    public ReflectingActivity( string nameActivity, string description, int tiempo) : base (nameActivity, description)
    {
        _tiempo = tiempo;
    }

    public void DisplayRandomPrompt()
    {
        promptList.Add("How did you fell when it was complete?");
        promptList.Add("what is you favorite thing about this experience");
        promptList.Add("hola");
        promptList.Add("buenas tardes");

        Random rnd = new Random();
        int index = rnd.Next(0,4);
        string randomprompt = promptList[index];

        Console.Write(randomprompt);
    }

    public void PressEnter()
    {
        Console.WriteLine("Now ponder on each of the following questions as the related to this experience.");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void tempoBreathing()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_tiempo} seconds of the Reflecting Activity.");
    }

}