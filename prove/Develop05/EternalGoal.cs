class EternalGoal : Goals
{
    public EternalGoal(string type, string name, string description, int points) : base (type, name, description, points)
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_check}] {_name} ({_description})");
    }


    public override string Save()
    {
        return ($"{_type}:{_name},{_description},{_points}");
    }

}
