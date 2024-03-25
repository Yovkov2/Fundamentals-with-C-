int count = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();
for (int i = 0; i < count; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();
    if (!keyValuePairs.ContainsKey(word))
    {
        keyValuePairs.Add(word, new List<string>());
    }
    keyValuePairs[word].Add(synonym);
}
foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
}