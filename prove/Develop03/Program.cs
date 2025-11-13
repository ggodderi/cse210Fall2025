using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();
        Console.WriteLine(myWord.GetWordString());
        myWord.HideWord();
        if(myWord.IsHidden())
        {
            Console.WriteLine("Word is hidden");
        }

        Console.WriteLine(myWord.GetWordString());
        myWord.DisplayWord();
    }
}