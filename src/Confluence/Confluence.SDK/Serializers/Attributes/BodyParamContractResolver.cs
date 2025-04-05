using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace RichkaSoft.Confluence.ApiV2.Serializers.Attributes;

internal class BodyParamContractResolver : DefaultContractResolver
{
    private bool _isTopLevelObject = true;

    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        // Problem here is that it must only take into account high-level properties, marked with [BodyParam]
        // but currently it also checks nested properties, which is not correct

        if (!_isTopLevelObject)
        {
            return base.CreateProperties(type, memberSerialization);
        }

        var res = base.CreateProperties(type, memberSerialization)
            .Where(p => p.AttributeProvider?.GetAttributes(typeof(BodyParamAttribute), true).Any() == true)
            .ToList();

        // After processing top-level properties, set the flag to false to skip the resolver for nested properties
        _isTopLevelObject = false;

        return res;
    }

    protected override Newtonsoft.Json.Serialization.JsonContract CreateContract(Type objectType)
    {
        var contract = base.CreateContract(objectType);

        if (contract is Newtonsoft.Json.Serialization.JsonStringContract)
            return CreateObjectContract(objectType);
        return contract;
    }
}
