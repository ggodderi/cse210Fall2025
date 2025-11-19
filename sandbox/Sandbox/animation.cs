using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.IO.Compression;


class Program2
{

    // static void TestPassByRefRefType(int[] data)
    // {
    //     data[2] = 1099;
    // }
    // static void TestPassByRef(ref int x)
    // {
    //     x = 99;
    // }
    // static void TestPassByValue(int x)
    // {
    //     x = 99;
    // }
    
    // static void TestPassByOut(out int x)
    // {
    //     x = 199;
    // }
    private static void Main2(string[] args)
    {

        // Console.WriteLine("Yo Bob");
        // int[] dataArray;
        // int[] dataReference;
        // dataArray = new int[] { 10, 20, 30 };
        // dataReference = dataArray;

        // int x = 10;
        // TestPassByValue(x);
        // Console.WriteLine(x);
        // TestPassByRef(ref x);
        // Console.WriteLine(x);
        // TestPassByRefRefType(dataArray);
        // foreach (int y in dataArray)
        //     Console.WriteLine(y);

        // int z;
        // TestPassByOut(out z);
        
        int duration = 12;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 150;
        int count = duration;

        string animationString2 = "\\|/-";
        int index = 0;

        // Spinner
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }

        // Animate faces.
        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");

        }

        //Animate a count down.
        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            if (count >= 9)
                Console.Write("\b\b  \b\b");
            else
            {
                Console.Write("\b");
            }
        }

        // Animate + and -
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");

        }

    }
}


  // int sleepTime = 250;
        // int time = 9;

        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(time);


        // string animationString2 = "-+\\|/=)*&$";
        // int index = 0;

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString2[index++ % animationString2.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        // int count = time;

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     Console.Write("\b");
        // }

        // string animationString = "(^_^)(-_-)";

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[0..5]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b\b\b");
        //     Console.Write(animationString[5..]);
        //     // Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b\b\b");
        //     // Console.Write("\n\t\\")

        // }
        // Circle myCircle = new Circle(10);
        // // myCircle.SetRadius(10);
        // // myCircle._radius = -10;
        // Console.WriteLine($"{myCircle.GetRadius()}");
        // // Circle myCircle2 = new Circle();
        // // myCircle2.SetRadius(20);
        // // Console.WriteLine($"{myCircle2.GetRadius()}");

        // Console.WriteLine($"{myCircle.GetArea()}");
        // // Console.WriteLine($"{myCircle2.GetArea()}");

        // Cylinder myCylinder = new Cylinder(100, 8);
        // // myCylinder.SetHeight(10);
        // // myCylinder.SetCircle(myCircle);
        // Console.WriteLine($"{myCylinder.GetVolume()}");
        //             int sleepTime =450;
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(20);
        // string animationString = "-/-\\_";
        // string animationString2 = ":(:)";
        // string animationString3 = "(-_-)(^_^)";
        // int count = 0;

        // Console.Write("Waiting: ");
        // while (DateTime.Now < futureTime)
        // {
        //     // Console.Write(".");
        //     // Console.Write("+");
        //     Console.Write(animationString3[0..5]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b\b\b     \b\b\b\b\b");
        //     Console.Write(animationString3[5..]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b\b\b     \b\b\b\b\b");
        //     count += animationString3.Length;
        //     // Console.Write("-");
        //     // Thread.Sleep(sleepTime);
        //     // Console.Write("\b \b");
        // }