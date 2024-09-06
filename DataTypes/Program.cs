string input = Console.ReadLine();
double sum = 0;

sum = Types(input, sum);

static double Types(string input, double sum)
{
    if (input == "int")
    {
        int number = int.Parse(Console.ReadLine());
        sum = number * 2;
        Console.WriteLine(sum);
    }
    else if (input == "double")
    {
        double number = double.Parse(Console.ReadLine());
        sum = number * 1.5;
        Console.WriteLine(sum);
    }
    else
    {
        string text = Console.ReadLine();
        Console.WriteLine($"${text}$");
    }
    return sum;
}