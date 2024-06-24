namespace WhenFresh.Utilities.Domain.RoyalMail.IO;

using WhenFresh.Utilities.Core.IO;
using WhenFresh.Utilities.Domain.RoyalMail.Models;

public static class FileExtensionMethods
{
    public static BritishPostcode ToPostcode(this FileInfo file)
    {
        if (null == file)
            throw new ArgumentNullException("file");

        return file.RemoveExtension().Name;
    }
}