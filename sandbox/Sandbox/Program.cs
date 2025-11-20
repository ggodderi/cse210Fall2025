using System;
using System.Security.AccessControl;
using System.Security.Cryptography;

class Program
{

    // static void TestValues(int x, float y, double z)
    // {
    //     Console.WriteLine($"The values are: {x}, {y}, {z}");
    // }

    // static void OneLIneFunction()
    // {
    //     Console.WriteLine("Blalasdflasdfl");
    // }
    // static int AddValues(int n1, int n2, int n3)
    // {
    //     int total = n1 + n2 + n3;
    //     return total;
    // }


    static void Main(string[] args)
    {

        Console.WriteLine("Hello");

        string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = 13;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        // int count = duration;
        // Console.CursorVisible = false;
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     if(count >= 9)
        //         Console.Write("\b\b  \b\b");
        //     else
        //         Console.Write("\b");
        // }
        // Console.CursorVisible = true;
        
        Console.CursorVisible = false;
        string animationString2 = "(^_^)(-_-)";
        
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString2[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString2[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
        Console.CursorVisible = true;






        // string animationString = "\\|/-";
        // int sleepTime = 250;
        // int duration = 12;
        // int index = 0;

        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(duration);
    
        
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        // int count = duration;
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     if(count >= 9)
        //     {
        //         Console.Write("\b\b  \b\b");
        //     }
        //     else
        //     {
        //         Console.Write("\b");
        //     }
            
        // }




        // TestValues(10, (float)123.234, 23423.2342342340);

        // int total = AddValues(10, 20, 30);
        // Console.WriteLine($"The total is: {total}");

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

        // int x = 10;

        // if (!(x == 11 || x == 12 && x == 13 && x != 23))
        // {
        //     Console.WriteLine("X is 10");
        // }
        // else if (x == 435)
        // {
        //     Console.WriteLine("Hey Bob");
        // }
        // else
        // {
        // }
        // Console.WriteLine(Math.Pow(2, 64));
        // // Console.WriteLine("X is who knows");
        // int x = 10;
        // Console.WriteLine($"{x}, {++x}, {x += 1}, {x}");

        // Loops, For, while, do while, foreach

        // for (int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"The value of i is: {i}");
        // }

        // for (int i = 0; i <= 1000; i += 10)
        // {
        //     Console.WriteLine($"The value of i is: {i}");
        // }

        // for (double  i = 1.234; i < 12.234234; i += .234)
        // {
        //     Console.WriteLine($"The value of i is: {i}");
        // }

        // bool done = false;

        // while (!done)
        // {
        //     Console.Write("Input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}");
        //     }

        // }

        // done = false;
        // do
        // {
        //     Console.Write("Input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}");
        //     }

        // } while (!done);

        // Lists List <int> numbers = new <int>List();

        // List<int> numbers = new List<int>();
        // numbers.Add(10);
        // numbers.Add(2134);
        // numbers.Add(-234);
        // numbers.Add(101);
        // foreach (int n in numbers)
        // {
        //     Console.WriteLine($"The number is: {n}");
        // }

        // for(int index = 0; index < numbers.Count; index++)
        // {
        //     Console.WriteLine(numbers[index]);
        // }

        // Functions


        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        // Console.WriteLine($"The number is {number}");




    }
}