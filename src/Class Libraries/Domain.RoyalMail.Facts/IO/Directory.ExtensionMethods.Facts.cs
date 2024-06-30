namespace WhenFresh.Utilities.IO;

using WhenFresh.Utilities.IO;
using WhenFresh.Utilities.Models;
using Xunit;

public sealed class DirectoryExtensionMethodsFacts
{
    [Fact]
    public void op_ToPostcode_DirectoryInfo()
    {
        using (var temp = new TempDirectory())
        {
            var file = temp.Info.ToDirectory("AB12ZZ", true);

            BritishPostcode expected = "AB1 2ZZ";
            var actual = file.ToPostcode();

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void op_ToPostcode_DirectoryInfoNull()
    {
        Assert.Throws<ArgumentNullException>(() => (null as DirectoryInfo).ToPostcode());
    }
}