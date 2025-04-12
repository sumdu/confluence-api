# Confluence API v2 SDK for .NET

The Confluence REST API V2 Client is a .NET client for the Confluence REST API v2. This library makes it easy for developes to create an application that interacts with Confluence. It is designed to be simple and easy to use, while still providing all the functionality you need to work with Confluence.

**WARNING: this code is still in developemnt and some features may not work. Use at your own risk in production.**

Confluence API v2 documentation is available at: 
https://developer.atlassian.com/cloud/confluence/rest/v2/

### Usage

Below examples demonstrate the basic usage. 

Please, replace placeholders with your actual Confluence domain, email and API-token. 

#### 1. Authentication

To use the Confluence API, you need to authenticate your requests. The SDK supports both Basic Authentication.

```csharp
// Get api token from https://id.atlassian.com/manage-profile/security/api-tokens
var client = new ConfluenceClient({confluence-url}, {email}, {api-token});
```

#### 2. Retrieve All Spaces

```csharp
var spaces = client.Spaces.GetSpaces(new GetSpacesRequest());
```

#### 3. Retrieve All Pages From a Space

```csharp
var spaceId = 4555533366;
var pages = client.Pages.GetPagesInSpace(new GetPagesInSpaceRequest { Id = spaceId });
```

#### 4. How to use pagination

```csharp
// Get first page
var allSpacesFirstPage = client.Spaces.GetSpaces(new GetSpacesRequest());
	
// Get remianing pages
var allSpaces = client.FetchAllPages(allSpacesFirstPage);
```

### Supported APIs

Following APIs are supported at the moment:

  ☑ Attachment
  ☑ Ancestors
  ☑ Blog Post
  ☑ Children
  ☑ Classification Level
  ☐ Comment
  ☑ Content
  ☑ Content Properties
  ☐ Custom Content
  ☐ Database
  ☑ Data Policies
  ☑ Descendants
  ☑ Folder
  ☑ Label
  ☑ Like
  ☑ Operation
  ☑ Page
  ☑ Smart Link
  ☑ Space
  ☐ Space Permissions
  ☐ Space Properties
  ☐ Space Roles
  ☐ Task
  ☐ User
  ☑ Version
  ☐ Whiteboard

## Contribute

Please, create Pull Requests for any new features or bug fixes. We will review and merge them as soon as possible. 

You can also create issues for any bugs or feature requests you would like to see in the library.



