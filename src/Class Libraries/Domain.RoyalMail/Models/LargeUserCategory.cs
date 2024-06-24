namespace WhenFresh.Utilities.Domain.RoyalMail.Models;

public sealed class LargeUserCategory : IUserCategory
{
    public char Code => 'L';

    public string Name => "Large";
}