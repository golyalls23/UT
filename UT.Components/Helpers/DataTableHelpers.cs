using System;
using System.Reflection;

namespace UT.Components.Helpers;

public static class DataTableHelpers
{
    public static IEnumerable<PropertyInfo> GetItemsPropertyInfo<TItem>()
        => typeof(TItem)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => x.CanRead);
                
}
