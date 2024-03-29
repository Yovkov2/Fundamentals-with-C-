string text = Console.ReadLine();
string result = string.Empty;
for (int i = 0;i < text.Length; i++)
{
   int sum = text[i];
    sum += 3;
    result += (char)sum;
}
Console.WriteLine(result);