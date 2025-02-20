using System.Text.RegularExpressions; // To use Regex.

partial class Program
{
    [GeneratedRegex(DigitsOnlyText, RegexOptions.IgnoreCase)]
    private static partial Regex DigitsOnly { get; } // Need .NET9 or higher for this partial property.

    [GeneratedRegex(CommaSeparatorText, RegexOptions.IgnoreCase)]
    private static partial Regex CommaSeparator { get; }
}