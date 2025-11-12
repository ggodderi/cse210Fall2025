using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bonjour tout le monde.");
        Circle myCircle = new Circle();

        // myCircle._radius = -10;
        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myCircle2 = new Circle(100);
        Console.WriteLine(myCircle2.GetCircleArea());
        Console.WriteLine(myCircle2.GetCircumference());
        Console.WriteLine(myCircle2.GetDiameter());

        List<Circle> circles = new List<Circle>();
        circles.Add(myCircle);
        circles.Add(myCircle2);

        foreach(Circle c in circles)
        {
            Console.WriteLine(c.GetCircleArea());
        }

    }
}