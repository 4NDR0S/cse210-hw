class Goals
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _check;

    // for Checklist
    protected int _timesForBonus;
    protected int _bonusPoints;
    protected int _currently;

    public Goals(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    // only for checklist
    public Goals(string type, string name, string description, int points, int timesForBonus, int bonusPoints, int currently)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _timesForBonus = timesForBonus;
        _bonusPoints = bonusPoints;
        _currently = currently;
    }
    
    public string GetType()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetCheck()
    {
        return _check;
    }

    public void SetCheck(string check)
    {
        _check = check;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine();
    }

    public int GetCurrentlyPoints()
    {
        return _currently;
    }

    public void CurrentlyPoints(int p)
    {
        _currently = p;
    }

    public int TimesForBonus()
    {
        return _timesForBonus;
    }

    public int BonusPoints()
    {
        return _bonusPoints;
    }


    public virtual string Save()
    {
        return ("hola");
    }
}