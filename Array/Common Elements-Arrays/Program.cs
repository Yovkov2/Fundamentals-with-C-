string text1 = Console.ReadLine();
string text2 = Console.ReadLine();

string[] firstText = text1.Split();
string[] secondText = text2.Split();

for (int i = 0; i < secondText.Length; i++)
{
	for (int j = 0; j < firstText.Length; j++)
	{
		if (firstText[j] == secondText[i])
		{
			Console.Write(secondText[i] + " ");
		}
	}
}
Console.WriteLine();