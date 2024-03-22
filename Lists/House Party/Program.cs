int count = int.Parse(Console.ReadLine());
List<string> names = new List<string>();
for (int i = 0; i < count; i++)
{
    string[] type = Console.ReadLine().Split(" ");
    string name = type[0];
    if(type.Length == 3)
    {
        if (names.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
            continue;
        }
        names.Add(name);
    }
    else if(type.Length == 4)
    {
        if (!names.Contains(name))
        {
            Console.WriteLine($"{name} is not in the list!");
            continue;
        }
        names.Remove(name);
    }
}
foreach (var name in names)
{
    Console.WriteLine(name);
}