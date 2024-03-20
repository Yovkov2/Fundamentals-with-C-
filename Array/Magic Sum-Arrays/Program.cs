int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int magicNum = int.Parse(Console.ReadLine());
for (int i = 0; i < input.Length - 1; i++)
{
    int currentNumber = input[i];
    for (int j = i + 1; j < input.Length; j++)
    {
        if(currentNumber + input[j] == magicNum)
        {
            Console.WriteLine($"{currentNumber} {input[j]}");
        }
    }
}