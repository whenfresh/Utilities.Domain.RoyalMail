namespace WhenFresh.Utilities.IO;

using WhenFresh.Utilities.Core.IO;
using WhenFresh.Utilities.Models;

public static class FileExtensionMethods
{
    public static BritishPostcode ToPostcode(this FileInfo file)
    {
        if (null == file)
            throw new ArgumentNullException("file");

        return file.RemoveExtension().Name;
    }
}