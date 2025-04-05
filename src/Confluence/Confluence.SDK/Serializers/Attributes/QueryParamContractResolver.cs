using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Confluence.ApiV2.Serializers.Attributes;

internal class QueryParamContractResolver : DefaultContractResolver
{
    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        return base.CreateProperties(type, memberSerialization)
            .Where(p => p.AttributeProvider?.GetAttributes(typeof(QueryParamAttribute), true).Any() == true)
            .ToList();
    }
}
