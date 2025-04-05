using Confluence.ApiV2.Serializers.Attributes;

namespace Confluence.ApiV2.ApiAreas.Models.Spaces;

public class GetSpacesRequest : PaginatedRequest
{
    [QueryParam]
    public string[]? ids { get; set; } = null;
    [QueryParam]
    public string[]? keys { get; set; } = null;
    [QueryParam]
    public SpaceType? type { get; set; } = null;
    [QueryParam]
    public SpaceStatus? status { get; set; } = null;
    [QueryParam]
    public string[]? labels { get; set; } = null;
    [QueryParam]
    public string? favouritedBy { get; set; } = null;
    [QueryParam]
    public string? notFavouritedBy { get; set; } = null;
    [QueryParam]
    public GetSpacesRequestSortEnum? sort { get; set; } = null;
    [QueryParam]
    public GetSpacesRequestDescriptionEnum? descriptionFormat { get; set; } = null;
    [QueryParam]
    public bool? includeIcon { get; set; } = null;
}
