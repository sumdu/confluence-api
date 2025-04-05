namespace Confluence.ApiV2.ApiAreas.Models._Common;

public class Version
{
    public DateTime CreatedAt { get; set; }
    public string Message { get; set; }
    public long Number { get; set; }
    public bool MinorEdit { get; set; }
    public string AuthorId { get; set; }
}
