namespace JWUtilities.Extensions;

public static class DateTimeExtensions
{
    public static bool IsAfter(this DateTime baseDT, DateTime compareDT)
    {
        return baseDT < compareDT;
    }

    public static bool IsOnOrAfter(this DateTime baseDT, DateTime compareDT)
    {
        return baseDT <= compareDT;
    }

    public static bool IsBefore(this DateTime baseDT, DateTime compareDT)
    {
        return baseDT > compareDT;
    }

    public static bool IsOnOrBefore(this DateTime baseDT, DateTime compareDT)
    {
        return baseDT >= compareDT;
    }
}
