int count = int.Parse(Console.ReadLine());

string maxBure = "";
double maxVolume = 0;

for (int i = 0; i < count; i++)
{
    string bureName = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if(volume > maxVolume)
    {
        maxVolume = volume;
        maxBure = bureName;
    }
}
Console.WriteLine(maxBure);