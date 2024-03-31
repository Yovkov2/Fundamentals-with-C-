﻿using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
string input = Console.ReadLine();
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
foreach (Match item in matches)
{
    Console.Write(item.Value + " ");
}