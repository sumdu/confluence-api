using Confluence.ApiV2.ApiAreas.Models._Common;
using Confluence.ApiV2.ApiAreas.Models.Pages;
using Newtonsoft.Json;

namespace Confluence.ApiV2.ApiAreas.Models.Attachments;

public class AttachmentSingle
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("status")]
    public ContentStatus Status { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("pageId")]
    public string? PageId { get; set; }

    [JsonProperty("blogPostId")]
    public string? BlogPostId { get; set; }

    [JsonProperty("customContentId")]
    public string? CustomContentId { get; set; }

    [JsonProperty("mediaType")]
    public string MediaType { get; set; }

    [JsonProperty("mediaTypeDescription")]
    public string MediaTypeDescription { get; set; }

    [JsonProperty("comment")]
    public string? Comment { get; set; }

    [JsonProperty("fileId")]
    public string FileId { get; set; }

    [JsonProperty("fileSize")]
    public long FileSize { get; set; }

    [JsonProperty("webuiLink")]
    public string WebuiLink { get; set; }

    [JsonProperty("downloadLink")]
    public string DownloadLink { get; set; }

    [JsonProperty("version")]
    public _Common.Version Version { get; set; }

    [JsonProperty("_links")]
    public AttachmentLinks Links { get; set; }
}