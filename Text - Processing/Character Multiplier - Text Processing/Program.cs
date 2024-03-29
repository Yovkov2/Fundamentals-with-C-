string[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
GetBiggest(tokens[0], tokens[1]);

 static void GetBiggest(string v1, string v2)
{
    int sum =0;
    var minString = Math.Min(v1.Length, v2.Length);
    for (int i = 0; i < minString; i++)
    {
        sum += v1[i] * v2[i];
    }
    string biggestString = v1;
    if(biggestString.Length < v2.Length)
    {
        biggestString = v2;
    }
    for (int i = minString;i < biggestString.Length; i++)
    {
        sum += biggestString[i];
    }
    Console.WriteLine(sum);
}