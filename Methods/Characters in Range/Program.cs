char firstChar = char.Parse(Console.ReadLine());
char secondChar = char.Parse(Console.ReadLine());

Ascii(firstChar, secondChar);

static void Ascii(char firstChar, char secondChar)
{
    int startCharacter = Math.Min(firstChar, secondChar);
    int endCharacter = Math.Max(firstChar, secondChar);
    for (int i = ++startCharacter; i < endCharacter; i++)
    {
        Console.Write((char)i + " ");
    }
    Console.WriteLine();
}
