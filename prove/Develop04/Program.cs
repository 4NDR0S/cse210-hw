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


            // **** BREATHING ACTIVITY ****
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

                DateTime startTime = DateTime.Now;  //time from now
                DateTime futureTime = startTime.AddSeconds(z);  //time from now + z(time to do the activity)

                Thread.Sleep(1000);

                DateTime currentTime = DateTime.Now;  //if its less than 15 seconds
                if (currentTime < futureTime)
                {
                    breathingActivity.BreathingStart();
                    Console.WriteLine();
                    breathingActivity.Breathing();  //each each breathing exercise is 10 seconds
                }
                DateTime currentTime1 = DateTime.Now;  //if its more than 15 seconds
                while (currentTime1 < futureTime)
                {
                    Console.WriteLine();
                    breathingActivity.Breathing();
                    currentTime1 = DateTime.Now;
                }

                Console.WriteLine();
                // Console.WriteLine("Well done!!");
                breathingActivity.WellDoneMessage(); 
                breath.Loading();
                breathingActivity.tempoBreathing();
                breath.Loading();
            }
            

            // **** REFLECTING ACTIVITY ****
            // List<string>askedQuestions = new List<string>();
            
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

                    DateTime startTime = DateTime.Now;  //time from now
                    DateTime futureTime = startTime.AddSeconds(z);  //time from now + z(time to do the activity)

                    Thread.Sleep(1000);
        
                    List<string>askedQuestions = new List<string>(); //list of question asked, so they can not repeat
                    DateTime currentTime = DateTime.Now;
                    while (currentTime < futureTime)  //loop for the time of the activity
                    {
                    Console.Write("> ");
                    reflectingActivity.askRandomQuestions(askedQuestions); 
                    reflecting.Loading();  // loading animations 2 times, to give enough time for thinking on an answer
                    reflecting.Loading();
                    Console.WriteLine();
                    currentTime = DateTime.Now;
                    }

                    Console.WriteLine();
                    // Console.WriteLine("Well done!!");
                    reflectingActivity.WellDoneMessage();
                    Console.WriteLine();
                    reflectingActivity.tempoReflecting(); 
                    reflecting.Loading();
                    Console.Clear();
                    
                }

            }

            // **** LISTING ACTIVITY ****

            List<string>ListOfAnswers = new List<string>();
            if (number_choise == 3)
            {
                Console.Clear();
                Activity listing = new Activity("Welcome to the Listing Activity", 
                "This Activity will help ypu reflect on the good things in your life bu having you list as many things as you can in a certain area.");
                listing.mensajeDeInicio();
                Console.WriteLine("How long, in seconds, would you like for your session?");
                int z = int.Parse(Console.ReadLine());
                listing._duration = z;

                Console.Clear();
                Console.WriteLine("Get ready...");
                listing.Loading();
                Console.WriteLine();

                ListingActivity listingActivity = new ListingActivity("Welcome to the Listing Activity", 
                "This Activity will help ypu reflect on the good things in your life bu having you list as many things as you can in a certain area.",
                z);

                listingActivity.randomPrompt();
                listingActivity.ListingLoading();
                Console.WriteLine();

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(z);

                DateTime currentTime = DateTime.Now;
                while (currentTime < futureTime)        //loop for the time of the activity
                {
                Console.Write("> ");
                string listingAnswer = Console.ReadLine();
                ListOfAnswers.Add(listingAnswer);
                currentTime = DateTime.Now;
                }

                Console.WriteLine();
                int Listingcount = ListOfAnswers.Count();
                Console.WriteLine($"You listed {Listingcount} items!");

                Console.WriteLine();
                listingActivity.WellDoneMessage();
                listing.Loading();
                listingActivity.tempoListing();
                listing.Loading();
                Console.Clear();

            }
 
        }
    }

}