class SimpleGoal : Goals
{
    public SimpleGoal(string type, string name, string description, int points) : base (type, name, description, points)
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_check}] {_name} ({_description})");
    }
}