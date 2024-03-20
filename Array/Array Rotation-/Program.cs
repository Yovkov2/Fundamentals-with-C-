int[] inputs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rotation = int.Parse(Console.ReadLine());
for (int i = 1; i <= rotation; i++)
{
    int firstNumber = inputs[0];
    for (int j = 1; j < inputs.Length; j++)
    {
        inputs[j-1] = inputs[j];
    }
    inputs[inputs.Length-1] = firstNumber;
}
Console.WriteLine($"{string.Join(" ", inputs)}");