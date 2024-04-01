int amount = int.Parse(Console.ReadLine());

int collect = 0;
int days = 0;
if(amount >= 100)
{
    while(amount >= 100)
    {
        days++;
        collect += amount;
        amount -= 10;
    }
    collect -= (days + 1) * 26;
    Console.WriteLine(days);
    Console.WriteLine(collect);
}
else
{
    Console.WriteLine(days);
    Console.WriteLine(collect);
}