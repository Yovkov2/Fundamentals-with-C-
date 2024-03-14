int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = firstNumber; i <= secondNumber; i++)
{
    sum += i;
    Console.Write(i + " ");
    
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");