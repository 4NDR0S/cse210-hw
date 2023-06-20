
class ChecklistGoal : Goals
{
    // private int _timesForBonus;
    // private int _bonusPoints;
    // private int _currently;
    public ChecklistGoal(string type, string name, string description, int points, int timesForBonus, int bonusPoints, int currently) : base (type, name, description, points, timesForBonus, bonusPoints, currently)
    {
       
    }


    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_check}] {_name} ({_description}) -- Currently completed: {_currently}/{_timesForBonus}");
    }

    public override string Save()
    {
        return ($"{_type}:{_name},{_description},{_points},{_bonusPoints},{_timesForBonus},{_currently}");
    }

}
