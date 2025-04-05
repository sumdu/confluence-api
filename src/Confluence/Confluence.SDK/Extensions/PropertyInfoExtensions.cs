using Newtonsoft.Json;
using System.Reflection;

namespace Confluence.ApiV2.Extensions;

public static class PropertyInfoExtensions
{
    public static string GetJsonPropertyName(this PropertyInfo pi)
    {
        var customNameProperty = pi.GetCustomAttribute<JsonPropertyAttribute>();

        var res = pi.Name;
        if (customNameProperty != null)
        {
            res = customNameProperty.PropertyName;
        }
        return res!;
    }
}
