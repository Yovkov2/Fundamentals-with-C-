List<int> wagons = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string input = Console.ReadLine();
int morePeople = 0;
while(input != "end")
{
    string[] splitedInput = input.Split(" ");
    if(splitedInput.Length == 1)
    {
        morePeople = int.Parse(splitedInput[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + morePeople <= maxCapacity)
            {
                wagons[i] += morePeople;
                break;
            }
        }
    }
    else
    {
        morePeople = int.Parse(splitedInput[1]);
        wagons.Add(morePeople);
    }
    input = Console.ReadLine();
}
string result = string.Join(" ", wagons);
Console.WriteLine(result);