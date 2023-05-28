using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r2 = new Reference("Proverbs", "3","5","6"); //Proverbs 3:5–6
        // Console.WriteLine(r2.Reference_display2());

        Scripture scr1 = new Scripture();
        scr1._reference = (r2.Reference_display2());
        scr1._scriptureVerses = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        List<string> letras = new List<string>();
        // List<int> numbers = new List<int>();  //boolean try
        
        foreach(string word in scr1._scriptureVerses.Split(" "))
        {
            string value = new string(word);
            letras.Add(value);
            
        }
        
        int list_count = letras.Count; // 27
        // bool _hidden = false;  //boolean try
        
        void Hide(){
        
        Random rnd = new Random();
        int index = rnd.Next(0,list_count);
        string randomWord = letras[index];
        // numbers.Add(index);  //boolean try
        
        char[] wordArray = randomWord.ToCharArray();
        int i = 0;

        foreach (char c in wordArray)
        {
            wordArray[i] = '_';
            i += 1;
        }

        string new_randomWord = new string(wordArray);
        // Console.WriteLine(new_randomWord);
        
        scr1._scriptureVerses = scr1._scriptureVerses.Replace(randomWord, new_randomWord);

        // _hidden = true;  //boolean try

        // if (!numbers.Contains(index)) //boolean try
        //     {
        //      _hidden = false;
        //     }

        }




        string escribe = "";
        while (escribe != "quit")
        {
            // Console.WriteLine($"{referenciaaa} {textoescritura}");
            scr1.Display();
            escribe = Console.ReadLine();
            
            if (escribe == "")
            {
               
                Console.Clear();
                Hide();
                // if (_hidden == false)  //boolean try
                //  {
                //     Hide();
                //  }
            }
            

        }




    }

}
