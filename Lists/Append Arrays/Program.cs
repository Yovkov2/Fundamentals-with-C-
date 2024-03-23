List<string> integers = Console.ReadLine().Split('|').ToList();
List<string> result = new List<string>();
for (int i = integers.Count-1; i >= 0; i--)
{
    var currentChar = integers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
	foreach (var item in currentChar)
	{
		result.Add(item);
	}
}
Console.WriteLine(string.Join(" ",result));