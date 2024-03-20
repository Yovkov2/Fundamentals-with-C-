int count = int.Parse(Console.ReadLine());
int[] countsArray = new int[count];
int sum = 0;
for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    countsArray[i] = number;
    sum += number;
}
Console.WriteLine($"{string.Join(" ", countsArray)}");
Console.WriteLine(sum);