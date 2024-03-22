int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int sumOfAdd = Add(firstNumber, secondNumber);

Subtratct(thirdNumber, sumOfAdd);

static int Add(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

static void Subtratct(int thirdNumber, int sumOfAdd)
{
    int sumOfSubtract = sumOfAdd - thirdNumber;
    Console.WriteLine(sumOfSubtract);
}