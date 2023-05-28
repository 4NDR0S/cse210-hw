class Word
{
    private string _word;



    public void Hide()
    {
        char[] wordArray = _word.ToCharArray();
        int i = 0;

        foreach (char c in wordArray)
        {
            wordArray[i] = '_';
            i += 1;
        }

        _word = new string(wordArray);
    }


}