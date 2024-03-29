string text = Console.ReadLine();
char chars = text[0];
Console.Write(chars);
for (int i = 1; i < text.Length; i++)
{
    char currentChar = text[i];
    if(chars != currentChar)
    {
        chars = currentChar;
        Console.Write(chars);
    }
}