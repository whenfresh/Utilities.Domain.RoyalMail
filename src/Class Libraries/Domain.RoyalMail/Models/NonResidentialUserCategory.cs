namespace WhenFresh.Utilities.Domain.RoyalMail.Models;

using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "NonResidential", Justification = "This is not a single word.")]
public sealed class NonResidentialUserCategory : IUserCategory
{
    public char Code => 'N';

    public string Name => "Non-Residential";
}