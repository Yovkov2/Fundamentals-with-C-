using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<int> numbers = new List<int>();
        List<char> nonNumbers = new List<char>();

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                numbers.Add(int.Parse(c.ToString()));
            }
            else
            {
                nonNumbers.Add(c);
            }
        }

        List<int> takeList = new List<int>();
        List<int> skipList = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(numbers[i]);
            }
            else
            {
                skipList.Add(numbers[i]);
            }
        }

        string result = "";
        int currentIndex = 0;

        for (int i = 0; i < takeList.Count; i++)
        {
            int takeCount = takeList[i];
            int skipCount = skipList[i];

            if (currentIndex + takeCount <= nonNumbers.Count)
            {
                result += new string(nonNumbers.Skip(currentIndex).Take(takeCount).ToArray());
            }
            currentIndex += takeCount + skipCount;
        }

        Console.WriteLine(result);
    }
}