# GroupsCompanies
(*Hris.Groups.Companies*)

## Overview

### Available Operations

* [List](#list) - List Companies Groups

## List

List Companies Groups

### Example Usage

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListCompaniesGroupsRequest req = new HrisListCompaniesGroupsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,name,full_name,display_name,created_at,updated_at",
    Filter = new HrisListCompaniesGroupsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
};

HrisListCompaniesGroupsResponse? res = await sdk.Hris.Groups.Companies.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [HrisListCompaniesGroupsRequest](../../Models/Requests/HrisListCompaniesGroupsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[HrisListCompaniesGroupsResponse](../../Models/Requests/HrisListCompaniesGroupsResponse.md)**

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