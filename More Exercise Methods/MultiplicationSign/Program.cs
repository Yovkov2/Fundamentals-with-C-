int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int threeNumber  = int.Parse(Console.ReadLine());

if(firstNumber == 0 && secondNumber == 0 && threeNumber == 0)
{
    Console.WriteLine("Zero");
}
int negativeCount = 0;

if (firstNumber < 0) negativeCount++;
if (secondNumber < 0) negativeCount++;
if (threeNumber < 0) negativeCount++;

if (negativeCount % 2 == 1) Console.WriteLine("Negative");
else Console.WriteLine("Positive");