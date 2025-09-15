# Actions
(*Actions*)

## Overview

Retrieve Actions metadata and definitions.

### Available Operations

* [ListActionsMeta](#listactionsmeta) - List all actions metadata
* [RpcAction](#rpcaction) - Make an RPC call to an action

## ListActionsMeta

Retrieves a list of all actions metadata

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_list_actions_meta" method="get" path="/actions" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

StackoneListActionsMetaRequest req = new StackoneListActionsMetaRequest() {
    GroupBy = "[\"connector\"]",
    Filter = new StackoneListActionsMetaFilter() {
        Connectors = "connector1,connector2",
        AccountIds = "account1,account2",
        ActionKey = "action1",
    },
    Include = new List<StackoneListActionsMetaInclude>() {
        StackoneListActionsMetaInclude.OperationDetails,
    },
};

StackoneListActionsMetaResponse? res = await sdk.Actions.ListActionsMetaAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [StackoneListActionsMetaRequest](../../Models/Requests/StackoneListActionsMetaRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[StackoneListActionsMetaResponse](../../Models/Requests/StackoneListActionsMetaResponse.md)**

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

## RpcAction

Makes a remote procedure call to the specified action

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_rpc_action" method="post" path="/actions/rpc" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

ActionsRpcRequestDto req = new ActionsRpcRequestDto() {
    Action = "create_employee",
    Input = new Input() {
        Query = new Dictionary<string, object>() {
            { "param1", "value1" },
            { "param2", "value2" },
        },
        Headers = new Dictionary<string, object>() {
            { "Content-Type", "application/json" },
        },
        Body = new Dictionary<string, object>() {
            { "data", "example" },
        },
    },
};

var res = await sdk.Actions.RpcActionAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ActionsRpcRequestDto](../../Models/Components/ActionsRpcRequestDto.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[StackoneRpcActionResponse](../../Models/Requests/StackoneRpcActionResponse.md)**

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