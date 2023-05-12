using System;

public class PromptRandom  // this is the class to make random questions
{
    public string Randomprompt()
    {
        Random rnd = new Random();
                string [] questions = {"Who was the most interesting person I interacted with today?", 
                "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
                "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", 
                "If you had to describe today in one word, what would it be?", "Did you meet your goals for today?"};
                int index = rnd.Next(questions.Length);
                string question_done = questions[index];
                return question_done;
                
    }
}


