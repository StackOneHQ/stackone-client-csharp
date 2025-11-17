# Content
(*Lms.Content*)

## Overview

### Available Operations

* [Upsert](#upsert) - Upsert External Linking Learning Objects
* [Get](#get) - Get Content
* [Update](#update) - Update External Linking Learning Objects

## Upsert

Create or update an external linking learning object that redirects users to a provider platform for consumption and progress tracking. 

See [here](https://docs.stackone.com/integration-guides/lms/external-content-providers/introduction) for more information about external linking learning objects.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_upsert_content" method="put" path="/unified/lms/content" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.Content.UpsertAsync(
    xAccountId: "<id>",
    lmsUpsertContentRequestDto: new LmsUpsertContentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Title = "Software Engineer Lv 1",
        Description = "This video acts as learning content for software engineers.",
        Languages = new List<LanguageEnum>() {
            new LanguageEnum() {
                Value = LanguageEnumValue.EnGB,
            },
        },
        ContentUrl = "https://www.youtube.com/watch?v=16873",
        MobileLaunchContentUrl = "https://www.mobile.youtube.com/watch?v=16873",
        CoverUrl = "https://www.googledrive.com/?v=16873",
        Active = LmsUpsertContentRequestDtoActiveUnion.CreateBoolean(
            true
        ),
        Duration = "P3Y6M4DT12H30M5S",
        Skills = new List<CreateSkillsApiModel>() {
            new CreateSkillsApiModel() {
                Id = "12345",
                Name = "Sales Techniques",
            },
        },
        Order = 1D,
        Localizations = new List<LocalizationModel>() {
            new LocalizationModel() {
                Title = "Software Engineer Lv 1",
                Description = "This course acts as learning resource for software engineers.",
            },
            new LocalizationModel() {
                Title = "Software Engineer: A comprehensive guide",
                Description = "This course acts as learning resource for software engineers.",
            },
        },
        Tags = new List<string>() {
            "Sales Techniques",
            "Customer Service",
        },
        Authors = new List<AuthorModel>() {
            new AuthorModel() {
                Id = "123",
                Name = "John Doe",
            },
        },
        UpdatedAt = System.DateTime.Parse("2021-07-21T14:00:00.000Z"),
        CreatedAt = System.DateTime.Parse("2021-07-21T14:00:00.000Z"),
        ExternalReference = "SOFTWARE-ENG-LV1-TRAINING-VIDEO-1",
        Categories = new List<CreateCategoriesApiModel>() {
            new CreateCategoriesApiModel() {
                Id = "16873-IT345",
                UnifiedCustomFields = new Dictionary<string, object>() {
                    { "my_project_custom_field_1", "REF-1236" },
                    { "my_project_custom_field_2", "some other value" },
                },
                Name = "Information-Technology",
                Language = new CreateCategoriesApiModelLanguage() {
                    Value = CreateCategoriesApiModelLanguageValue.EnGB,
                },
            },
        },
        AdditionalData = new List<AdditionalData>() {
            new AdditionalData() {
                Id = "learning_outcomes",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Value = AdditionalDataValue.CreateStr(
                    "This is additional data"
                ),
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `XAccountId`                                                                        | *string*                                                                            | :heavy_check_mark:                                                                  | The account identifier                                                              |
| `LmsUpsertContentRequestDto`                                                        | [LmsUpsertContentRequestDto](../../Models/Components/LmsUpsertContentRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |

### Response

**[LmsUpsertContentResponse](../../Models/Requests/LmsUpsertContentResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |

## Get

Retrieve a content type learning object by its identifier. 

These are the most granular learning objects (e.g. video, document, podcast) on a platform. 

Only content objects for which the platform supports progress and completion tracking are returned.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_get_content" method="get" path="/unified/lms/content/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetContentRequest req = new LmsGetContentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,course_ids,remote_course_ids,title,description,additional_data,languages,content_url,mobile_launch_content_url,content_type,cover_url,active,duration,order,categories,skills,updated_at,created_at,provider,localizations,tags,authors,unified_custom_fields",
};

var res = await sdk.Lms.Content.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [LmsGetContentRequest](../../Models/Requests/LmsGetContentRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[LmsGetContentResponse](../../Models/Requests/LmsGetContentResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |

## Update

Update an external linking learning object that redirects users to a provider platform for consumption and progress tracking. 

See [here](https://docs.stackone.com/integration-guides/lms/external-content-providers/introduction) for more information about external linking learning objects.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_update_content" method="patch" path="/unified/lms/content/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.Content.UpdateAsync(
    xAccountId: "<id>",
    id: "<id>",
    lmsCreateContentRequestDto: new LmsCreateContentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Title = "Software Engineer Lv 1",
        Description = "This video acts as learning content for software engineers.",
        Languages = new List<LanguageEnum>() {
            new LanguageEnum() {
                Value = LanguageEnumValue.EnGB,
            },
        },
        ContentUrl = "https://www.youtube.com/watch?v=16873",
        MobileLaunchContentUrl = "https://www.mobile.youtube.com/watch?v=16873",
        CoverUrl = "https://www.googledrive.com/?v=16873",
        Active = LmsCreateContentRequestDtoActiveUnion.CreateBoolean(
            true
        ),
        Duration = "P3Y6M4DT12H30M5S",
        Skills = new List<CreateSkillsApiModel>() {
            new CreateSkillsApiModel() {
                Id = "12345",
                Name = "Sales Techniques",
            },
        },
        Order = 1D,
        Localizations = new List<LocalizationModel>() {
            new LocalizationModel() {
                Title = "Software Engineer Lv 1",
                Description = "This course acts as learning resource for software engineers.",
            },
            new LocalizationModel() {
                Title = "Software Engineer Lv 1",
                Description = "This video acts as learning content for software engineers.",
            },
        },
        Tags = new List<string>() {
            "Sales Techniques",
            "Customer Service",
        },
        Authors = new List<AuthorModel>() {
            new AuthorModel() {
                Id = "123",
                Name = "John Doe",
            },
        },
        UpdatedAt = System.DateTime.Parse("2021-07-21T14:00:00.000Z"),
        CreatedAt = System.DateTime.Parse("2021-07-21T14:00:00.000Z"),
        ExternalReference = "SOFTWARE-ENG-LV1-TRAINING-VIDEO-1",
        Categories = new List<CreateCategoriesApiModel>() {
            new CreateCategoriesApiModel() {
                Name = "Technology",
            },
        },
        AdditionalData = new List<AdditionalData>() {
            new AdditionalData() {
                Id = "learning_outcomes",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Value = AdditionalDataValue.CreateStr(
                    "This is additional data"
                ),
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `XAccountId`                                                                        | *string*                                                                            | :heavy_check_mark:                                                                  | The account identifier                                                              |
| `Id`                                                                                | *string*                                                                            | :heavy_check_mark:                                                                  | N/A                                                                                 |
| `LmsCreateContentRequestDto`                                                        | [LmsCreateContentRequestDto](../../Models/Components/LmsCreateContentRequestDto.md) | :heavy_check_mark:                                                                  | N/A                                                                                 |

### Response

**[LmsUpdateContentResponse](../../Models/Requests/LmsUpdateContentResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |