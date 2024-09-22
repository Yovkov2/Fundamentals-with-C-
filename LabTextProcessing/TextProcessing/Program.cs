string input = Console.ReadLine();
while(input != "end")
{
    string reserved = string.Empty;
    for (var i = input.Length - 1; i >= 0; i--)
    {
        reserved += input[i];
    }
    Console.WriteLine($"{input} = {reserved}");
    input = Console.ReadLine();
}