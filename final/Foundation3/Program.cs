using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
    }
}

class Event
{
    protected string _title;
    protected string _description;
    protected int _date;
    protected int _time;
    protected Addres _address;

    public Event (string title, string description, int date, int time, Addres address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandard()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"At: {_date} - {_time}");
        Console.WriteLine($"{_address}");
    }

    public void DisplayFull()
    {

    }

    public void DisplayShort(Event x)
    {
        if (x is Lectures)
        {
            // var Lectures = (Lectures)x;
            Console.WriteLine($"Type: Lectures");
            Console.WriteLine($"Title & date: {_title} - {_date}");
        }
        else if (x is Receptions)
        {
            Console.WriteLine($"Type: Receptions");
            Console.WriteLine($"Title & date: {_title} - {_date}");
        }
        else if (x is Outdoor)
        {
            Console.WriteLine($"Type: Outdoor");
            Console.WriteLine($"Title & date: {_title} - {_date}");
        }
    }
}

class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures (string title, string description, int date, int time, Addres address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}

class Receptions : Event
{
    private string _email;

    public Receptions (string title, string description, int date, int time, Addres address, string email) : base (title, description, date, time, address)
    {
        _email = email;
    }
}

class Outdoor : Event
{
    private string _weather;
    public Outdoor (string title, string description, int date, int time, Addres address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
}

class Addres
{
    private string _streetAdress;
    private string _city;

    public Addres (string street, string city)
    {
        _streetAdress = street;
        _city = city;
    }
}