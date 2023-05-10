using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int number_choise = 0;

        List<Journal> _journals = new List<Journal>();


        // DateTime theCurrentTime = DateTime.Now;
        //         string dateText = theCurrentTime.ToShortDateString();

        while (number_choise != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            number_choise = int.Parse(Console.ReadLine());

            
            // Journal journal1 = new Journal();
            // Display_journal MyDisplay = new Display_journal();
            // List<Journal> _journals = new List<Journal>();



            if (number_choise == 1)
            {
                Random rnd = new Random();
                string [] questions = {"Who was the most interesting person I interacted with today?", 
                "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
                "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
                int index = rnd.Next(questions.Length);
                string pregunta_hecha = questions[index];
                Console.WriteLine(pregunta_hecha);
                Console.Write("> ");
                string _write = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                
                Journal journal1 = new Journal();
                journal1._date = dateText;
                journal1._prompt = pregunta_hecha;
                journal1._answer = _write;

                // journal1.Display();
                // MyDisplay._journals.Add(journal1);
                _journals.Add(journal1);

            }

            if (number_choise == 2)
            {
                // Console.WriteLine("jiji");
                foreach (Journal journal in _journals)
                {
                    journal.Display();
                    
                }  
            }

            // if (number_choise == 3)
            // {

            // }

            if (number_choise == 4)
            {
                // public static void SavetoFile(List<Journal> _journals)
                
                Console.WriteLine("Saving to file...");
            
                string filename = "AllJournal.txt";

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Journal x in _journals)
                    {
                            outputFile.WriteLine($"Date: {x._date} - Prompt: {x._prompt}");
                            outputFile.WriteLine($"{x._answer}");
                    }
                }

                
            }

        }    

        
    }

}