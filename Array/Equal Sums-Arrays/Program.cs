string input = Console.ReadLine();
string[] arr = input.Split(" ");
int[] number = Array.ConvertAll(arr, int.Parse);

if(number.Length == 0)
{
    Console.WriteLine(0);
    return;
}
int leftSum = 0;
int rightSum = 0;
for(int i = 0; i < number.Length; i++)
{
    leftSum = number.Take(i).Sum();
    rightSum = number.Skip(i + 1).Sum();
    if(leftSum == rightSum)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine("no");