public class BreathingActivity : Activity
{
    private int _tiempo;
    
    public BreathingActivity( string nameActivity, string description, int tiempo) : base (nameActivity, description)
    {
        _tiempo = tiempo;
    }

    public void tempoBreathing()  //displays the time the activity was done
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_tiempo} seconds of the Breathing Activity.");
    }

    public void BreathingStart()  //breathing start activity (2 and 3 seconds at first)
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

    public void Breathing()  //breathing activity (4 and 6 seconds)
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
