# Lms
(*Lms*)

## Overview

### Available Operations

* [ListCourses](#listcourses) - List Courses
* [GetCourse](#getcourse) - Get Course
* [ListUserAssignments](#listuserassignments) - List User Assignments
* [CreateUserAssignment](#createuserassignment) - Create User Assignment
* [GetUserAssignment](#getuserassignment) - Get User Assignment
* [BatchUpsertContent](#batchupsertcontent) - Batch Upsert Content
* [ListContent](#listcontent) - List Content
* [UpsertContent](#upsertcontent) - Upsert Content
* [GetContent](#getcontent) - Get Content
* [UpdateContent](#updatecontent) - Update Content
* [ListUserCompletions](#listusercompletions) - List User Completions
* [CreateUserCompletion](#createusercompletion) - Create User Completion
* [GetUserCompletion](#getusercompletion) - Get User Completion
* [DeleteUserCompletion](#deleteusercompletion) - Delete User Completion
* [ListCompletions](#listcompletions) - List Completions
* [GetCompletion](#getcompletion) - Get Completion
* [GetCategory](#getcategory) - Get Category
* [ListCategories](#listcategories) - List Categories
* [ListUsers](#listusers) - List Users
* [GetUser](#getuser) - Get User
* [GetSkill](#getskill) - Get Skill
* [ListSkills](#listskills) - List Skills
* [ListAssignments](#listassignments) - List Assignments
* [GetAssignment](#getassignment) - Get Assignment

## ListCourses

List Courses

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListCoursesRequest req = new LmsListCoursesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_reference,content_ids,remote_content_ids,title,description,languages,cover_url,url,active,duration,categories,skills,updated_at,created_at,content,provider,localizations,authors",
    Filter = new LmsListCoursesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

LmsListCoursesResponse? res = await sdk.Lms.ListCoursesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [LmsListCoursesRequest](../../Models/Requests/LmsListCoursesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[LmsListCoursesResponse](../../Models/Requests/LmsListCoursesResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetCourse

Get Course

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetCourseRequest req = new LmsGetCourseRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,content_ids,remote_content_ids,title,description,languages,cover_url,url,active,duration,categories,skills,updated_at,created_at,content,provider,localizations,authors",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListUserAssignments

List User Assignments

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListUserAssignmentsRequest req = new LmsListUserAssignmentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,user_id,remote_user_id,course_id,remote_course_id,updated_at,created_at,due_date,status,progress,learning_object_type,learning_object_id,remote_learning_object_id,learning_object_external_reference",
    Filter = new LmsListUserAssignmentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## CreateUserAssignment

Create User Assignment

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.CreateUserAssignmentAsync(
    xAccountId: "<id>",
    id: "<id>",
    lmsCreateAssignmentRequestDto: new LmsCreateAssignmentRequestDto() {
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
        LearningObjectId = "e3gd34-23tr21-er234-345er56",
        LearningObjectExternalReference = "learning-content-123",
        Progress = 40D,
        CreatedAt = "2021-07-21T14:00:00.000Z",
        DueDate = "2021-07-21T14:00:00.000Z",
        Status = new LmsCreateAssignmentRequestDtoStatus() {
            Value = LmsCreateAssignmentRequestDtoValue.InProgress,
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `XAccountId`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The account identifier                                                                    |
| `Id`                                                                                      | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `LmsCreateAssignmentRequestDto`                                                           | [LmsCreateAssignmentRequestDto](../../Models/Components/LmsCreateAssignmentRequestDto.md) | :heavy_check_mark:                                                                        | N/A                                                                                       |

### Response

**[LmsCreateUserAssignmentResponse](../../Models/Requests/LmsCreateUserAssignmentResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetUserAssignment

Get User Assignment

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetUserAssignmentRequest req = new LmsGetUserAssignmentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
};

var res = await sdk.Lms.GetUserAssignmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [LmsGetUserAssignmentRequest](../../Models/Requests/LmsGetUserAssignmentRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[LmsGetUserAssignmentResponse](../../Models/Requests/LmsGetUserAssignmentResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## BatchUpsertContent

Batch Upsert Content

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
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
                ExternalReference = "SOFTWARE-ENG-LV1-TRAINING-VIDEO-1",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListContent

List Content

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListContentRequest req = new LmsListContentRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_reference,course_ids,remote_course_ids,title,description,additional_data,languages,content_url,mobile_launch_content_url,content_type,cover_url,active,duration,order,categories,skills,updated_at,created_at,provider,localizations,tags,authors",
    Filter = new LmsListContentFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## UpsertContent

Upsert Content

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.UpsertContentAsync(
    xAccountId: "<id>",
    lmsUpsertContentRequestDto: new LmsUpsertContentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        ExternalReference = "SOFTWARE-ENG-LV1-TRAINING-VIDEO-1",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetContent

Get Content

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetContentRequest req = new LmsGetContentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,course_ids,remote_course_ids,title,description,additional_data,languages,content_url,mobile_launch_content_url,content_type,cover_url,active,duration,order,categories,skills,updated_at,created_at,provider,localizations,tags,authors",
};

var res = await sdk.Lms.GetContentAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [LmsGetContentRequest](../../Models/Requests/LmsGetContentRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[LmsGetContentResponse](../../Models/Requests/LmsGetContentResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## UpdateContent

Update Content

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Lms.UpdateContentAsync(
    xAccountId: "<id>",
    id: "<id>",
    lmsCreateContentRequestDto: new LmsCreateContentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        ExternalReference = "SOFTWARE-ENG-LV1-TRAINING-VIDEO-1",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListUserCompletions

List User Completions

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListUserCompletionsRequest req = new LmsListUserCompletionsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_id,remote_external_id,external_reference,content_id,remote_content_id,course_id,remote_course_id,user_id,remote_user_id,completed_at,updated_at,created_at,result,content_external_reference,learning_object_type,learning_object_id,remote_learning_object_id,learning_object_external_reference,time_spent",
    Filter = new LmsListUserCompletionsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

LmsListUserCompletionsResponse? res = await sdk.Lms.ListUserCompletionsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [LmsListUserCompletionsRequest](../../Models/Requests/LmsListUserCompletionsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[LmsListUserCompletionsResponse](../../Models/Requests/LmsListUserCompletionsResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## CreateUserCompletion

Create User Completion

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
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
        CompletedAt = "2021-07-21T14:00:00.000Z",
        LearningObjectId = "e3gd34-23tr21-er234-345er56",
        LearningObjectExternalReference = "learning-content-123",
        TimeSpent = "PT1H30M45S",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetUserCompletion

Get User Completion

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## DeleteUserCompletion

Delete User Completion

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;

var sdk = new StackOneClient(security: new Security() {
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListCompletions

List Completions

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListCompletionsRequest req = new LmsListCompletionsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_id,remote_external_id,external_reference,content_id,remote_content_id,course_id,remote_course_id,user_id,remote_user_id,completed_at,updated_at,created_at,result,content_external_reference,learning_object_type,learning_object_id,remote_learning_object_id,learning_object_external_reference,time_spent",
    Filter = new LmsListCompletionsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

LmsListCompletionsResponse? res = await sdk.Lms.ListCompletionsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [LmsListCompletionsRequest](../../Models/Requests/LmsListCompletionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[LmsListCompletionsResponse](../../Models/Requests/LmsListCompletionsResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetCompletion

Get Completion

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetCompletionRequest req = new LmsGetCompletionRequest() {
    XAccountId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.GetCompletionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [LmsGetCompletionRequest](../../Models/Requests/LmsGetCompletionRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[LmsGetCompletionResponse](../../Models/Requests/LmsGetCompletionResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetCategory

Get Category

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetCategoryRequest req = new LmsGetCategoryRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active,hierarchy,level,language",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListCategories

List Categories

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListCategoriesRequest req = new LmsListCategoriesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active,hierarchy,level,language",
    Filter = new LmsListCategoriesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

LmsListCategoriesResponse? res = await sdk.Lms.ListCategoriesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [LmsListCategoriesRequest](../../Models/Requests/LmsListCategoriesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[LmsListCategoriesResponse](../../Models/Requests/LmsListCategoriesResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListUsers

List Users

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListUsersRequest req = new LmsListUsersRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_reference,active,email,phone_number,created_at,updated_at,name",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetUser

Get User

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetUserRequest req = new LmsGetUserRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,external_reference,active,email,phone_number,created_at,updated_at,name",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetSkill

Get Skill

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetSkillRequest req = new LmsGetSkillRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active,hierarchy,language",
};

var res = await sdk.Lms.GetSkillAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [LmsGetSkillRequest](../../Models/Requests/LmsGetSkillRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[LmsGetSkillResponse](../../Models/Requests/LmsGetSkillResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListSkills

List Skills

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListSkillsRequest req = new LmsListSkillsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active,hierarchy,language",
    Filter = new LmsListSkillsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
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

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## ListAssignments

List Assignments

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsListAssignmentsRequest req = new LmsListAssignmentsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,external_reference,user_id,remote_user_id,course_id,remote_course_id,updated_at,created_at,due_date,status,progress,learning_object_type,learning_object_id,remote_learning_object_id,learning_object_external_reference",
    Filter = new LmsListAssignmentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    UserId = "c28xyrc55866bvuv",
    RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
};

LmsListAssignmentsResponse? res = await sdk.Lms.ListAssignmentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [LmsListAssignmentsRequest](../../Models/Requests/LmsListAssignmentsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[LmsListAssignmentsResponse](../../Models/Requests/LmsListAssignmentsResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## GetAssignment

Get Assignment

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

LmsGetAssignmentRequest req = new LmsGetAssignmentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
};

var res = await sdk.Lms.GetAssignmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [LmsGetAssignmentRequest](../../Models/Requests/LmsGetAssignmentRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[LmsGetAssignmentResponse](../../Models/Requests/LmsGetAssignmentResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.PreconditionFailedResponseException  | 412                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |