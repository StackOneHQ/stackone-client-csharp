# Candidates
(*Ats.Candidates*)

## Overview

### Available Operations

* [Create](#create) - Create Candidate
* [Get](#get) - Get Candidate

## Create

Create Candidate

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_create_candidate" method="post" path="/unified/ats/candidates" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.Candidates.CreateAsync(
    xAccountId: "<id>",
    atsCreateCandidateRequestDto: new AtsCreateCandidateRequestDto() {
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        PhoneNumbers = new List<PhoneNumber>() {
            new PhoneNumber() {
                Phone = "+447700112233",
            },
        },
        Name = "Romain Sestier",
        FirstName = "Romain",
        LastName = "Sestier",
        Email = "sestier.romain123@gmail.com",
        SocialLinks = new List<SocialLink>() {
            new SocialLink() {
                Type = "linkedin",
                Url = "https://www.linkedin.com/in/romainsestier/",
            },
        },
        Company = "Company Inc.",
        Title = "Software Engineer",
        HiredAt = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Country = "United States",
        CustomFields = new List<CustomFields>() {
            new CustomFields() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Name = "Training Completion Status",
                Value = CustomFieldsValueUnion.CreateStr(
                    "Completed"
                ),
                ValueId = "value_456",
                RemoteValueId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `AtsCreateCandidateRequestDto`                                                          | [AtsCreateCandidateRequestDto](../../Models/Components/AtsCreateCandidateRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[AtsCreateCandidateResponse](../../Models/Requests/AtsCreateCandidateResponse.md)**

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

Get Candidate

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_candidate" method="get" path="/unified/ats/candidates/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetCandidateRequest req = new AtsGetCandidateRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,first_name,last_name,email,emails,social_links,phone,phone_numbers,company,country,title,application_ids,remote_application_ids,hired_at,custom_fields,created_at,updated_at,unified_custom_fields",
    Include = "custom_fields",
};

var res = await sdk.Ats.Candidates.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [AtsGetCandidateRequest](../../Models/Requests/AtsGetCandidateRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[AtsGetCandidateResponse](../../Models/Requests/AtsGetCandidateResponse.md)**

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