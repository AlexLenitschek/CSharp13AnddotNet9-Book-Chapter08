using System.Text.RegularExpressions; // To use Regex.

#region Exercise 8.2 of the book

bool loop = true;

while (loop == true) 
{
    Regex usedRegex; // Initialize a default string for the Regex.
    WriteLine("The default regular expression checks for at least one digit.");
    Write("Enter a regular expression (or press ENTER to use the default): ");

    string? readRegex = ReadLine();
    if (readRegex != "")
    {
        usedRegex = new(readRegex!);
    }
    else
    {
        usedRegex = new(@"\d+"); // At least one digit. 
    } 

    // Ask for user input.
    Write("Enter some input: ");
    string input = ReadLine()!;

    WriteLine($"{input} matches {usedRegex}: {usedRegex.IsMatch(input)}");
    WriteLine("Press ESC to end or any other key to try again.");
    loop = ReadKey().Key != ConsoleKey.Escape;
}

#endregion