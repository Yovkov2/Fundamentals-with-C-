string[] banwords = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
string text = Console.ReadLine();

foreach (var word in banwords)
{
    if (text.Contains(word))
    {
        text = text.Replace(word, new string('*', word.Length));
    }
}
Console.WriteLine(text);