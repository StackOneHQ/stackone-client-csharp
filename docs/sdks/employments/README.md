# Employments
(*Hris.Employments*)

## Overview

### Available Operations

* [List](#list) - List Employments

## List

List Employments

### Example Usage

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmploymentsRequest req = new HrisListEmploymentsRequest() {
    XAccountId = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,job_title,pay_rate,pay_period,pay_frequency,pay_currency,effective_date,end_date,employment_type,employment_contract_type,change_reason,grade,work_time,payroll_code,fte,created_at,updated_at,start_date,active,department,team,cost_center,cost_centers,division,job,type,contract_type,manager",
    Filter = new HrisListEmploymentsFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "groups",
};

HrisListEmploymentsResponse? res = await sdk.Hris.Employments.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [HrisListEmploymentsRequest](../../Models/Requests/HrisListEmploymentsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[HrisListEmploymentsResponse](../../Models/Requests/HrisListEmploymentsResponse.md)**

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