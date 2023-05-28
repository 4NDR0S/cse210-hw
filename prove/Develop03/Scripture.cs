class Scripture
{
    public string _reference;
    public string _scriptureVerses;

    public List<Word> _words = new List<Word>();

    public Scripture()
    {
        _reference = "John 3:16";
        _scriptureVerses = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    }

    public void Display()
    {
        Console.Write($"{_reference} {_scriptureVerses}");
    }

    //  public List<Word> MakeWordList()
    // {
    //     List<Word> wordList = new List<Word>();
    //     foreach (string word in _scriptureVerses.Split(" "))
    //     {
    //         Word value = new Word (word);
    //         wordList.Add(value);
    //     }

    //     return wordList;

    // }
}