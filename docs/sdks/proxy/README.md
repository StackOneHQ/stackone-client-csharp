# Proxy
(*Proxy*)

## Overview

Routing API requests through StackOne directly to the underlying provider.

### Available Operations

* [Perform](#perform) - Proxy Request

## Perform

Proxy Request

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOne(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Proxy.PerformAsync(
    xAccountId: "<id>",
    proxyRequestBody: new ProxyRequestBody() {
        Url = "https://api.sample-integration.com/v1",
        Path = "/employees/directory",
        Headers = new Dictionary<string, object>() {
            { "Content-Type", "application/json" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `XAccountId`                                                    | *string*                                                        | :heavy_check_mark:                                              | The account identifier                                          |
| `ProxyRequestBody`                                              | [ProxyRequestBody](../../Models/Components/ProxyRequestBody.md) | :heavy_check_mark:                                              | The request body                                                |

### Response

**[StackoneProxyRequestResponse](../../Models/Requests/StackoneProxyRequestResponse.md)**

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