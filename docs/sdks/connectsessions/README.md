# ConnectSessions
(*ConnectSessions*)

## Overview

### Available Operations

* [Create](#create) - Create Connect Session
* [Authenticate](#authenticate) - Authenticate Connect Session

## Create

Create Connect Session

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;
using System.Collections.Generic;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

ConnectSessionCreate req = new ConnectSessionCreate() {
    Categories = new List<ConnectSessionCreateCategory>() {
        ConnectSessionCreateCategory.Ats,
        ConnectSessionCreateCategory.Hris,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Crm,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Marketing,
        ConnectSessionCreateCategory.Lms,
        ConnectSessionCreateCategory.Iam,
        ConnectSessionCreateCategory.Documents,
        ConnectSessionCreateCategory.Ticketing,
        ConnectSessionCreateCategory.Screening,
        ConnectSessionCreateCategory.Messaging,
        ConnectSessionCreateCategory.Accounting,
    },
    OriginOwnerId = "<id>",
    OriginOwnerName = "<value>",
};

var res = await sdk.ConnectSessions.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ConnectSessionCreate](../../Models/Components/ConnectSessionCreate.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[StackoneCreateConnectSessionResponse](../../Models/Requests/StackoneCreateConnectSessionResponse.md)**

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

## Authenticate

Authenticate Connect Session

### Example Usage

```csharp
using StackOne.Client;
using StackOne.Client.Models.Components;

var sdk = new StackOneClient(security: new Security() {
    Username = "",
    Password = "",
});

ConnectSessionAuthenticate req = new ConnectSessionAuthenticate() {
    Token = "<value>",
};

var res = await sdk.ConnectSessions.AuthenticateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ConnectSessionAuthenticate](../../Models/Components/ConnectSessionAuthenticate.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[StackoneAuthenticateConnectSessionResponse](../../Models/Requests/StackoneAuthenticateConnectSessionResponse.md)**

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