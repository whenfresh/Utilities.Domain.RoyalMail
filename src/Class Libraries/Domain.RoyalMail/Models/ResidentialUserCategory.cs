namespace WhenFresh.Utilities.Domain.RoyalMail.Models;

public sealed class ResidentialUserCategory : IUserCategory
{
    public char Code => 'R';

    public string Name => "Residential";
}