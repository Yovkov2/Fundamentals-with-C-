int count = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < count; i++)
{
    char chars = char.Parse(Console.ReadLine());
    sum += (int)chars;
}
Console.WriteLine($"The sum equals: {sum}");