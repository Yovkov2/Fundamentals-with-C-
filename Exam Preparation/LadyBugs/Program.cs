int sizeofArray = int.Parse(Console.ReadLine());

int[] bugs = new int[sizeofArray];
int[] bugsIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < bugsIndex.Length; i++)
{
    if (bugsIndex[i] < 0 || bugsIndex[i] >= bugs.Length)
    {
        continue;
    }
    bugs[bugsIndex[i]] = 1;
}
string command = Console.ReadLine();

while(command != "end")
{
    string[] commandArgs = command.Split(" ");
    int bugIndex = int.Parse(commandArgs[0]);
    string direction = commandArgs[1];
    int steps = int.Parse(commandArgs[2]);

    if (bugIndex < 0 || bugIndex >= bugs.Length)
    {
        command = Console.ReadLine();
        continue;
    }
    if (bugs[bugIndex] == 0)
    {
        command= Console.ReadLine();
        continue;
    }
    bugs[bugIndex] = 0;
    while(true)
    {
        if(direction == "right")
        {
            bugIndex += steps;
        }
        else
        {
            bugIndex -= steps;
        }
        if(bugIndex < 0 || bugIndex >= bugsIndex.Length)
        {
            break;
        }
        if (bugs[bugIndex] == 1)
        {
            continue;
        }
        bugs[bugIndex] = 1;
        break;
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", bugs));