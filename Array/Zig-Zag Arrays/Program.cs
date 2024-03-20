int count = int.Parse(Console.ReadLine());

int[] firstArray = new int[count];
int[] secondArray = new int[count];

for (int i = 1; i <= count; i++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
   int first = numbers[0];
   int second = numbers[1];

    if(i % 2 != 0)
    {
        firstArray[i -1] = first;
        secondArray[i -1] = second;
    }
    else
    {
        firstArray[i - 1] = second;
        secondArray[i - 1] = first;
    }
}
Console.WriteLine($"{string.Join(" ", firstArray)}");
Console.WriteLine($"{string.Join(" ", secondArray)}");