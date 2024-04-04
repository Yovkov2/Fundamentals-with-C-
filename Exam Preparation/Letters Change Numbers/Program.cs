string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
double sum = 0;
foreach (string line in input)
{
    char firstChar = line[0];
    char lastChar = line[^1];
    string numAsString = line[1..^1];
    double numFromString = double.Parse(numAsString);
    if (char.IsUpper(firstChar))
    {
        int positionOfTheLetter = firstChar - 64;
        numFromString /= positionOfTheLetter;
    }
    else
    {
        int positionofTheLetter = firstChar - 96;
        numFromString *= positionofTheLetter;
    }
    if(char.IsUpper(lastChar))
    {
        int positionofTheLetter = lastChar - 64;
        numFromString -= positionofTheLetter;
    }
    else
    {
        int positionOfTheLetter = lastChar - 96;
        numFromString += positionOfTheLetter;
    }
    sum += numFromString;
}
Console.WriteLine($"{sum:f2}");