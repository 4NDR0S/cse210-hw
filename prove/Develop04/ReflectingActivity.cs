public class ReflectingActivity : Activity
{
    private int _tiempo;
    
    // list of questions for the activity
    public static readonly string[] QuestionList = {"How did you fell when it was complete?","What is you favorite thing about this experience?",
    "What would you like to put into practice what you have learned?","How long did it take you to get over it?",
    "What advice would you give your self at that time?","Thinking about the decisions you made at that time to overcome it, would you change anything?"};

    // public List<string>askedQuestions = new List<string>();  this is the list in the main for the questions asked
    public ReflectingActivity( string nameActivity, string description, int tiempo) : base (nameActivity, description)
    {
        _tiempo = tiempo;
    }

    public void askRandomQuestions(List<string>askedQuestions)  //function to ask randoms questions without repeating each time it is called
    {
        Random random = new Random();
        int index = random.Next(QuestionList.Length);
        string randomprompt = QuestionList[index];

        if(!askedQuestions.Contains(randomprompt))  //so that the question is not repeated
        {
            Console.Write(randomprompt);
            askedQuestions.Add(randomprompt);
        }
            
        index = random.Next(QuestionList.Length);
        randomprompt = QuestionList[index];
            
        
    }

    public void PressEnter()  //function that displays after press enter
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

    public void tempoReflecting()  //displays the time the activity was done
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_tiempo} seconds of the Reflecting Activity.");
    }

}
