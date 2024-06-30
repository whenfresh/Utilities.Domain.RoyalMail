namespace WhenFresh.Utilities.Data;

using WhenFresh.Utilities.Core.Collections;
using WhenFresh.Utilities.Data.Data;
using WhenFresh.Utilities.Models;

public class MarketingAddressTransformer : ITransformData<MarketingAddress>
{
    public MarketingAddressTransformer()
        : this(null)
    {
    }

    public MarketingAddressTransformer(IList<string> columns)
        : this(columns, null)
    {
    }

    public MarketingAddressTransformer(IList<string> columns,
                                       IDictionary<PostalAddressFileKey, string> references)
    {
        Columns = columns ?? new List<string>();
        References = references;
    }

    public IList<string> Columns { get; }

    public IDictionary<PostalAddressFileKey, string> References { get; }

    public IEnumerable<MarketingAddress> Transform(IEnumerable<KeyStringDictionary> data)
    {
        return data.Select(entry => AddColumns(entry, BritishAddress.ToMarketingFormat(entry)));
    }

    private MarketingAddress AddColumns(KeyStringDictionary source,
                                        MarketingAddress destination)
    {
        foreach (var column in Columns)
            destination[column] = source[column];

        if (null != References)
            destination["REFERENCE"] = References[source["KEY"]];

        return destination;
    }
}