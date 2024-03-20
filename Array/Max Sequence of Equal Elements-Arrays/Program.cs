int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int counter = 1;
int theMost = 0;
int element = 0;
for (int i = 0; i < input.Length - 1; i++)
{
    if (input[i] == input[i + 1])
    {
        counter++;
    }
    else
    {
        counter = 1;
    }
    if(counter > theMost)
    {
        theMost = counter;
        element = input[i];
    }
}
for (int i = 1; i <= theMost; i++)
{
    Console.Write(element + " ");
}