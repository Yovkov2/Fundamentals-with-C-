int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

double value = n * 0.5;
int sum = 0;
while(n > m)
{
    n -= m;
    sum++;
    if(n == value && y != 0)
    {
        n /= y;
    }
}
Console.WriteLine(n);
Console.WriteLine(sum);