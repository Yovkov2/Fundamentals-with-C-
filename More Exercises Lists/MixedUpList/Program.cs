using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> resultList = new List<int>();

        int minLength = Math.Min(firstList.Count, secondList.Count) - 2;

        for (int i = 0; i < minLength; i++)
        {
            resultList.Add(firstList[i]);
            resultList.Add(secondList[secondList.Count - 1 - i]);
        }

        List<int> remainingElements = new List<int>
        {
            secondList[0],
            secondList[1]
        };

        int lowerBound = Math.Min(remainingElements[0], remainingElements[1]);
        int upperBound = Math.Max(remainingElements[0], remainingElements[1]);

        List<int> filteredList = resultList.Where(x => x > lowerBound && x < upperBound).ToList();

        filteredList.Sort();
        Console.WriteLine(string.Join(" ", filteredList));
    }
}