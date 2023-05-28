class Reference
{
    private string _libro;
    private string _capitulo;
    private string _versiculo;
    private string _end_verse;

    public Reference() //John 3:16
    {
        _libro = "John";
        _capitulo = "3";
        _versiculo = "16";
    }

    public Reference(string book, string chapter, string verse) // si solo tiene un versiculo
    {
        _libro = book;
        _capitulo = chapter;
        _versiculo = verse;
    }

    public Reference(string book, string chapter, string verse, string end_verse) // si tiene dos versiculos
    {
        _libro = book;
        _capitulo = chapter;
        _versiculo = verse;
        _end_verse = end_verse;

    }

    public string Reference_display1()
    {
        return($"{_libro}  {_capitulo}:{_versiculo}");
        
    }
    public string Reference_display2()
    {
        return($"{_libro}  {_capitulo}:{_versiculo}-{_end_verse}");
    }
}
