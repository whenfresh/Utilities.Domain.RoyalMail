namespace WhenFresh.Utilities.Domain.RoyalMail.IO;

using System.Diagnostics.CodeAnalysis;
using WhenFresh.Utilities.Domain.RoyalMail.Models;

public static class DirectoryExtensionMethods
{
    [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "I want strong typing here.")]
    public static BritishPostcode ToPostcode(this DirectoryInfo directory)
    {
        if (null == directory)
            throw new ArgumentNullException("directory");

        return directory.Name;
    }
}