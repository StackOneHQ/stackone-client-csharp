# Ats
(*Ats*)

## Overview

### Available Operations

* [ListApplications](#listapplications) - List Applications
* [Get](#get) - Get Application
* [GetApplicationChanges](#getapplicationchanges) - List Application Changes
* [ListApplicationNotes](#listapplicationnotes) - List Application Notes
* [CreateApplicationNote](#createapplicationnote) - Create Application Note
* [GetNote](#getnote) - Get Application Note
* [UpdateNote](#updatenote) - Update Application Note
* [DocumentsUpload](#documentsupload) - Upload Application Document
* [GetDocument](#getdocument) - Get Application Document
* [ListCandidates](#listcandidates) - List Candidates
* [UpdateCandidate](#updatecandidate) - Update Candidate
* [CreateNote](#createnote) - Create Candidate Note
* [GetCandidateNote](#getcandidatenote) - Get Candidate Note
* [ListJobCustomFieldDefinitions](#listjobcustomfielddefinitions) - List Job Custom Field Definitions
* [GetDepartments](#getdepartments) - List Departments
* [ListApplicationStages](#listapplicationstages) - List Application Stages
* [GetApplicationStage](#getapplicationstage) - Get Application Stage
* [ListJobs](#listjobs) - List Jobs
* [CreateJob](#createjob) - Create Job
* [ListJobApplicationStages](#listjobapplicationstages) - List Job Application Stages
* [UpdateJob](#updatejob) - Update Job
* [GetJobApplicationStage](#getjobapplicationstage) - Get Job Application Stage
* [GetUser](#getuser) - Get User
* [ListJobPostings](#listjobpostings) - List Job Postings
* [OrderAssessments](#orderassessments) - Order Assessments Request
* [AssessmentsUpdateResult](#assessmentsupdateresult) - Update Assessments Result
* [UpdateBackgroundCheckPackage](#updatebackgroundcheckpackage) - Update Background Check Package
* [OrderBackgroundCheck](#orderbackgroundcheck) - Order Background Check Request
* [UpdateBackgroundCheckResult](#updatebackgroundcheckresult) - Update Background Check Result

## ListApplications

List Applications

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_applications" method="get" path="/unified/ats/applications" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListApplicationsRequest req = new AtsListApplicationsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,candidate_id,remote_candidate_id,job_id,remote_job_id,job_posting_id,remote_job_posting_id,interview_stage,interview_stage_id,remote_interview_stage_id,rejected_reason,rejected_reason_id,remote_rejected_reason_id,rejected_reason_ids,remote_rejected_reason_ids,rejected_reasons,rejected_at,location_id,remote_location_id,location_ids,remote_location_ids,status,application_status,questionnaires,attachments,result_links,source,created_at,updated_at,documents,custom_fields,candidate",
    Filter = new AtsListApplicationsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        CreatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Expand = "documents",
    Include = "attachments,custom_fields",
};

AtsListApplicationsResponse? res = await sdk.Ats.ListApplicationsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [AtsListApplicationsRequest](../../Models/Requests/AtsListApplicationsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[AtsListApplicationsResponse](../../Models/Requests/AtsListApplicationsResponse.md)**

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

Get Application

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_application" method="get" path="/unified/ats/applications/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetApplicationRequest req = new AtsGetApplicationRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,candidate_id,remote_candidate_id,job_id,remote_job_id,job_posting_id,remote_job_posting_id,interview_stage,interview_stage_id,remote_interview_stage_id,rejected_reason,rejected_reason_id,remote_rejected_reason_id,rejected_reason_ids,remote_rejected_reason_ids,rejected_reasons,rejected_at,location_id,remote_location_id,location_ids,remote_location_ids,status,application_status,questionnaires,attachments,result_links,source,created_at,updated_at,documents,custom_fields,candidate",
    Expand = "documents",
    Include = "attachments,custom_fields",
};

var res = await sdk.Ats.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [AtsGetApplicationRequest](../../Models/Requests/AtsGetApplicationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[AtsGetApplicationResponse](../../Models/Requests/AtsGetApplicationResponse.md)**

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

## GetApplicationChanges

List Application Changes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_application_changes" method="get" path="/unified/ats/applications/{id}/changes" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListApplicationChangesRequest req = new AtsListApplicationChangesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "event_id,remote_event_id,created_at,effective_at,change_type,actor,new_values",
    Filter = new AtsListApplicationChangesFilter() {
        CreatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

AtsListApplicationChangesResponse? res = await sdk.Ats.GetApplicationChangesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AtsListApplicationChangesRequest](../../Models/Requests/AtsListApplicationChangesRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AtsListApplicationChangesResponse](../../Models/Requests/AtsListApplicationChangesResponse.md)**

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

## ListApplicationNotes

List Application Notes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_application_notes" method="get" path="/unified/ats/applications/{id}/notes" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListApplicationNotesRequest req = new AtsListApplicationNotesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,content,author_id,remote_author_id,visibility,created_at,updated_at,deleted_at",
    Filter = new AtsListApplicationNotesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

AtsListApplicationNotesResponse? res = await sdk.Ats.ListApplicationNotesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [AtsListApplicationNotesRequest](../../Models/Requests/AtsListApplicationNotesRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[AtsListApplicationNotesResponse](../../Models/Requests/AtsListApplicationNotesResponse.md)**

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

## CreateApplicationNote

Create Application Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_create_application_note" method="post" path="/unified/ats/applications/{id}/notes" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.CreateApplicationNoteAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsCreateNotesRequestDto: new AtsCreateNotesRequestDto() {
        Content = new List<NoteContentApiModel>() {
            new NoteContentApiModel() {
                Body = "This candidate seems like a good fit for the role",
            },
        },
        AuthorId = "1234567890",
        Visibility = new AtsCreateNotesRequestDtoVisibility() {
            Value = AtsCreateNotesRequestDtoValue.Public,
            SourceValue = AtsCreateNotesRequestDtoSourceValueUnion.CreateStr(
                "Public"
            ),
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `XAccountId`                                                                    | *string*                                                                        | :heavy_check_mark:                                                              | The account identifier                                                          |
| `Id`                                                                            | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             |
| `AtsCreateNotesRequestDto`                                                      | [AtsCreateNotesRequestDto](../../Models/Components/AtsCreateNotesRequestDto.md) | :heavy_check_mark:                                                              | N/A                                                                             |

### Response

**[AtsCreateApplicationNoteResponse](../../Models/Requests/AtsCreateApplicationNoteResponse.md)**

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

## GetNote

Get Application Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_application_note" method="get" path="/unified/ats/applications/{id}/notes/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetApplicationNoteRequest req = new AtsGetApplicationNoteRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,content,author_id,remote_author_id,visibility,created_at,updated_at,deleted_at",
};

var res = await sdk.Ats.GetNoteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AtsGetApplicationNoteRequest](../../Models/Requests/AtsGetApplicationNoteRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AtsGetApplicationNoteResponse](../../Models/Requests/AtsGetApplicationNoteResponse.md)**

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

## UpdateNote

Update Application Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_update_application_note" method="patch" path="/unified/ats/applications/{id}/notes/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.UpdateNoteAsync(
    xAccountId: "<id>",
    id: "<id>",
    subResourceId: "<id>",
    atsUpdateNotesRequestDto: new AtsUpdateNotesRequestDto() {
        Content = new List<NoteContentApiModel>() {
            new NoteContentApiModel() {
                Body = "This candidate seems like a good fit for the role",
            },
        },
        AuthorId = "1234567890",
        Visibility = new AtsUpdateNotesRequestDtoVisibility() {
            Value = AtsUpdateNotesRequestDtoValue.Public,
            SourceValue = AtsUpdateNotesRequestDtoSourceValueUnion.CreateStr(
                "Public"
            ),
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `XAccountId`                                                                    | *string*                                                                        | :heavy_check_mark:                                                              | The account identifier                                                          |
| `Id`                                                                            | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             |
| `SubResourceId`                                                                 | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             |
| `AtsUpdateNotesRequestDto`                                                      | [AtsUpdateNotesRequestDto](../../Models/Components/AtsUpdateNotesRequestDto.md) | :heavy_check_mark:                                                              | N/A                                                                             |

### Response

**[AtsUpdateApplicationNoteResponse](../../Models/Requests/AtsUpdateApplicationNoteResponse.md)**

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

## DocumentsUpload

Upload Application Document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_upload_application_document" method="post" path="/unified/ats/applications/{id}/documents/upload" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.DocumentsUploadAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsDocumentsUploadRequestDto: new AtsDocumentsUploadRequestDto() {
        Name = "weather-forecast",
        FileFormat = null,
        Content = "VGhpcyBpc24ndCByZWFsbHkgYSBzYW1wbGUgZmlsZSwgYnV0IG5vIG9uZSB3aWxsIGV2ZXIga25vdyE",
        CategoryId = "6530",
        Path = "/path/to/file",
        Confidential = new AtsDocumentsUploadRequestDtoConfidential() {
            Value = AtsDocumentsUploadRequestDtoConfidentialValue.True,
            SourceValue = AtsDocumentsUploadRequestDtoConfidentialSourceValueUnion.CreateStr(
                "public"
            ),
        },
        Category = new AtsDocumentsUploadRequestDtoCategory() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `Id`                                                                                    | *string*                                                                                | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `AtsDocumentsUploadRequestDto`                                                          | [AtsDocumentsUploadRequestDto](../../Models/Components/AtsDocumentsUploadRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[AtsUploadApplicationDocumentResponse](../../Models/Requests/AtsUploadApplicationDocumentResponse.md)**

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

## GetDocument

Get Application Document

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_application_document" method="get" path="/unified/ats/applications/{id}/documents/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetApplicationDocumentRequest req = new AtsGetApplicationDocumentRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,name,type,category,category_id,remote_category_id,contents,created_at,updated_at,remote_url,file_format",
};

var res = await sdk.Ats.GetDocumentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AtsGetApplicationDocumentRequest](../../Models/Requests/AtsGetApplicationDocumentRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AtsGetApplicationDocumentResponse](../../Models/Requests/AtsGetApplicationDocumentResponse.md)**

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

## ListCandidates

List Candidates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_candidates" method="get" path="/unified/ats/candidates" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListCandidatesRequest req = new AtsListCandidatesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,first_name,last_name,email,emails,social_links,phone,phone_numbers,company,country,title,application_ids,remote_application_ids,hired_at,custom_fields,created_at,updated_at",
    Filter = new AtsListCandidatesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        CreatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Include = "custom_fields",
};

AtsListCandidatesResponse? res = await sdk.Ats.ListCandidatesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [AtsListCandidatesRequest](../../Models/Requests/AtsListCandidatesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[AtsListCandidatesResponse](../../Models/Requests/AtsListCandidatesResponse.md)**

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

## UpdateCandidate

Update Candidate

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_update_candidate" method="patch" path="/unified/ats/candidates/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.UpdateCandidateAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsUpdateCandidateRequestDto: new AtsUpdateCandidateRequestDto() {
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Name = "Romain Sestier",
        FirstName = "Romain",
        LastName = "Sestier",
        Email = "sestier.romain123@gmail.com",
        Emails = new List<CandidateEmail>() {
            new CandidateEmail() {
                Type = "personal",
                Value = "sestier.romain123@gmail.com",
            },
        },
        SocialLinks = new List<SocialLink>() {
            new SocialLink() {
                Type = "linkedin",
                Url = "https://www.linkedin.com/in/romainsestier/",
            },
        },
        PhoneNumbers = new List<PhoneNumber>() {
            new PhoneNumber() {
                Phone = "+447700112233",
            },
        },
        Company = "Company Inc.",
        Title = "Software Engineer",
        ApplicationIds = new List<string>() {
            "123e4567-e89b-12d3-a456-426614174000",
            "523e1234-e89b-fdd2-a456-762545121101",
        },
        HiredAt = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Country = "United States",
        CustomFields = null,
    }
);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `XAccountId`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The account identifier                                                                  |
| `Id`                                                                                    | *string*                                                                                | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `AtsUpdateCandidateRequestDto`                                                          | [AtsUpdateCandidateRequestDto](../../Models/Components/AtsUpdateCandidateRequestDto.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |

### Response

**[AtsUpdateCandidateResponse](../../Models/Requests/AtsUpdateCandidateResponse.md)**

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

## CreateNote

Create Candidate Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_create_candidate_note" method="post" path="/unified/ats/candidates/{id}/notes" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.CreateNoteAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsCreateNotesRequestDto: new AtsCreateNotesRequestDto() {
        Content = new List<NoteContentApiModel>() {
            new NoteContentApiModel() {
                Body = "This candidate seems like a good fit for the role",
            },
        },
        AuthorId = "1234567890",
        Visibility = new AtsCreateNotesRequestDtoVisibility() {
            Value = AtsCreateNotesRequestDtoValue.Public,
            SourceValue = AtsCreateNotesRequestDtoSourceValueUnion.CreateStr(
                "Public"
            ),
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `XAccountId`                                                                    | *string*                                                                        | :heavy_check_mark:                                                              | The account identifier                                                          |
| `Id`                                                                            | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             |
| `AtsCreateNotesRequestDto`                                                      | [AtsCreateNotesRequestDto](../../Models/Components/AtsCreateNotesRequestDto.md) | :heavy_check_mark:                                                              | N/A                                                                             |

### Response

**[AtsCreateCandidateNoteResponse](../../Models/Requests/AtsCreateCandidateNoteResponse.md)**

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

## GetCandidateNote

Get Candidate Note

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_candidate_note" method="get" path="/unified/ats/candidates/{id}/notes/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetCandidateNoteRequest req = new AtsGetCandidateNoteRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,content,author_id,remote_author_id,visibility,created_at,updated_at,deleted_at",
};

var res = await sdk.Ats.GetCandidateNoteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [AtsGetCandidateNoteRequest](../../Models/Requests/AtsGetCandidateNoteRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[AtsGetCandidateNoteResponse](../../Models/Requests/AtsGetCandidateNoteResponse.md)**

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

## ListJobCustomFieldDefinitions

List Job Custom Field Definitions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_job_custom_field_definitions" method="get" path="/unified/ats/custom_field_definitions/jobs" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListJobCustomFieldDefinitionsRequest req = new AtsListJobCustomFieldDefinitionsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,description,type,options",
    Filter = new AtsListJobCustomFieldDefinitionsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

AtsListJobCustomFieldDefinitionsResponse? res = await sdk.Ats.ListJobCustomFieldDefinitionsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [AtsListJobCustomFieldDefinitionsRequest](../../Models/Requests/AtsListJobCustomFieldDefinitionsRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[AtsListJobCustomFieldDefinitionsResponse](../../Models/Requests/AtsListJobCustomFieldDefinitionsResponse.md)**

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

## GetDepartments

List Departments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_departments" method="get" path="/unified/ats/departments" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListDepartmentsRequest req = new AtsListDepartmentsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name",
    Filter = new AtsListDepartmentsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

AtsListDepartmentsResponse? res = await sdk.Ats.GetDepartmentsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AtsListDepartmentsRequest](../../Models/Requests/AtsListDepartmentsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[AtsListDepartmentsResponse](../../Models/Requests/AtsListDepartmentsResponse.md)**

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

## ListApplicationStages

List Application Stages

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_application_stages" method="get" path="/unified/ats/application_stages" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListApplicationStagesRequest req = new AtsListApplicationStagesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,order,created_at,updated_at",
    Filter = new AtsListApplicationStagesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

AtsListApplicationStagesResponse? res = await sdk.Ats.ListApplicationStagesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [AtsListApplicationStagesRequest](../../Models/Requests/AtsListApplicationStagesRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[AtsListApplicationStagesResponse](../../Models/Requests/AtsListApplicationStagesResponse.md)**

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

## GetApplicationStage

Get Application Stage

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_application_stage" method="get" path="/unified/ats/application_stages/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetApplicationStageRequest req = new AtsGetApplicationStageRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,order,created_at,updated_at",
};

var res = await sdk.Ats.GetApplicationStageAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [AtsGetApplicationStageRequest](../../Models/Requests/AtsGetApplicationStageRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[AtsGetApplicationStageResponse](../../Models/Requests/AtsGetApplicationStageResponse.md)**

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

## ListJobs

List Jobs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_jobs" method="get" path="/unified/ats/jobs" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListJobsRequest req = new AtsListJobsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,code,title,description,status,job_status,department_ids,remote_department_ids,location_ids,remote_location_ids,hiring_team,interview_stages,confidential,custom_fields,created_at,updated_at",
    Filter = new AtsListJobsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        CreatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Expand = "job_postings,interview_stages",
    Include = "custom_fields",
};

AtsListJobsResponse? res = await sdk.Ats.ListJobsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [AtsListJobsRequest](../../Models/Requests/AtsListJobsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[AtsListJobsResponse](../../Models/Requests/AtsListJobsResponse.md)**

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

## CreateJob

Create Job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_create_job" method="post" path="/unified/ats/jobs" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.CreateJobAsync(
    xAccountId: "<id>",
    atsCreateJobRequestDto: new AtsCreateJobRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Code = "184919",
        Title = "Software Engineer",
        Description = "Responsible for identifying business requirements",
        JobStatus = new AtsCreateJobRequestDtoJobStatus() {
            Value = AtsCreateJobRequestDtoValue.Published,
            SourceValue = AtsCreateJobRequestDtoSourceValueUnion.CreateStr(
                "Published"
            ),
        },
        DepartmentIds = new List<string>() {
            "308570",
            "308571",
            "308572",
        },
        LocationIds = new List<string>() {
            "668570",
            "678571",
            "688572",
        },
        HiringTeam = new List<AtsJobHiringTeam>() {
            new AtsJobHiringTeam() {
                UserId = "123456",
                RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                Role = "Software Engineer",
            },
        },
        InterviewStages = new List<InterviewStage>() {
            new InterviewStage() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                UnifiedCustomFields = new Dictionary<string, object>() {
                    { "my_project_custom_field_1", "REF-1236" },
                    { "my_project_custom_field_2", "some other value" },
                },
                CreatedAt = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
                UpdatedAt = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
            },
        },
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
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `XAccountId`                                                                | *string*                                                                    | :heavy_check_mark:                                                          | The account identifier                                                      |
| `AtsCreateJobRequestDto`                                                    | [AtsCreateJobRequestDto](../../Models/Components/AtsCreateJobRequestDto.md) | :heavy_check_mark:                                                          | N/A                                                                         |

### Response

**[AtsCreateJobResponse](../../Models/Requests/AtsCreateJobResponse.md)**

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

## ListJobApplicationStages

List Job Application Stages

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_job_application_stages" method="get" path="/unified/ats/jobs/{id}/application_stages" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListJobApplicationStagesRequest req = new AtsListJobApplicationStagesRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,order,created_at,updated_at",
    Filter = new AtsListJobApplicationStagesFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

AtsListJobApplicationStagesResponse? res = await sdk.Ats.ListJobApplicationStagesAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [AtsListJobApplicationStagesRequest](../../Models/Requests/AtsListJobApplicationStagesRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[AtsListJobApplicationStagesResponse](../../Models/Requests/AtsListJobApplicationStagesResponse.md)**

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

## UpdateJob

Update Job

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_update_job" method="patch" path="/unified/ats/jobs/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.UpdateJobAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsUpdateJobRequestDto: new AtsUpdateJobRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        Code = "184919",
        Title = "Software Engineer",
        Description = "Responsible for identifying business requirements",
        JobStatus = new AtsUpdateJobRequestDtoJobStatus() {
            Value = AtsUpdateJobRequestDtoValue.Published,
            SourceValue = AtsUpdateJobRequestDtoSourceValueUnion.CreateStr(
                "Published"
            ),
        },
        DepartmentIds = new List<string>() {
            "308570",
            "308571",
            "308572",
        },
        LocationIds = new List<string>() {
            "668570",
            "678571",
            "688572",
        },
        HiringTeam = new List<AtsJobHiringTeam>() {
            new AtsJobHiringTeam() {
                UserId = "123456",
                RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                Role = "Software Engineer",
            },
        },
        InterviewStages = null,
        CustomFields = null,
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `XAccountId`                                                                | *string*                                                                    | :heavy_check_mark:                                                          | The account identifier                                                      |
| `Id`                                                                        | *string*                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `AtsUpdateJobRequestDto`                                                    | [AtsUpdateJobRequestDto](../../Models/Components/AtsUpdateJobRequestDto.md) | :heavy_check_mark:                                                          | N/A                                                                         |

### Response

**[AtsUpdateJobResponse](../../Models/Requests/AtsUpdateJobResponse.md)**

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

## GetJobApplicationStage

Get Job Application Stage

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_job_application_stage" method="get" path="/unified/ats/jobs/{id}/application_stages/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetJobApplicationStageRequest req = new AtsGetJobApplicationStageRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    SubResourceId = "<id>",
    Fields = "id,remote_id,name,order,created_at,updated_at",
};

var res = await sdk.Ats.GetJobApplicationStageAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [AtsGetJobApplicationStageRequest](../../Models/Requests/AtsGetJobApplicationStageRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[AtsGetJobApplicationStageResponse](../../Models/Requests/AtsGetJobApplicationStageResponse.md)**

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

<!-- UsageSnippet language="csharp" operationID="ats_get_user" method="get" path="/unified/ats/users/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetUserRequest req = new AtsGetUserRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,first_name,last_name,name,email,phone",
};

var res = await sdk.Ats.GetUserAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [AtsGetUserRequest](../../Models/Requests/AtsGetUserRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[AtsGetUserResponse](../../Models/Requests/AtsGetUserResponse.md)**

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

## ListJobPostings

List Job Postings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_list_job_postings" method="get" path="/unified/ats/job_postings" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsListJobPostingsRequest req = new AtsListJobPostingsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,title,locations,internal,status,job_id,remote_job_id,content,compensation,employment_type,employment_contract_type,external_url,external_apply_url,questionnaires,start_date,updated_at,created_at",
    Filter = new AtsListJobPostingsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        CreatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Include = "questionnaires",
};

AtsListJobPostingsResponse? res = await sdk.Ats.ListJobPostingsAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AtsListJobPostingsRequest](../../Models/Requests/AtsListJobPostingsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[AtsListJobPostingsResponse](../../Models/Requests/AtsListJobPostingsResponse.md)**

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

## OrderAssessments

Order Assessments Request

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_order_assessments_request" method="post" path="/unified/ats/assessments/orders" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.OrderAssessmentsAsync(
    xAccountId: "<id>",
    atsCreateCandidatesAssessmentsRequestDto: new AtsCreateCandidatesAssessmentsRequestDto() {
        Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
        Package = new AtsCreateCandidatesAssessmentsRequestDtoPackage() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "Test 1",
            Description = "Skills test to gauge a candidate's proficiency in job-specific skills",
        },
        Application = new AtsCreateCandidatesAssessmentsRequestDtoApplication() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            ApplicationStatus = new AtsCreateCandidatesAssessmentsRequestDtoApplicationStatus() {
                Value = AtsCreateCandidatesAssessmentsRequestDtoValue.Hired,
                SourceValue = AtsCreateCandidatesAssessmentsRequestDtoSourceValueUnion.CreateStr(
                    "Hired"
                ),
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
        },
        Job = new AtsCreateCandidatesAssessmentsRequestDtoJob() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Title = "Software Engineer",
            HiringTeam = new List<AtsJobHiringTeam>() {
                new AtsJobHiringTeam() {
                    UserId = "123456",
                    RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@gmail.com",
                    Role = "Software Engineer",
                },
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
        },
        Candidate = new AtsCreateCandidatesAssessmentsRequestDtoCandidate() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            FirstName = "Romain",
            LastName = "Sestier",
            Emails = new List<CandidateEmail>() {
                new CandidateEmail() {
                    Type = "personal",
                    Value = "sestier.romain123@gmail.com",
                },
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
            ProfileUrl = "https://exmaple.com/candidate?id=xyz",
        },
        Requester = new AtsCreateCandidatesAssessmentsRequestDtoRequester() {
            UserId = "123456",
            RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@gmail.com",
            Role = "Software Engineer",
        },
        ResultsUpdateUrl = "https://exmaple.com/integrations/results/update",
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                    | *string*                                                                                                        | :heavy_check_mark:                                                                                              | The account identifier                                                                                          |
| `AtsCreateCandidatesAssessmentsRequestDto`                                                                      | [AtsCreateCandidatesAssessmentsRequestDto](../../Models/Components/AtsCreateCandidatesAssessmentsRequestDto.md) | :heavy_check_mark:                                                                                              | N/A                                                                                                             |

### Response

**[AtsOrderAssessmentsRequestResponse](../../Models/Requests/AtsOrderAssessmentsRequestResponse.md)**

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

## AssessmentsUpdateResult

Update Assessments Result

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_update_assessments_result" method="patch" path="/unified/ats/assessments/orders/{id}/result" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.AssessmentsUpdateResultAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsUpdateCandidatesAssessmentsResultsRequestDto: new AtsUpdateCandidatesAssessmentsResultsRequestDto() {
        Score = null,
        StartDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        SubmissionDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Summary = "Test is passed",
        Result = new AtsUpdateCandidatesAssessmentsResultsRequestDtoResult() {
            Value = AtsUpdateCandidatesAssessmentsResultsRequestDtoValue.Passed,
            SourceValue = AtsUpdateCandidatesAssessmentsResultsRequestDtoSourceValueUnion.CreateStr(
                "Passed"
            ),
        },
        ResultUrl = "https://exmaple.com/result?id=xyz",
        Attachments = new List<Attachment>() {
            new Attachment() {
                Url = "http://example.com/resume.pdf",
                ContentType = new AttachmentContentType() {
                    Value = AttachmentValue.Text,
                    SourceValue = AttachmentSourceValueUnion.CreateStr(
                        "Text"
                    ),
                },
            },
        },
        Candidate = new AtsUpdateCandidatesAssessmentsResultsRequestDtoCandidate() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            ProfileUrl = "https://exmaple.com/candidate?id=xyz",
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                                  | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | The account identifier                                                                                                        |
| `Id`                                                                                                                          | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | N/A                                                                                                                           |
| `AtsUpdateCandidatesAssessmentsResultsRequestDto`                                                                             | [AtsUpdateCandidatesAssessmentsResultsRequestDto](../../Models/Components/AtsUpdateCandidatesAssessmentsResultsRequestDto.md) | :heavy_check_mark:                                                                                                            | N/A                                                                                                                           |

### Response

**[AtsUpdateAssessmentsResultResponse](../../Models/Requests/AtsUpdateAssessmentsResultResponse.md)**

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

## UpdateBackgroundCheckPackage

Update Background Check Package

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_update_background_check_package" method="patch" path="/unified/ats/background_checks/packages/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.UpdateBackgroundCheckPackageAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsUpdateBackgroundCheckPackagesRequestDto: new AtsUpdateBackgroundCheckPackagesRequestDto() {
        Name = "Test 1",
        Description = "Skills test to gauge a candidate's proficiency in job-specific skills",
        Tests = new List<UpdatePackage>() {
            new UpdatePackage() {
                Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                Name = "Test 1",
                Description = "Skills test to gauge a candidate's proficiency in job-specific skills",
            },
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                        | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | The account identifier                                                                                              |
| `Id`                                                                                                                | *string*                                                                                                            | :heavy_check_mark:                                                                                                  | N/A                                                                                                                 |
| `AtsUpdateBackgroundCheckPackagesRequestDto`                                                                        | [AtsUpdateBackgroundCheckPackagesRequestDto](../../Models/Components/AtsUpdateBackgroundCheckPackagesRequestDto.md) | :heavy_check_mark:                                                                                                  | N/A                                                                                                                 |

### Response

**[AtsUpdateBackgroundCheckPackageResponse](../../Models/Requests/AtsUpdateBackgroundCheckPackageResponse.md)**

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

## OrderBackgroundCheck

Order Background Check Request

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_order_background_check_request" method="post" path="/unified/ats/background_checks/orders" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.OrderBackgroundCheckAsync(
    xAccountId: "<id>",
    atsCreateBackgroundCheckOrderRequestDto: new AtsCreateBackgroundCheckOrderRequestDto() {
        Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
        RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
        Application = new AtsCreateBackgroundCheckOrderRequestDtoApplication() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            ApplicationStatus = new AtsCreateBackgroundCheckOrderRequestDtoApplicationStatus() {
                Value = AtsCreateBackgroundCheckOrderRequestDtoValue.Hired,
                SourceValue = AtsCreateBackgroundCheckOrderRequestDtoSourceValueUnion.CreateStr(
                    "Hired"
                ),
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
        },
        Job = null,
        Candidate = new AtsCreateBackgroundCheckOrderRequestDtoCandidate() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            FirstName = "Romain",
            LastName = "Sestier",
            Emails = new List<CandidateEmail>() {
                new CandidateEmail() {
                    Type = "personal",
                    Value = "sestier.romain123@gmail.com",
                },
            },
            Passthrough = new Dictionary<string, object>() {
                { "other_known_names", "John Doe" },
            },
            ProfileUrl = "https://exmaple.com/candidate?id=xyz",
        },
        Requester = new AtsCreateBackgroundCheckOrderRequestDtoRequester() {
            UserId = "123456",
            RemoteUserId = "e3cb75bf-aa84-466e-a6c1-b8322b257a48",
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@gmail.com",
            Role = "Software Engineer",
        },
        ResultsUpdateUrl = "https://exmaple.com/integrations/results/update",
        Package = new AtsCreateBackgroundCheckOrderRequestDtoPackage() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "Test 1",
            Description = "Skills test to gauge a candidate's proficiency in job-specific skills",
            Tests = new List<Package>() {
                new Package() {
                    Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                    RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
                    Name = "Test 1",
                    Description = "Skills test to gauge a candidate's proficiency in job-specific skills",
                },
            },
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                  | *string*                                                                                                      | :heavy_check_mark:                                                                                            | The account identifier                                                                                        |
| `AtsCreateBackgroundCheckOrderRequestDto`                                                                     | [AtsCreateBackgroundCheckOrderRequestDto](../../Models/Components/AtsCreateBackgroundCheckOrderRequestDto.md) | :heavy_check_mark:                                                                                            | N/A                                                                                                           |

### Response

**[AtsOrderBackgroundCheckRequestResponse](../../Models/Requests/AtsOrderBackgroundCheckRequestResponse.md)**

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

## UpdateBackgroundCheckResult

Update Background Check Result

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_update_background_check_result" method="patch" path="/unified/ats/background_checks/orders/{id}/result" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Ats.UpdateBackgroundCheckResultAsync(
    xAccountId: "<id>",
    id: "<id>",
    atsUpdateBackgroundCheckResultRequestDto: new AtsUpdateBackgroundCheckResultRequestDto() {
        Score = new AtsUpdateBackgroundCheckResultRequestDtoScore() {
            Label = "Percentage",
            Value = "80",
            Min = "0",
            Max = "100",
        },
        StartDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        SubmissionDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Summary = "Test is passed",
        Result = new AtsUpdateBackgroundCheckResultRequestDtoResult() {
            Value = AtsUpdateBackgroundCheckResultRequestDtoValue.Passed,
            SourceValue = AtsUpdateBackgroundCheckResultRequestDtoSourceValueUnion.CreateStr(
                "Passed"
            ),
        },
        ResultUrl = "https://exmaple.com/result?id=xyz",
        Attachments = new List<Attachment>() {
            new Attachment() {
                Url = "http://example.com/resume.pdf",
                ContentType = new AttachmentContentType() {
                    Value = AttachmentValue.Text,
                    SourceValue = AttachmentSourceValueUnion.CreateStr(
                        "Text"
                    ),
                },
            },
        },
        Candidate = new AtsUpdateBackgroundCheckResultRequestDtoCandidate() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            ProfileUrl = "https://exmaple.com/candidate?id=xyz",
        },
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                                    | *string*                                                                                                        | :heavy_check_mark:                                                                                              | The account identifier                                                                                          |
| `Id`                                                                                                            | *string*                                                                                                        | :heavy_check_mark:                                                                                              | N/A                                                                                                             |
| `AtsUpdateBackgroundCheckResultRequestDto`                                                                      | [AtsUpdateBackgroundCheckResultRequestDto](../../Models/Components/AtsUpdateBackgroundCheckResultRequestDto.md) | :heavy_check_mark:                                                                                              | N/A                                                                                                             |

### Response

**[AtsUpdateBackgroundCheckResultResponse](../../Models/Requests/AtsUpdateBackgroundCheckResultResponse.md)**

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