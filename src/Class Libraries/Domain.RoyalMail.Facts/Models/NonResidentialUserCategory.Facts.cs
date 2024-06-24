namespace WhenFresh.Utilities.Domain.RoyalMail.Facts.Models;

using System.Diagnostics.CodeAnalysis;
using WhenFresh.Utilities.Domain.RoyalMail.Models;
using WhenFresh.Utilities.Testing.Unit;
using Xunit;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "NonResidential", Justification = "This is not a single word.")]
public sealed class NonResidentialUserCategoryFacts
{
    [Fact]
    public void a_definition()
    {
        Assert.True(new TypeExpectations<NonResidentialUserCategory>()
                    .DerivesFrom<object>()
                    .IsConcreteClass()
                    .IsSealed()
                    .HasDefaultConstructor()
                    .IsNotDecorated()
                    .Implements<IUserCategory>()
                    .Result);
    }

    [Fact]
    public void prop_Code()
    {
        Assert.Equal('N', new NonResidentialUserCategory().Code);
    }

    [Fact]
    public void prop_Name()
    {
        Assert.Equal("Non-Residential", new NonResidentialUserCategory().Name);
    }
}