using System;
using System.Security.Cryptography;

class Program
{
    static void testFunction(int x)
    {
        Console.WriteLine($"The value is {x }");
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // string firstName;
        // string lastName;

        // Console.Write("Please enter your first name: ");
        // firstName = Console.ReadLine();

        // Console.Write("Please enter your last name: ");
        // lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");


        //Comments - Comments to the end of the line
        /* asdf;lkjasdf;lkj
        asfd
        asdf
        as
        df
        asdf
        asdf */

        // ; semicolons

        // Variables and datatypes: int, string, float, double, bool, long

        // Console.Write and Writeline, Console.ReadLine and read
        // Console.WriteLine("Please enter your name:");
        // int name = Console.Read();
        // Console.WriteLine($"The name is: {name}");


        // formatted strings, int.Parse number.ToString()

        // If statements, ||, &&, !

        int x = 10;

        if (!(x == 11 || x == 12 && x == 13 && x != 23))
        {
            Console.WriteLine("X is 10");
        }
        else if (x == 435)
        {
            Console.WriteLine("Hey Bob");
        }
        else
        {
            Console.WriteLine(Math.Pow(2, 10));   
        }
        Console.WriteLine("X is who knows");

        Console.WriteLine($"{x}, {++x}, {x++}, {x}");

        // Loops, For, while, do while, foreach

        // Lists List <int> numbers = new <int>List();

        // Functions

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        // Console.WriteLine($"The number is {number}");

        


    }
}