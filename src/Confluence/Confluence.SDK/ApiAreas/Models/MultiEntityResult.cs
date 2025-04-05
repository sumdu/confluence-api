using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models;

public class MultiEntityResult<T>
{
    // this comes from the header
    //string Link { get; set; }

    [JsonProperty("results")]
    public T[] Results { get; set; }

    [JsonProperty("_links")]
    public MultiEntityLinks? Links { get; set; }

}

public class MultiEntityLinks
{
    [JsonProperty("next")]
    public string Next { get; set; }

    [JsonProperty("base")]
    public string Base { get; set; }
}
