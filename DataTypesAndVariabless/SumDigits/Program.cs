string number = Console.ReadLine();
int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    int currentNumber = int.Parse(number[i].ToString());
    sum += currentNumber;
}
Console.WriteLine(sum);