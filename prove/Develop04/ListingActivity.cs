public class ListingActivity : Activity
{
    private int _tiempo;
    
    public static readonly string[] PromptList = {"When have you felt the Holy Ghost this month","What things do you still need to do this week?",
    "What are your goals for this month?","How many people did you smile at this week? Make a list below"};
    public ListingActivity( string nameActivity, string description, int tiempo) : base (nameActivity, description)
    {
        _tiempo = tiempo;
    }

    public void randomPrompt()
    {
        Random random = new Random();
        int index = random.Next(PromptList.Length);
        string randomprompt = PromptList[index];

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {randomprompt} ---");
    }

    public void ListingLoading()
    {
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void tempoListing()  //displays the time the activity was done
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_tiempo} seconds of the Listing Activity.");
    }
}