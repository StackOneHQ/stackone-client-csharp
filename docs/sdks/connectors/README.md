# Connectors
(*Connectors*)

## Overview

Retrieve metadata for connectors.

### Available Operations

* [ListMeta](#listmeta) - List Connectors Meta Information for all providers
* [GetMeta](#getmeta) - Get Connector Meta information for the given provider key

## ListMeta

List Connectors Meta Information for all providers

### Example Usage

```csharp
using StackOne;
using StackOne.Models.Components;

var sdk = new StackOneSDK(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Connectors.ListMetaAsync(include: "field_path,unmapped_fields,resources,inactive,webhooks,static_fields");

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            | Example                                                                |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Include`                                                              | *string*                                                               | :heavy_minus_sign:                                                     | The comma separated list of data that will be included in the response | field_path,unmapped_fields,resources,inactive,webhooks,static_fields   |

### Response

**[StackoneListConnectorsMetaResponse](../../Models/Requests/StackoneListConnectorsMetaResponse.md)**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| StackOne.Models.Errors.BadRequestResponseException          | 400                                                         | application/json                                            |
| StackOne.Models.Errors.UnauthorizedResponseException        | 401                                                         | application/json                                            |
| StackOne.Models.Errors.ForbiddenResponseException           | 403                                                         | application/json                                            |
| StackOne.Models.Errors.NotFoundResponseException            | 404                                                         | application/json                                            |
| StackOne.Models.Errors.RequestTimedOutResponseException     | 408                                                         | application/json                                            |
| StackOne.Models.Errors.ConflictResponseException            | 409                                                         | application/json                                            |
| StackOne.Models.Errors.UnprocessableEntityResponseException | 422                                                         | application/json                                            |
| StackOne.Models.Errors.TooManyRequestsResponseException     | 429                                                         | application/json                                            |
| StackOne.Models.Errors.InternalServerErrorResponse          | 500                                                         | application/json                                            |
| StackOne.Models.Errors.NotImplementedResponseException      | 501                                                         | application/json                                            |
| StackOne.Models.Errors.BadGatewayResponseException          | 502                                                         | application/json                                            |
| StackOne.Models.Errors.APIException                         | 4XX, 5XX                                                    | \*/\*                                                       |

## GetMeta

Get Connector Meta information for the given provider key

### Example Usage

```csharp
using StackOne;
using StackOne.Models.Components;

var sdk = new StackOneSDK(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Connectors.GetMetaAsync(
    provider: "<value>",
    include: "field_path,unmapped_fields,resources,inactive,webhooks,static_fields"
);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            | Example                                                                |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `Provider`                                                             | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |                                                                        |
| `Include`                                                              | *string*                                                               | :heavy_minus_sign:                                                     | The comma separated list of data that will be included in the response | field_path,unmapped_fields,resources,inactive,webhooks,static_fields   |

### Response

**[StackoneGetConnectorMetaResponse](../../Models/Requests/StackoneGetConnectorMetaResponse.md)**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| StackOne.Models.Errors.BadRequestResponseException          | 400                                                         | application/json                                            |
| StackOne.Models.Errors.UnauthorizedResponseException        | 401                                                         | application/json                                            |
| StackOne.Models.Errors.ForbiddenResponseException           | 403                                                         | application/json                                            |
| StackOne.Models.Errors.NotFoundResponseException            | 404                                                         | application/json                                            |
| StackOne.Models.Errors.RequestTimedOutResponseException     | 408                                                         | application/json                                            |
| StackOne.Models.Errors.ConflictResponseException            | 409                                                         | application/json                                            |
| StackOne.Models.Errors.UnprocessableEntityResponseException | 422                                                         | application/json                                            |
| StackOne.Models.Errors.TooManyRequestsResponseException     | 429                                                         | application/json                                            |
| StackOne.Models.Errors.InternalServerErrorResponse          | 500                                                         | application/json                                            |
| StackOne.Models.Errors.NotImplementedResponseException      | 501                                                         | application/json                                            |
| StackOne.Models.Errors.BadGatewayResponseException          | 502                                                         | application/json                                            |
| StackOne.Models.Errors.APIException                         | 4XX, 5XX                                                    | \*/\*                                                       |