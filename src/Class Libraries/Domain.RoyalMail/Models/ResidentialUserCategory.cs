namespace WhenFresh.Utilities.Models;

public sealed class ResidentialUserCategory : IUserCategory
{
    public char Code => 'R';

    public string Name => "Residential";
}