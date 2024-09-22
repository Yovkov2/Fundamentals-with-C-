using System.Text;

string input = Console.ReadLine();
string digits = string.Empty;
string letters = string.Empty;
string asciiSymbols = string.Empty;

for (int i = 0;i < input.Length; i++)
{
    char currentChar = input[i];

    if (char.IsDigit(currentChar))
    {
        digits += currentChar;
    }
    else if (char.IsLetter(currentChar))
    {
        letters += currentChar;
    }
    else if (char.IsAscii(currentChar))
    {
        asciiSymbols += currentChar;
    }
    
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(asciiSymbols);