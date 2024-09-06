using System;

class Program
{
    static void Main(string[] args)
    {
        PrintTribonacciSequence(10);  
    }

    static void PrintTribonacciSequence(int num)
    {
        if (num == 1)
        {
            Console.WriteLine("1");
            return;
        }
        else if (num == 2)
        {
            Console.WriteLine("1 1");
            return;
        }
        else if (num == 3)
        {
            Console.WriteLine("1 1 2");
            return;
        }

        int first = 1, second = 1, third = 2;

        Console.Write("1 1 2");

        for (int i = 4; i <= num; i++)
        {
            int next = first + second + third;
            Console.Write(" " + next);

            first = second;
            second = third;
            third = next;
        }

        Console.WriteLine();  
    }
}