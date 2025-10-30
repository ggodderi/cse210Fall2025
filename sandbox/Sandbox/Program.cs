using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"YOur name is: {lastName}, {firstName} {lastName}");

        //Comments

        // ; semicolons

        // Variables and datatypes: int, string, float, double, bool

        // Console.Write and Writeline, Console.ReadLine and read
        Console.WriteLine("Please enter your name:");
        int name = Console.Read();
        Console.WriteLine($"The name is: {name}");


        // formatted strings, int.Parse number.ToString()

        // If statements, ||, &&, !

        // Loops, For, while, do while, foreach

        // Lists

        // Functions


        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11); 

    }
}