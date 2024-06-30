namespace WhenFresh.Utilities;

using WhenFresh.Utilities.Models;

public static class StringExtensionMethods
{
    public static BritishPostcode ToPostcode(this string obj)
    {
        return BritishPostcode.FromString(obj);
    }
}