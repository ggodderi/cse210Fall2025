using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    public static void TestByValue(int x)
    {
        x = 99;
    }

    public static void TestByReference(ref int x)
    {
        x = 99;
    }

    public static void TestByOut(out int x)
    {
        x = 1001;
    }

    public static void TestReferenceByReference(int[] dataArray)
    {
        dataArray[2] = 99999;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("This is a test.");

        int[] myData = {1, 2, 3, 4, 5, 6, 7};
        int[] myData2 = myData;

        // GCHandle gCHandle= GCHandle.Alloc(myData, GCHandleType.Pinned);
        // Console.WriteLine(gCHandle.AddrOfPinnedObject().ToString());

        // Console.WriteLine(myData);
        // Console.WriteLine(myData2);

        myData[4] = 999;
        Console.WriteLine(myData2[4]);
        Console.WriteLine(myData[4]);

        int x = 11;
        TestByValue(x);
        Console.WriteLine(x);
        TestByReference(ref x);
        Console.WriteLine(x);

        int y;
        TestByOut(out y);
        Console.WriteLine(y);

        TestReferenceByReference(myData2);
        Console.WriteLine(myData2[2]);
    }
}