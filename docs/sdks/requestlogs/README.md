# RequestLogs
(*RequestLogs*)

## Overview

API requests and response logs.

### Available Operations

* [ListSteps](#liststeps) - List Step Logs
* [Get](#get) - Get Log
* [List](#list) - List Logs
* [ListPlatformLogs](#listplatformlogs) - List Platform Logs

## ListSteps

List Step Logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_list_step_logs" method="get" path="/requests/logs/steps" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListStepLogsRequest req = new StackoneListStepLogsRequest() {
    OrderBy = StackoneListStepLogsOrderBy.EventDatetime,
    OrderDirection = StackoneListStepLogsOrderDirection.Asc,
    Filter = new StackoneListStepLogsFilter() {
        AccountIds = "45355976281015164504,45355976281015164505",
        StartDate = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        EndDate = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
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

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |

## Get

Get Log

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_get_log" method="get" path="/requests/logs/{id}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
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

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |

## List

List Logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_list_logs" method="get" path="/requests/logs" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListLogsRequest req = new StackoneListLogsRequest() {
    OrderBy = StackoneListLogsOrderBy.Duration,
    OrderDirection = StackoneListLogsOrderDirection.Asc,
    Include = StackoneListLogsInclude.StepLogs,
    Filter = new StackoneListLogsFilter() {
        AccountIds = "45355976281015164504,45355976281015164505",
        StartDate = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        EndDate = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
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
        OrderBy = StackoneListLogsFilterOrderBy.Duration,
        OrderDirection = StackoneListLogsFilterOrderDirection.Asc,
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

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |

## ListPlatformLogs

List Platform Logs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_list_platform_logs" method="get" path="/requests/platform-logs" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListPlatformLogsRequest req = new StackoneListPlatformLogsRequest() {
    OrderBy = StackoneListPlatformLogsOrderBy.Duration,
    OrderDirection = StackoneListPlatformLogsOrderDirection.Asc,
    Filter = new StackoneListPlatformLogsFilter() {
        AccountIds = "45355976281015164504,45355976281015164505",
        StartDate = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        EndDate = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
        RequestIds = "adbf752f-6457-4ddd-89b3-98ae2252b83b,adbf752f-6457-4ddd-89b3-98ae2252b83c",
        SourceTypes = "DASHBOARD,SYNTHETIC_WEBHOOK",
        HttpMethods = "GET,POST",
        Categories = "hris,ats",
        Resources = "employees,users",
        Actions = "download,upload",
        StatusCodes = "200,400",
        Success = true,
        OrderBy = StackoneListPlatformLogsFilterOrderBy.EventDatetime,
        OrderDirection = StackoneListPlatformLogsFilterOrderDirection.Asc,
    },
};

var res = await sdk.RequestLogs.ListPlatformLogsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [StackoneListPlatformLogsRequest](../../Models/Requests/StackoneListPlatformLogsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[StackoneListPlatformLogsResponse](../../Models/Requests/StackoneListPlatformLogsResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| StackOneHQ.Client.Models.Errors.BadRequestResponseException          | 400                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnauthorizedResponseException        | 401                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ForbiddenResponseException           | 403                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotFoundResponseException            | 404                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.RequestTimedOutResponseException     | 408                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.ConflictResponseException            | 409                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.UnprocessableEntityResponseException | 422                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.TooManyRequestsResponseException     | 429                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.InternalServerErrorResponse          | 500                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.NotImplementedResponseException      | 501                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.BadGatewayResponseException          | 502                                                                  | application/json                                                     |
| StackOneHQ.Client.Models.Errors.APIException                         | 4XX, 5XX                                                             | \*/\*                                                                |