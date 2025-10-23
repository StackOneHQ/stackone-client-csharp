# Lms
(*Lms*)

## Overview

### Available Operations

* [GetCourse](#getcourse) - Get Course
* [ListUserAssignments](#listuserassignments) - List User Assignments
* [BatchUpsertContent](#batchupsertcontent) - Batch Upsert Content
* [ListContent](#listcontent) - List Content
* [CreateUserCompletion](#createusercompletion) - Create User Completion
* [GetUserCompletion](#getusercompletion) - Get User Completion
* [DeleteUserCompletion](#deleteusercompletion) - Delete User Completion
* [GetCategory](#getcategory) - Get Category
* [ListUsers](#listusers) - List Users
* [GetUser](#getuser) - Get User
* [ListSkills](#listskills) - List Skills

## GetCourse

Get Course

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_get_course" method="get" path="/unified/lms/courses/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetCourseRequest req = new LmsGetCourseRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,content_ids,remote_content_ids,title,description,languages,cover_url,url,active,duration,categories,skills,updated_at,created_at,content,provider,localizations,authors,unified_custom_fields",
};

var res = await sdk.Lms.GetCourseAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [LmsGetCourseRequest](../../Models/Requests/LmsGetCourseRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[LmsGetCourseResponse](../../Models/Requests/LmsGetCourseResponse.md)**

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

## ListUserAssignments

List User Assignments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_list_user_assignments" method="get" path="/unified/lms/users/{id}/assignments" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListUserAssignmentsRequest req = new LmsListUserAssignmentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,user_id,remote_user_id,course_id,remote_course_id,updated_at,created_at,due_date,status,progress,learning_object_type,learning_object_id,remote_learning_object_id,learning_object_external_reference,certificate_url,result,completed_at,unified_custom_fields",
    Filter = new LmsListUserAssignmentsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    UserId = "c28xyrc55866bvuv",
    RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
};

LmsListUserAssignmentsResponse? res = await sdk.Lms.ListUserAssignmentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [LmsListUserAssignmentsRequest](../../Models/Requests/LmsListUserAssignmentsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[LmsListUserAssignmentsResponse](../../Models/Requests/LmsListUserAssignmentsResponse.md)**

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

## BatchUpsertContent

Batch Upsert Content

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_batch_upsert_content" method="post" path="/unified/lms/content/batch" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.BatchUpsertContentAsync(
    xAccountId: "<id>",
    lmsBatchUpsertContentRequestDto: new LmsBatchUpsertContentRequestDto() {
        Items = new List<LmsUpsertContentRequestDto>() {
            new LmsUpsertContentRequestDto() {
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
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The account identifier                                                                        |
| `LmsBatchUpsertContentRequestDto`                                                             | [LmsBatchUpsertContentRequestDto](../../Models/Components/LmsBatchUpsertContentRequestDto.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |

### Response

**[LmsBatchUpsertContentResponse](../../Models/Requests/LmsBatchUpsertContentResponse.md)**

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

## ListContent

List Content

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_list_content" method="get" path="/unified/lms/content" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListContentRequest req = new LmsListContentRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_reference,course_ids,remote_course_ids,title,description,additional_data,languages,content_url,mobile_launch_content_url,content_type,cover_url,active,duration,order,categories,skills,updated_at,created_at,provider,localizations,tags,authors,unified_custom_fields",
    Filter = new LmsListContentFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

LmsListContentResponse? res = await sdk.Lms.ListContentAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [LmsListContentRequest](../../Models/Requests/LmsListContentRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[LmsListContentResponse](../../Models/Requests/LmsListContentResponse.md)**

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

## CreateUserCompletion

Create User Completion

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_create_user_completion" method="post" path="/unified/lms/users/{id}/completions" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.CreateUserCompletionAsync(
    xAccountId: "<id>",
    id: "<id>",
    lmsCreateCompletionRequestDto: new LmsCreateCompletionRequestDto() {
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
        CompletedAt = System.DateTime.Parse("2021-07-21T14:00:00.000Z"),
        LearningObjectId = "e3gd34-23tr21-er234-345er56",
        TimeSpent = "PT1H30M45S",
        LearningObjectExternalReference = "learning-content-123",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `XAccountId`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The account identifier                                                                    |
| `Id`                                                                                      | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `LmsCreateCompletionRequestDto`                                                           | [LmsCreateCompletionRequestDto](../../Models/Components/LmsCreateCompletionRequestDto.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |

### Response

**[LmsCreateUserCompletionResponse](../../Models/Requests/LmsCreateUserCompletionResponse.md)**

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

## GetUserCompletion

Get User Completion

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_get_user_completion" method="get" path="/unified/lms/users/{id}/completions/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetUserCompletionRequest req = new LmsGetUserCompletionRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
};

var res = await sdk.Lms.GetUserCompletionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [LmsGetUserCompletionRequest](../../Models/Requests/LmsGetUserCompletionRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[LmsGetUserCompletionResponse](../../Models/Requests/LmsGetUserCompletionResponse.md)**

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

## DeleteUserCompletion

Delete User Completion

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_delete_user_completion" method="delete" path="/unified/lms/users/{id}/completions/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.DeleteUserCompletionAsync(
    xAccountId: "<id>",
    id: "<id>",
    subResourceId: "<id>"
);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `XAccountId`           | *string*               | :heavy_check_mark:     | The account identifier |
| `Id`                   | *string*               | :heavy_check_mark:     | N/A                    |
| `SubResourceId`        | *string*               | :heavy_check_mark:     | N/A                    |

### Response

**[LmsDeleteUserCompletionResponse](../../Models/Requests/LmsDeleteUserCompletionResponse.md)**

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

## GetCategory

Get Category

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_get_category" method="get" path="/unified/lms/categories/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetCategoryRequest req = new LmsGetCategoryRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active,hierarchy,level,language,unified_custom_fields",
};

var res = await sdk.Lms.GetCategoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [LmsGetCategoryRequest](../../Models/Requests/LmsGetCategoryRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[LmsGetCategoryResponse](../../Models/Requests/LmsGetCategoryResponse.md)**

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

## ListUsers

List Users

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_list_users" method="get" path="/unified/lms/users" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListUsersRequest req = new LmsListUsersRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_reference,active,email,phone_number,created_at,updated_at,name,unified_custom_fields",
    Filter = null,
};

LmsListUsersResponse? res = await sdk.Lms.ListUsersAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [LmsListUsersRequest](../../Models/Requests/LmsListUsersRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[LmsListUsersResponse](../../Models/Requests/LmsListUsersResponse.md)**

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

## GetUser

Get User

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_get_user" method="get" path="/unified/lms/users/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetUserRequest req = new LmsGetUserRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,active,email,phone_number,created_at,updated_at,name,unified_custom_fields",
};

var res = await sdk.Lms.GetUserAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [LmsGetUserRequest](../../Models/Requests/LmsGetUserRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[LmsGetUserResponse](../../Models/Requests/LmsGetUserResponse.md)**

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

## ListSkills

List Skills

### Example Usage

<!-- UsageSnippet language="csharp" operationID="lms_list_skills" method="get" path="/unified/lms/skills" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListSkillsRequest req = new LmsListSkillsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active,hierarchy,language,unified_custom_fields",
    Filter = new LmsListSkillsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

LmsListSkillsResponse? res = await sdk.Lms.ListSkillsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [LmsListSkillsRequest](../../Models/Requests/LmsListSkillsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[LmsListSkillsResponse](../../Models/Requests/LmsListSkillsResponse.md)**

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