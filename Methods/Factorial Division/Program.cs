int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
double result;
result = Factorial(firstNumber, secondNumber);
Console.WriteLine($"{result:f2}");


static double Factorial(int firstNumber, double secondNumber)
{
    double firstFactorial = 1;
    double secondFactorial = 1;

    for (int i = 1; i <= firstNumber; i++)
    {
        firstFactorial *= i;
    }
    for (int i = 1;i <= secondNumber;i++)
    {
        secondFactorial *= i;
    }
    return ((double)firstFactorial / secondFactorial);
}