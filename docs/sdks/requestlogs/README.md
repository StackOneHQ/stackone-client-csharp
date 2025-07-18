# RequestLogs
(*RequestLogs*)

## Overview

### Available Operations

* [ListSteps](#liststeps) - List Step Logs
* [Get](#get) - Get a Log
* [List](#list) - List Logs

## ListSteps

List Step Logs

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListStepLogsRequest req = new StackoneListStepLogsRequest() {
    OrderBy = StackoneListStepLogsOrderBy.EventDatetime,
    OrderDirection = StackoneListStepLogsOrderDirection.Asc,
    Filter = new StackoneListStepLogsFilter() {
        AccountIds = "45355976281015164504,45355976281015164505",
        StartDate = "2020-01-01T00:00:00.000Z",
        EndDate = "2020-01-01T00:00:00.000Z",
        RequestIds = "adbf752f-6457-4ddd-89b3-98ae2252b83b,adbf752f-6457-4ddd-89b3-98ae2252b83c",
        HttpMethods = "GET,POST",
        Providers = "ashby,greenhouse",
        Services = "hris,ats",
        Resources = "employees,users",
        ChildResources = "documents,time-off",
        SubResources = "documents,employees",
        Actions = "download,upload",
        StatusCodes = "200,400",
        Success = true,
    },
};

var res = await sdk.RequestLogs.ListStepsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [StackoneListStepLogsRequest](../../Models/Requests/StackoneListStepLogsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[StackoneListStepLogsResponse](../../Models/Requests/StackoneListStepLogsResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## Get

Get a Log

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.RequestLogs.GetAsync(
    id: "<id>",
    include: StackoneGetLogInclude.StepLogs
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |                                                                              |
| `Include`                                                                    | [StackoneGetLogInclude](../../Models/Requests/StackoneGetLogInclude.md)      | :heavy_minus_sign:                                                           | The include parameter allows you to include additional data in the response. | step_logs                                                                    |

### Response

**[StackoneGetLogResponse](../../Models/Requests/StackoneGetLogResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |

## List

List Logs

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using StackOne.Client.Models.Requests;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListLogsRequest req = new StackoneListLogsRequest() {
    OrderBy = StackoneListLogsOrderBy.Duration,
    OrderDirection = StackoneListLogsOrderDirection.Asc,
    Include = StackoneListLogsInclude.StepLogs,
    Filter = new StackoneListLogsFilter() {
        AccountIds = "45355976281015164504,45355976281015164505",
        StartDate = "2020-01-01T00:00:00.000Z",
        EndDate = "2020-01-01T00:00:00.000Z",
        RequestIds = "adbf752f-6457-4ddd-89b3-98ae2252b83b,adbf752f-6457-4ddd-89b3-98ae2252b83c",
        SourceTypes = "DASHBOARD,SYNTHETIC_WEBHOOK",
        HttpMethods = "GET,POST",
        Providers = "ashby,greenhouse",
        Services = "hris,ats",
        Resources = "employees,users",
        ChildResources = "documents,time-off",
        SubResources = "documents,employees",
        Actions = "download,upload",
        StatusCodes = "200,400",
        Success = true,
        OrderBy = FilterOrderBy.Duration,
        OrderDirection = FilterOrderDirection.Asc,
    },
};

var res = await sdk.RequestLogs.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [StackoneListLogsRequest](../../Models/Requests/StackoneListLogsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[StackoneListLogsResponse](../../Models/Requests/StackoneListLogsResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| StackOne.Client.Models.Errors.BadRequestResponseException          | 400                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ForbiddenResponseException           | 403                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotFoundResponseException            | 404                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.ConflictResponseException            | 409                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.NotImplementedResponseException      | 501                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.BadGatewayResponseException          | 502                                                                | application/json                                                   |
| StackOne.Client.Models.Errors.APIException                         | 4XX, 5XX                                                           | \*/\*                                                              |