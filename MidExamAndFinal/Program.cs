string message = Console.ReadLine();
string command = Console.ReadLine();
while (command != "Reveal")
{
    string[] commandInfo = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
    string commandName = commandInfo[0];
    if (commandName == "InsertSpace")
    {
        int index = int.Parse(commandInfo[1]);
        message.Insert(index, " ");
        Console.WriteLine(message);
    }
    else if (commandName == "Reverse")
    {
        string subString = commandInfo[1];
        int startIndex = message.IndexOf(subString);
        if (startIndex != -1)
        {
            message = message.Remove(startIndex, subString.Length);
            message += string.Join("", subString.Reverse());
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (command == "ChangeAll")
    {
        string substring = commandInfo[1];
        string replacment = commandInfo[2];

        message = message.Replace(substring, replacment);
        Console.WriteLine(message);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"You have a new text message: {message}");