namespace HW10_sequences;

// ReSharper disable once InconsistentNaming
public static class IEnumerableExtensions
{
    public static Dictionary<TKey, List<TValue>> GroupToDictionary<TKey, TValue>(this IEnumerable<TValue> source, 
        Func<TValue, TKey> selector) where TKey : notnull
    {
        return source.GroupBy(selector)
            .ToDictionary(x => x.Key, x => x.ToList());
    }
}