List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string type = Console.ReadLine();
while(type != "end")
{
    string[] command = type.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Delete")
    {
        int value = int.Parse(command[1]);
        numbers.RemoveAll(x => x == value);
    }
    else if (command[0] == "Insert")
    {
        int value = int.Parse(command[1]);
        int index = int.Parse(command[2]);
        numbers.Insert(index, value);
    }
    type = Console.ReadLine();
}
Console.WriteLine($"{string.Join(" ", numbers)}");