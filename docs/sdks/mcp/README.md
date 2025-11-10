# Mcp
(*Mcp*)

## Overview

Model Context Protocol endpoint.

### Available Operations

* [McpGet](#mcpget) - Open MCP SSE stream
* [McpPost](#mcppost) - Send MCP JSON-RPC message
* [McpDelete](#mcpdelete) - Delete MCP session

## McpGet

Open a dedicated Server-Sent Events stream for MCP notifications

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_mcp_get" method="get" path="/mcp" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient();

var res = await sdk.Mcp.McpGetAsync(
    security: new StackoneMcpGetSecurity() {
        Basic = new SchemeBasic() {
            Username = "",
            Password = "",
        },
    },
    mcpSessionId: "<id>",
    xAccountId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `security`                                                                                               | [StackoneMcpGetSecurity](../../Models/Requests/StackoneMcpGetSecurity.md)                                | :heavy_check_mark:                                                                                       | The security requirements to use for the request.                                                        |
| `McpSessionId`                                                                                           | *string*                                                                                                 | :heavy_check_mark:                                                                                       | Session id                                                                                               |
| `XAccountId`                                                                                             | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Account secure id for the target provider account (optional if x-account-id query parameter is provided) |
| `XAccountIdQueryParameter`                                                                               | *object*                                                                                                 | :heavy_minus_sign:                                                                                       | Account secure id (alternative to x-account-id header)                                                   |

### Response

**[StackoneMcpGetResponse](../../Models/Requests/StackoneMcpGetResponse.md)**

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

## McpPost

Send JSON-RPC request to the MCP server over HTTP streaming transport

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_mcp_post" method="post" path="/mcp" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient();

var res = await sdk.Mcp.McpPostAsync(
    security: new StackoneMcpPostSecurity() {
        Basic = new SchemeBasic() {
            Username = "",
            Password = "",
        },
    },
    jsonRpcMessageDto: new JsonRpcMessageDto() {
        Jsonrpc = "2.0",
        Method = "initialize",
        Params = new Params() {},
        Id = new Id() {},
    },
    xAccountId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `security`                                                                                               | [StackoneMcpPostSecurity](../../Models/Requests/StackoneMcpPostSecurity.md)                              | :heavy_check_mark:                                                                                       | The security requirements to use for the request.                                                        |
| `JsonRpcMessageDto`                                                                                      | [JsonRpcMessageDto](../../Models/Components/JsonRpcMessageDto.md)                                        | :heavy_check_mark:                                                                                       | JSON-RPC 2.0 message                                                                                     |
| `XAccountId`                                                                                             | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Account secure id for the target provider account (optional if x-account-id query parameter is provided) |
| `XAccountIdQueryParameter`                                                                               | *object*                                                                                                 | :heavy_minus_sign:                                                                                       | Account secure id (alternative to x-account-id header)                                                   |
| `McpSessionId`                                                                                           | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Session id; omit for initialize, include for subsequent calls                                            |

### Response

**[StackoneMcpPostResponse](../../Models/Requests/StackoneMcpPostResponse.md)**

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

## McpDelete

Close an existing MCP session for the provided session id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stackone_mcp_delete" method="delete" path="/mcp" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient();

var res = await sdk.Mcp.McpDeleteAsync(
    security: new StackoneMcpDeleteSecurity() {
        Basic = new SchemeBasic() {
            Username = "",
            Password = "",
        },
    },
    mcpSessionId: "<id>",
    xAccountId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `security`                                                                                               | [StackoneMcpDeleteSecurity](../../Models/Requests/StackoneMcpDeleteSecurity.md)                          | :heavy_check_mark:                                                                                       | The security requirements to use for the request.                                                        |
| `McpSessionId`                                                                                           | *string*                                                                                                 | :heavy_check_mark:                                                                                       | Session id                                                                                               |
| `XAccountId`                                                                                             | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Account secure id for the target provider account (optional if x-account-id query parameter is provided) |
| `XAccountIdQueryParameter`                                                                               | *object*                                                                                                 | :heavy_minus_sign:                                                                                       | Account secure id (alternative to x-account-id header)                                                   |

### Response

**[StackoneMcpDeleteResponse](../../Models/Requests/StackoneMcpDeleteResponse.md)**

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