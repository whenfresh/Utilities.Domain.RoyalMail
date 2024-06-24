namespace WhenFresh.Utilities.Domain.RoyalMail.Models;

public static class UserCategory
{
    private static readonly HashSet<IUserCategory> _categories = new(LoadUserCategories());

    public static IUserCategory Resolve(char code)
    {
        return _categories.FirstOrDefault(x => x.Code.Equals(code));
    }

    private static IEnumerable<IUserCategory> LoadUserCategories()
    {
        var category = typeof(IUserCategory);

        return AppDomain
               .CurrentDomain
               .GetAssemblies()
               .ToList()
               .SelectMany(x => x.GetTypes())
               .Where(x => !x.IsInterface)
               .Where(category.IsAssignableFrom)
               .Select(type => (IUserCategory)Activator.CreateInstance(type));
    }
}