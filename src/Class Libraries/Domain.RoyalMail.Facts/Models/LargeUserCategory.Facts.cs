﻿namespace WhenFresh.Utilities.Domain.RoyalMail.Facts.Models;

using WhenFresh.Utilities.Domain.RoyalMail.Models;
using WhenFresh.Utilities.Testing.Unit;
using Xunit;

public sealed class LargeUserCategoryFacts
{
    [Fact]
    public void a_definition()
    {
        Assert.True(new TypeExpectations<LargeUserCategory>()
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
        Assert.Equal('L', new LargeUserCategory().Code);
    }

    [Fact]
    public void prop_Name()
    {
        Assert.Equal("Large", new LargeUserCategory().Name);
    }
}