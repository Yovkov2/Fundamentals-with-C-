using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] raceTimes = Console.ReadLine().Split().Select(double.Parse).ToArray();
        int middleIndex = raceTimes.Length / 2;

        double leftCarTime = CalculateTotalTime(raceTimes, 0, middleIndex, 1);
        double rightCarTime = CalculateTotalTime(raceTimes, raceTimes.Length - 1, middleIndex, -1);

        if (leftCarTime < rightCarTime)
        {
            Console.WriteLine($"The winner is left with total time: {leftCarTime}");
        }
        else
        {
            Console.WriteLine($"The winner is right with total time: {rightCarTime}");
        }
    }

    static double CalculateTotalTime(double[] times, int startIndex, int endIndex, int step)
    {
        double totalTime = 0;

        for (int i = startIndex; i != endIndex; i += step)
        {
            totalTime += times[i];
            if (times[i] == 0)
            {
                totalTime *= 0.8;
            }
        }

        return totalTime;
    }
}