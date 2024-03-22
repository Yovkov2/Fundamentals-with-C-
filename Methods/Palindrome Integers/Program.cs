string input = Console.ReadLine();
while(input != "End")
{
    if(IsPalindrome(input))
    {
        int number = int.Parse(input);
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
    input = Console.ReadLine();
}

static bool IsPalindrome(string input)
{
    for(int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - 1]-1) 
        {
            return false;
        }
    }
    return true;
}