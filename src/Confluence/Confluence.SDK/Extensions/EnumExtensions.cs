using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.Serialization;

namespace RichkaSoft.Confluence.ApiV2.Extensions;

public static class EnumExtensions
{
    public static string GetJsonPropertyValue<T>(this T enumValue)
    {
        var field = enumValue.GetType()/* typeof(T)*/.GetField(enumValue.ToString());
        return field?.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? enumValue.ToString();
    }
}