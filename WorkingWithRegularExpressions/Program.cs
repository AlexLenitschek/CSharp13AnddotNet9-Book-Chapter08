using System.Text.RegularExpressions; // To use Regex.

#region Checking for digits entered as text
Write("Enter your Age: ");
string input = ReadLine()!; // Null Forgiving Operator.
//Regex ageChecker = new(@"^\d+$");
Regex ageChecker = DigitsOnly;
WriteLine(ageChecker.IsMatch(input) ? "Valid Age" : $"This is not a valid Age: {input}");

WriteLine();
#endregion


#region Splitting a complex comma-separated string

// C# 1 to 10: Use escaped double-quote characters \"
//string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

// C# 11 or later: Use """ to start and end a raw string literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";

WriteLine($"Films to split: {films}");

string[] filmsDumb = films.Split(',');

WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($"  {film}");
}

Regex csv = CommaSeparator;

//Regex csv = new("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

MatchCollection filmsSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
    WriteLine($"  {film.Groups[2].Value}");
}


#endregion