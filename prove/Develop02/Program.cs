using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int number_choise = 0;

        List<Entry> _Entrys = new List<Entry>(); //This is the list for the Entryes done
        

        while (number_choise != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            number_choise = int.Parse(Console.ReadLine());


            if (number_choise == 1)
            {
                // This was the first way I did it, from the main program =>
                // .
                // Random rnd = new Random();
                // string [] questions = {"Who was the most interesting person I interacted with today?", 
                // "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
                // "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", 
                // "If you had to describe today in one word, what would it be?", "Did you meet your goals for today?"};
                // int index = rnd.Next(questions.Length);
                // string question_done = questions[index];
                // Console.WriteLine(question_done);
                //..

                string question_done = "";
                PromptRandom randomquestion = new PromptRandom();
                question_done = randomquestion.Randomprompt(); // calling the funtion from PromptRandom class
                Console.WriteLine(question_done);
                Console.Write("> ");
                string _write = Console.ReadLine();
            

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                
                Entry Entry1 = new Entry(); // creating a new entry
                Entry1._date = dateText;
                Entry1._prompt = question_done;
                Entry1._answer = _write;

                // Entry1.Display();  // if I want to display the entry done
            
                _Entrys.Add(Entry1);

            }

            if (number_choise == 2)  // Display me the entrys I did
            {
                
                foreach (Entry Entry in _Entrys)
                {
                    Entry.Display();
                    
                }  
            }

            if (number_choise == 3)  // read the Journal
            {
                Console.Write("What is the file name: ");
                string filename_read = Console.ReadLine(); // asking for the file
                Console.WriteLine("Reading my Journal...");
                Console.WriteLine();
                // string filename_read = "Journal.txt";
                

                string [] lines = System.IO.File.ReadAllLines(filename_read);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            if (number_choise == 4)  // write in the Journal
            {
                Console.Write("What is the file name: ");
                string filename = Console.ReadLine();  // asking for the file
                Console.WriteLine("Saving to file...");
                // string filename = "Journal.txt";
                

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry x in _Entrys)
                    {
                            outputFile.WriteLine($"Date: {x._date} - Prompt: {x._prompt}");
                            outputFile.WriteLine($"{x._answer}");
                    }
                }

                
            }

        }    

        
    }

}