# EmployeeCategories
(*Hris.Documents.EmployeeCategories*)

## Overview

### Available Operations

* [List](#list) - List Employee Document Categories
* [Get](#get) - Get Employee Document Category

## List

List Employee Document Categories

### Example Usage

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeCategoriesRequest req = new HrisListEmployeeCategoriesRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,active",
    Filter = new HrisListEmployeeCategoriesFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListEmployeeCategoriesResponse? res = await sdk.Hris.Documents.EmployeeCategories.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [HrisListEmployeeCategoriesRequest](../../Models/Requests/HrisListEmployeeCategoriesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[HrisListEmployeeCategoriesResponse](../../Models/Requests/HrisListEmployeeCategoriesResponse.md)**

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

Get Employee Document Category

### Example Usage

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisGetEmployeeDocumentCategoryRequest req = new HrisGetEmployeeDocumentCategoryRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,name,active",
};

var res = await sdk.Hris.Documents.EmployeeCategories.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [HrisGetEmployeeDocumentCategoryRequest](../../Models/Requests/HrisGetEmployeeDocumentCategoryRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[HrisGetEmployeeDocumentCategoryResponse](../../Models/Requests/HrisGetEmployeeDocumentCategoryResponse.md)**

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