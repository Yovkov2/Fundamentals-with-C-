int number = int.Parse(Console.ReadLine());
int numberCoppy = number;
int sum = 0;
while(number > 0)
{
    int factorial = 1;
    double num = number % 10;
    number /= 10;
    for(int i = 2; i <= num; i++)
    {
        factorial *= i;
    }
    sum += factorial;
}
if(sum == numberCoppy)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}