using Confluence.ApiV2.Serializers.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Confluence.ApiV2.Serializers;

internal class BodyParamsSerializer
{
    public string Serialize(object o)
    {
        var settings = new JsonSerializerSettings
        {
            ContractResolver = new BodyParamContractResolver(),
            Converters = { new StringEnumConverter(), new ExpandoObjectConverter() },
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
        };
        var json = JsonConvert.SerializeObject(o, settings);
        return json;
    }
}
