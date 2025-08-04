# CandidatesCustomFieldDefinitions
(*Ats.Candidates.CustomFieldDefinitions*)

## Overview

### Available Operations

* [Get](#get) - Get Candidate Custom Field Definition

## Get

Get Candidate Custom Field Definition

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ats_get_candidate_custom_field_definition" method="get" path="/unified/ats/custom_field_definitions/candidates/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

AtsGetCandidateCustomFieldDefinitionRequest req = new AtsGetCandidateCustomFieldDefinitionRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,description,type,options",
    Filter = new AtsGetCandidateCustomFieldDefinitionFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
};

var res = await sdk.Ats.Candidates.CustomFieldDefinitions.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [AtsGetCandidateCustomFieldDefinitionRequest](../../Models/Requests/AtsGetCandidateCustomFieldDefinitionRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |

### Response

**[AtsGetCandidateCustomFieldDefinitionResponse](../../Models/Requests/AtsGetCandidateCustomFieldDefinitionResponse.md)**

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