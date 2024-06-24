namespace WhenFresh.Utilities.Domain.RoyalMail.Diagnostics;

using System.Diagnostics;

internal static class Tracing
{
    internal static TraceSwitch Is => new("Cavity.Domain.RoyalMail", string.Empty);
}