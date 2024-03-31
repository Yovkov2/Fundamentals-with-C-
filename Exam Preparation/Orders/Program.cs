int count = int.Parse(Console.ReadLine());
double priceCapsule = double.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int capsuleCount = int.Parse(Console.ReadLine());

double sum = 0;
for (int i = 0; i < count; i++)
{
    sum += days * capsuleCount * priceCapsule;
}
Console.WriteLine($"The price for the coffee is: ${sum:f2}");
Console.WriteLine($"Total: ${sum:f2}");