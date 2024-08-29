int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] inputNumbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string leftNumber = inputNumbers[0];
    string rightNumber = inputNumbers[1];

    int left = int.Parse(leftNumber);
    int right = int.Parse(rightNumber);

    string numberToSum = left > right ? leftNumber : rightNumber;

    int sumOfDigits = 0;
    foreach (char number in numberToSum)
    {
        sumOfDigits += number - '0';
    }
    Console.WriteLine(sumOfDigits);
}