using System.Text.RegularExpressions;

string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
string input = Console.ReadLine();
Regex regex = new Regex(pattern);
MatchCollection isMatch = regex.Matches(input);
string[] result = isMatch.Select(x => x.Value)
     .ToArray();
Console.WriteLine(string.Join(", ", result));