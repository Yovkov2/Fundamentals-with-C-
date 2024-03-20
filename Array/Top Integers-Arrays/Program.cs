int[] inputs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
for (int i = 0; i < inputs.Length; i++)
{
    int currentNumber = inputs[i];
    bool ItsValidate = true;
    for (int j = i + 1; j < inputs.Length; j++)
    {
        int nextNumber = inputs[j];
        if (nextNumber >= currentNumber)
        {
            ItsValidate = false;
            break;
        }
    }
    if (ItsValidate)
    {
        Console.Write(currentNumber + " ");
    }
}