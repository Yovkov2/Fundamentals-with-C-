double[] numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();
SortedDictionary<double, int> occurrences = new SortedDictionary<double, int>();
foreach (int number in numbers)
{
    if (!occurrences.ContainsKey(number))
    {
        occurrences.Add(number, 0);
    }
    occurrences[number]++;
}

foreach(var number in occurrences)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}