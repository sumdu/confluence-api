using RichkaSoft.Confluence.ApiV2.Exceptions;
using RichkaSoft.Confluence.ApiV2.Extensions;
using RichkaSoft.Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;

namespace RichkaSoft.Confluence.ApiV2.Serializers;

internal class QueryParamsSerializer
{
    public string Serialize(object obj)
    {
        if (obj == null) 
            return string.Empty;

        var properties = obj.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetCustomAttribute<QueryParamAttribute>() != null);

        var queryString = new StringBuilder();

        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            if (value != null)
            {
                var serializedName = property.GetJsonPropertyName();
                var serializedValue = SerializeValue(value);
                queryString.Append($"{serializedName}={serializedValue}&");
            }
        }

        return queryString.Length > 0 ? "?" + queryString.ToString().TrimEnd('&') : string.Empty;

        //var settings = new JsonSerializerSettings
        //{
        //    ContractResolver = new QueryParamContractResolver(),
        //    Formatting = Formatting.Indented,
        //    NullValueHandling = NullValueHandling.Ignore,
        //};
        //var json = JsonConvert.SerializeObject(o, settings);
        //return json;
    }

    private string SerializeValue(object val)
    {
        if (val == null)
            throw new ConfluenceSdkException("this should never happen");

        // if type of string, return as is
        if (val is string v)
            return v;
        else if (val is bool b)
            return b ? "true" : "false";
        else if (val is Enum e)
            return e.GetJsonPropertyValue();
        else if (val is Array ar && ar.GetType().GetElementType().BaseType == typeof(Enum))
        {
            string s = "";
            foreach (var a1 in ar)
                s += a1.GetJsonPropertyValue() + ",";
            s = s.TrimEnd(',');
            return s;
        }
        else if (val is string[] a)
            return string.Join(",", a);
        else if (val is int[] i)
            return string.Join(",", i);
        else if (val is long[] l)
            return string.Join(",", l);
        else
            return val.ToString();
    }
}
