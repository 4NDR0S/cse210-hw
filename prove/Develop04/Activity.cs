public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    // list of characters to make the loading animation
    public static readonly string[]animationString = {"|", "/", "-", "\\", "|", "/", "-", "\\"};

    public Activity( string nameActivity, string description)
    {
        _name = nameActivity;
        _description = description;
        
    }

    public void mensajeDeInicio()  //display the initial message for each activity 
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }
    public void verificartiempo()  //this was just to check if the timing was being taken correctly
    {
        Console.WriteLine();
        Console.WriteLine($"{_duration}");
    }

    public void Loading()  //the leading animation
    {
        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void WellDoneMessage()  //well done message, with a more striking visual display
    {
        Console.WriteLine(" __        __   _ _       _                    _   _ ");
        Console.WriteLine(" \\ \\      / /__| | |   __| | ___  _ __   ___  | | | |");
        Console.WriteLine("  \\ \\ /\\ / / _ \\ | |  / _` |/ _ \\| '_ \\ / _ \\ | | | |");
        Console.WriteLine("   \\ V  V /  __/ | | | (_| | (_) | | | |  __/ |_| |_|");
        Console.WriteLine("    \\_/\\_/ \\___|_|_|  \\__,_|\\___/|_| |_|\\___| (_) (_)");
        Console.WriteLine("");
    }
}
