int count = int.Parse(Console.ReadLine());

int totalLiters = 0;
int capacity = 255;
for (int i = 0; i < count; i++)
{
    int quantity = int.Parse(Console.ReadLine());
    totalLiters += quantity;
    if(totalLiters > capacity)
    {
        Console.WriteLine("Insufficient capacity!");
        totalLiters-=quantity;
    }
}
Console.WriteLine(totalLiters);