namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class ContentProperty
{
    public string Id { get; set; }
    public string Key { get; set; }
    public object Value { get; set; } // JSON object, representing value of the property
    public object Version { get; set; }
}
