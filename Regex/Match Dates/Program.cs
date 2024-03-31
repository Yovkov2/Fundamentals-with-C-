using System.Text.RegularExpressions;

string pattern = @"(?<day>\d{2})(\.|-|_)(?<mont>[A-Z][a-z]{2})\2(?<year>\d{4})";
string input = Console.ReadLine();
Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(input);
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}