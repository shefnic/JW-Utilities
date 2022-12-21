namespace JWUtilities.Extensions;

public static class StringExtensions
{
    public static bool EqualsIgnoreCase(this string baseString, string compareString)
    {
        return baseString.Equals(compareString, StringComparison.InvariantCultureIgnoreCase);
    }

    public static bool ContainsIgnoreCase(this string baseString, string compareString)
    {
        return baseString.Contains(compareString, StringComparison.InvariantCultureIgnoreCase);
    }

    public static bool StartsWithIgnoreCase(this string baseString, string compareString)
    {
        return baseString.StartsWith(compareString, StringComparison.InvariantCultureIgnoreCase);
    }
}
