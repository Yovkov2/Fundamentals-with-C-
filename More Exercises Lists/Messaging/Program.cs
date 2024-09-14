using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string text = Console.ReadLine();

        string result = GetCharactersFromText(numbers, text);
        Console.WriteLine(result);
    }

    static string GetCharactersFromText(List<int> numbers, string text)
    {
        string result = "";

        foreach (int number in numbers)
        {
            int sumOfDigits = GetSumOfDigits(number);
            int index = sumOfDigits % text.Length;
            result += text[index];
            text = text.Remove(index, 1);
        }

        return result;
    }

    static int GetSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}