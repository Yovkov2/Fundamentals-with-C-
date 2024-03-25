string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
foreach (string word in words)
{
    string currentWord = word.ToLower();
    if (!keyValuePairs.ContainsKey(currentWord))
    {
        keyValuePairs.Add(currentWord, 0);
    }
    keyValuePairs[currentWord] += 1;
}
foreach (var word in keyValuePairs)
{
    if(word.Value % 2 != 0)
    {
        Console.Write(word.Key + " ");
    }
}