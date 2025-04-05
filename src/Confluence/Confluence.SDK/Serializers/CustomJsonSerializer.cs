using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Confluence.ApiV2.Serializers;

public class CustomJsonSerializer
{
    public string Serialize(object obj)
    {
        var settings = new JsonSerializerSettings
        {
            Converters = { new StringEnumConverter() },
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
        };

        return JsonConvert.SerializeObject(obj, settings);
    }

    public T Deserialize<T>(string json)
    {
        var res = JsonConvert.DeserializeObject<T>(json);
        return res;
    }
}
