using Confluence.ApiV2.Extensions;
using Confluence.ApiV2.Serializers.Attributes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Confluence.ApiV2.Serializers;

internal class BodyParamsSerializer2
{
    public string Serialize(object o)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = { new BodyParamJsonConverter(true) },
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        var json = JsonSerializer.Serialize(o, options);
        return json;
    }
}

public class BodyParamJsonConverter : JsonConverter<object>
{
    private bool IncludeOnlyBodyParams;

    public BodyParamJsonConverter(bool includeOnlyBodyParams)
    {
        IncludeOnlyBodyParams = includeOnlyBodyParams;
    }

    public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException("Deserialization is not supported.");
    }

    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        // TODO: add writing string values as-is, do not always open a new object...
        //if (value is string s)
        //{
            
        //    return;
        //}


        writer.WriteStartObject();

        // Get all properties marked with [BodyParam] for the object's type
        var properties = value.GetType().GetProperties().AsEnumerable();

        if (IncludeOnlyBodyParams)
            properties = properties.Where(prop => prop.IsDefined(typeof(BodyParamAttribute), true));

        foreach (var prop in properties)
        {
            object propValue = prop.GetValue(value);
            if (propValue != null)
            {
                var propertyName = prop.GetJsonPropertyName();
                writer.WritePropertyName(propertyName);

                // Check if the property value is a primitive type or a string
                if (propValue.GetType().IsPrimitive || propValue is string)
                {
                    // Serialize primitive types and strings directly
                    //JsonSerializer.Serialize(writer, propValue, options);

                    if (propValue is string s)
                        writer.WriteStringValue(s);
                    else if (propValue is int i)
                        writer.WriteNumberValue(i);
                    else if (propValue is long l)
                        writer.WriteNumberValue(l);
                    else if (propValue is bool b)
                        writer.WriteBooleanValue(b);
                    else
                        writer.WriteRawValue("raw value" + propValue.ToString());
                }
                else if (propValue.GetType().IsEnum)
                {
                    // Serialize enum values as string
                    JsonSerializer.Serialize(writer, propValue.GetJsonPropertyValue(), options);
                }
                else
                {
                    // for innder properties ignore BodyParamAttribute
                    var newOptions = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                        Converters = { new BodyParamJsonConverter(false) },
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    };

                    // Serialize complex objects normally
                    JsonSerializer.Serialize(writer, propValue, 
                        typeof(object),
                        //propValue.GetType(), 
                        newOptions);

                    //var json = JsonSerializer.Serialize((object)propValue, options);
                    //writer.WriteRawValue(json);

                }
            }
        }

        writer.WriteEndObject();
    }
}