class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandard()
    {
        Console.WriteLine();
        Console.WriteLine($"{_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date} - Time: {_time}");
        Console.WriteLine($"{_address.DisplayAddress()}");
    }

    public void DisplayFull(Event x)
    {
        // Console.WriteLine();
        if (x is Lectures)
        {
            var lectures = (Lectures)x;
            DisplayStandard();
            Console.WriteLine($"Type: Lectures");
            Console.WriteLine($"Speaker: {lectures.GetSpeaker()}");
            Console.WriteLine($"Capacity: {lectures.GetCapacity()}");
        }
        else if (x is Receptions)
        {
            var receptions = (Receptions)x;
            DisplayStandard();
            Console.WriteLine($"Type: Receptions");
            Console.WriteLine($"E-mail for RSVP: {receptions.GetEmail()}");
        }
        else if (x is Outdoor)
        {
            var outdoor = (Outdoor)x;
            DisplayStandard();
            Console.WriteLine($"Type: Outdoor");
            Console.WriteLine($"Weather: {outdoor.GetWeather()}");
        }
    }

    public void DisplayShort(Event x)
    {
        Console.WriteLine();
        if (x is Lectures)
        {
            Console.WriteLine($"Type: Lectures");
            Console.WriteLine($"Title: {_title} - Date: {_date}");
        }
        else if (x is Receptions)
        {
            Console.WriteLine($"Type: Receptions");
            Console.WriteLine($"Title: {_title} - Date: {_date}");
        }
        else if (x is Outdoor)
        {
            Console.WriteLine($"Type: Outdoor");
            Console.WriteLine($"Title: {_title} - Date: {_date}");
        }
    }
}