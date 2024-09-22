using System.Text;

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
StringBuilder sb = new StringBuilder();

foreach (var word in words)
{
    int count = word.Length;
    for (int i = 0; i < count; i++)
    {
        sb.Append(word);
    }
}

Console.WriteLine(sb.ToString());