using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu= new Menu();

        int response = 0;

        while (response != 6)
        {
            response = menu.DisplayMenu();

            Goal myGoal = new Goal("Run", "Run a lot faster");
            Console.WriteLine(myGoal.GetConsoleString());

        }
    }
}