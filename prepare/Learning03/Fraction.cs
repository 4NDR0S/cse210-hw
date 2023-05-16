using System;

class Fraction
{
    private int _top;
    
    private int _bottom;

    //Constructor #1
    public Fraction() //Default 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor #2
    public Fraction(int Numbercomplete)
    {
        _top = Numbercomplete;
        _bottom = 1;
    }    

    //Constructor #3
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}