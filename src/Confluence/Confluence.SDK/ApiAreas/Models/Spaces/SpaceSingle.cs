using RichkaSoft.Confluence.ApiV2.ApiAreas.Models._Common;
using RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;
using Newtonsoft.Json;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Spaces;

public class SpaceSingle
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public SpaceType Type { get; set; }

    [JsonProperty("status")]
    public SpaceStatus Status { get; set; }

    [JsonProperty("authorId")]
    public string AuthorId { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("homepageId")]
    public string HomepageId { get; set; }

    [JsonProperty("description")]
    public SpaceDescription Description { get; set; }

    [JsonProperty("icon")]
    public SpaceIcon Icon { get; set; }

    [JsonProperty("labels")]
    public SpaceSingleLabels Labels { get; set; }

    [JsonProperty("properties")]
    public SpaceSingleProperties Properties { get; set; }

    [JsonProperty("operations")]
    public SpaceSingleOperations Operations { get; set; }

    [JsonProperty("permissions")]
    public SpaceSinglePermissions Permissions { get; set; }

    [JsonProperty("_links")]
    public SpaceLinks_Object Links { get; set; }
}

public class SpaceSingleProperties
{
    [JsonProperty("results")]
    public List<SpaceProperty> Results { get; set; }

    [JsonProperty("meta")]
    public OptionalFieldMeta Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks Links { get; set; }
}

public class SpaceSingleOperations
{
    [JsonProperty("results")]
    public List<Operation> Results { get; set; }

    [JsonProperty("meta")]
    public OptionalFieldMeta Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks Links { get; set; }
}

public class SpaceSinglePermissions
{
    [JsonProperty("results")]
    public List<SpacePermissionAssignment> Results { get; set; }

    [JsonProperty("meta")]
    public OptionalFieldMeta Meta { get; set; }

    [JsonProperty("_links")]
    public OptionalFieldLinks Links { get; set; }
}

public class SpacePermissionAssignment
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("principal")]
    public SpacePermissionAssignmentPrincipal Principal { get; set; }

    [JsonProperty("operation")]
    public SpacePermissionAssignmentOperation Operation { get; set; }
}

public class SpacePermissionAssignmentPrincipal
{
    [JsonProperty("type")]
    public SpacePermissionAssignmentPrincipalType Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }
}

public enum SpacePermissionAssignmentPrincipalType
{
    [JsonProperty("user")]
    User,
    [JsonProperty("group")]
    Group,
    [JsonProperty("role")]
    Role
}

public class SpacePermissionAssignmentOperation
{
    [JsonProperty("key")]
    public SpacePermissionAssignmentOperationKey Key { get; set; }

    [JsonProperty("targetType")]
    public SpacePermissionAssignmentOperationTargetType TargetType { get; set; }
}

public enum SpacePermissionAssignmentOperationKey
{
    [JsonProperty("use")]
    Use,
    [JsonProperty("create")]
    Create,
    [JsonProperty("read")]
    Read,
    [JsonProperty("update")]
    Update,
    [JsonProperty("delete")]
    Delete,
    [JsonProperty("copy")]
    Copy,
    [JsonProperty("move")]
    Move,
    [JsonProperty("export")]
    Export,
    [JsonProperty("purge")]
    Purge,
    [JsonProperty("purge_version")]
    PurgeVersion,
    [JsonProperty("administer")]
    Administer,
    [JsonProperty("restore")]
    Restore,
    [JsonProperty("create_space")]
    CreateSpace,
    [JsonProperty("restrict_content")]
    RestrictContent,
    [JsonProperty("archive")]
    Archive
}

public enum SpacePermissionAssignmentOperationTargetType
{
    [JsonProperty("page")]
    Page,
    [JsonProperty("blogpost")]
    Blogpost,
    [JsonProperty("comment")]
    Comment,
    [JsonProperty("attachment")]
    Attachment,
    [JsonProperty("whiteboard")]
    Whiteboard,
    [JsonProperty("database")]
    Database,
    [JsonProperty("embed")]
    Embed,
    [JsonProperty("folder")]
    Folder,
    [JsonProperty("space")]
    Space,
    [JsonProperty("application")]
    Application
}

public class SpaceProperty
{
    public string Id { get; set; }
    public string Key { get; set; }
    public string CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public SpacePropertyVersion Version { get; set; }
}

public class SpacePropertyVersion
{
    public string CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public string Message { get; set; }
    public long Number { get; set; }
}