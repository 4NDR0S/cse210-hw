using System;

public class Journal
{
    public string _date;
    public string _prompt;
    public string _answer;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_answer}");
        
    }


}