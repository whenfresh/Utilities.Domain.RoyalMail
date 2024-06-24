namespace WhenFresh.Utilities.Domain.RoyalMail;

using WhenFresh.Utilities.Domain.RoyalMail.Models;

public static class StringExtensionMethods
{
    public static BritishPostcode ToPostcode(this string obj)
    {
        return BritishPostcode.FromString(obj);
    }
}