int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

SmallestNumber(firstNumber, secondNumber, thirdNumber);

static void SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
{
    if (firstNumber > secondNumber && secondNumber < thirdNumber)
    {
        Console.WriteLine(secondNumber);
    }
    else if (firstNumber < secondNumber && firstNumber < thirdNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
    {
        Console.WriteLine(thirdNumber);
    }
}