using System.Threading.Tasks;

List<int> integers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command = Console.ReadLine();
while(command != "End")
{
    string[] type = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    if (type[0] == "Add")
    {
        int number = int.Parse(type[1]);
        integers.Add(number);
    }
    else if (type[0] == "Insert")
    {
        int value = int.Parse(type[1]);
        int index = int.Parse(type[2]);
        integers.Insert(index, value);
    }
    else if (type[0] == "Shift")
    {
       string direction = type[1];
        if(direction == "left")
        {
            int task = int.Parse(type[2]);
            while (task != 0)
            {
                int currentnumber = integers[0];
                integers.RemoveAt(0);
                integers.Add(currentnumber);
                task--;
            }
        }
        else if(direction == "right")
        {
            int task = int.Parse(type[2]);
            while (task != 0)
            {
                int currentnumber = integers[integers.Count - 1];
                integers.RemoveAt(integers.Count - 1);
                integers.Insert(0, currentnumber);
                task--;
            }
        }
    }
    else if (type[0] == "Remove")
    {
        int task = int.Parse(type[1]);
        if(task >= 0 && task < integers.Count)
        {
            integers.RemoveAt(task);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{string.Join(" ", integers)}");