using System;

class Program
{
    static void Main(string[] args)
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2= int.Parse(Console.ReadLine());
        int x3= int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        LongerLine(x1, y1, x2, y2,x3,y3,x4,y4);  
    }
    static void LongerLine(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
    {
        double line1LengthSquared = GetDistanceSquared(x1, y1, x2, y2);
        double line2LengthSquared = GetDistanceSquared(x3, y3, x4, y4);

        if (line1LengthSquared > line2LengthSquared)
        {
            PrintLineInOrder(x1, y1, x2, y2);
        }
        else if (line2LengthSquared > line1LengthSquared)
        {
            PrintLineInOrder(x3, y3, x4, y4);
        }
        else
        {
            PrintLineInOrder(x1, y1, x2, y2); 
        }
    }

    static double GetDistanceSquared(int x1, int y1, int x2, int y2)
    {
        return (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    }

    static void PrintLineInOrder(int x1, int y1, int x2, int y2)
    {
        double distance1Squared = GetDistanceSquared(x1, y1, 0, 0);
        double distance2Squared = GetDistanceSquared(x2, y2, 0, 0);

        if (distance1Squared <= distance2Squared)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }
}