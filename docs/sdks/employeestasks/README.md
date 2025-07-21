# EmployeesTasks
(*Hris.Employees.Tasks*)

## Overview

### Available Operations

* [List](#list) - List Employee Tasks

## List

List Employee Tasks

### Example Usage

```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeTasksRequest req = new HrisListEmployeeTasksRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,name,description,type,status,due_date,completion_date,assigned_by_employee_id,remote_assigned_by_employee_id,assigned_by_employee_name,link_to_task,extracted_links,next_task_id,remote_next_task_id,parent_process_name,comments,attachments,created_at,updated_at",
    Filter = new HrisListEmployeeTasksFilter() {
        UpdatedAfter = "2020-01-01T00:00:00.000Z",
    },
    Expand = "attachments",
};

HrisListEmployeeTasksResponse? res = await sdk.Hris.Employees.Tasks.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [HrisListEmployeeTasksRequest](../../Models/Requests/HrisListEmployeeTasksRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[HrisListEmployeeTasksResponse](../../Models/Requests/HrisListEmployeeTasksResponse.md)**

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