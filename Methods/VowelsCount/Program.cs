string input = Console.ReadLine();
int vowelsCount = 0;

vowelsCount = NewMethod(input, vowelsCount);

Console.WriteLine(vowelsCount);

static int NewMethod(string input, int vowelsCount)
{
    char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
    foreach (var letter in input.ToLower())
    {
        if (vowels.Contains(letter)) vowelsCount++;
    }

    return vowelsCount;
}