List<string> listOfStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

string command = string.Empty;
while ((command = Console.ReadLine()) != "3:1")
{
    string[] commandArray = command.Split();

    if (commandArray[0] == "merge")
    {
        int startIndex = int.Parse(commandArray[1]);
        startIndex = Math.Max(startIndex, 0);
        startIndex = Math.Min(startIndex, listOfStrings.Count - 1);
        int endIndex = int.Parse(commandArray[2]);
        endIndex = Math.Max(0, endIndex);
        endIndex = Math.Min(listOfStrings.Count - 1, endIndex);

        string concat = string.Empty;
        for (int i = startIndex; i <= endIndex; i++)
        {
            concat = concat + listOfStrings[i];
        }

        listOfStrings.RemoveRange(startIndex, endIndex - startIndex + 1);
        listOfStrings.Insert(startIndex, concat);

    }

    else if (commandArray[0] == "divide")
    {
        int indexToDivide = int.Parse(commandArray[1]);
        indexToDivide = Math.Max(0, indexToDivide);
        indexToDivide = Math.Min(indexToDivide, listOfStrings.Count - 1);
        int partitions = int.Parse(commandArray[2]);

        string stringToDivide = listOfStrings[indexToDivide];
        int LengthOfSmallPieces = stringToDivide.Length / partitions;
        List<string> listWithSmallPieces = new List<string>();

        int startIndex = 0;
        for (int i = 0; i < partitions; i++)
        {
            if (i == partitions - 1)
            {
                string pieceToAdd = stringToDivide.Substring(startIndex, stringToDivide.Length - startIndex);
                listWithSmallPieces.Add(pieceToAdd);
            }

            else
            {
                string pieceToAdd = stringToDivide.Substring(startIndex, LengthOfSmallPieces);
                listWithSmallPieces.Add(pieceToAdd);
                startIndex = startIndex + LengthOfSmallPieces;
            }
        }

        listOfStrings.RemoveAt(indexToDivide);
        listOfStrings.InsertRange(indexToDivide, listWithSmallPieces);
    }
}

Console.WriteLine(string.Join(" ", listOfStrings));