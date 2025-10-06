# EmployeesEmployments
(*Hris.Employees.Employments*)

## Overview

### Available Operations

* [List](#list) - List Employee Employments
* [Update](#update) - Update Employee Employment

## List

List Employee Employments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="hris_list_employee_employments" method="get" path="/unified/hris/employees/{id}/employments" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using StackOneHQ.Client.Models.Requests;
using System;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

HrisListEmployeeEmploymentsRequest req = new HrisListEmployeeEmploymentsRequest() {
    XAccountId = "<id>",
    Id = "<id>",
    Fields = "id,remote_id,employee_id,remote_employee_id,job_title,pay_rate,pay_period,pay_frequency,pay_currency,effective_date,end_date,employment_type,employment_contract_type,type,contract_type,change_reason,grade,work_time,payroll_code,fte,created_at,updated_at,start_date,active,department,team,cost_center,cost_centers,division,job,manager,groups,unified_custom_fields",
    Filter = new HrisListEmployeeEmploymentsFilter() {
        UpdatedAfter = System.DateTime.Parse("2020-01-01T00:00:00.000Z"),
    },
    Expand = "groups",
};

HrisListEmployeeEmploymentsResponse? res = await sdk.Hris.Employees.Employments.ListAsync(req);

while(res != null)
{
    // handle items

    res = await res.Next!();
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [HrisListEmployeeEmploymentsRequest](../../Models/Requests/HrisListEmployeeEmploymentsRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[HrisListEmployeeEmploymentsResponse](../../Models/Requests/HrisListEmployeeEmploymentsResponse.md)**

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

## Update

Update Employee Employment

### Example Usage

<!-- UsageSnippet language="csharp" operationID="hris_update_employee_employment" method="patch" path="/unified/hris/employees/{id}/employments/{subResourceId}" -->
```csharp
using StackOneHQ.Client;
using StackOneHQ.Client.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new StackOneHQClient(security: new Security() {
    Username = "",
    Password = "",
});

var res = await sdk.Hris.Employees.Employments.UpdateAsync(
    xAccountId: "<id>",
    id: "<id>",
    subResourceId: "<id>",
    hrisUpdateEmploymentRequestDto: new HrisUpdateEmploymentRequestDto() {
        UnifiedCustomFields = new Dictionary<string, object>() {
            { "my_project_custom_field_1", "REF-1236" },
            { "my_project_custom_field_2", "some other value" },
        },
        JobTitle = "Software Engineer",
        PayRate = "40.00",
        PayPeriod = new HrisUpdateEmploymentRequestDtoPayPeriod() {
            Value = HrisUpdateEmploymentRequestDtoPayPeriodValue.Hour,
            SourceValue = HrisUpdateEmploymentRequestDtoPayPeriodSourceValueUnion.CreateStr(
                "Hour"
            ),
        },
        PayFrequency = new HrisUpdateEmploymentRequestDtoPayFrequency() {
            Value = HrisUpdateEmploymentRequestDtoPayFrequencyValue.Hourly,
            SourceValue = HrisUpdateEmploymentRequestDtoPayFrequencySourceValueUnion.CreateStr(
                "Hourly"
            ),
        },
        PayCurrency = "USD",
        EffectiveDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        EndDate = System.DateTime.Parse("2021-01-01T01:01:01.000Z"),
        Grade = new HrisUpdateEmploymentRequestDtoGrade() {
            Id = "1687-3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Name = "1687-4",
            Description = "Mid-level employee demonstrating proficiency and autonomy.",
        },
        Type = new HrisUpdateEmploymentRequestDtoType() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Label = "Permanent",
            Type = new HrisUpdateEmploymentRequestDtoTypeType() {},
        },
        ContractType = new HrisUpdateEmploymentRequestDtoContractType() {
            Id = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            RemoteId = "8187e5da-dc77-475e-9949-af0f1fa4e4e3",
            Label = "Full-Time",
            ContractType = new HrisUpdateEmploymentRequestDtoContractTypeContractType() {},
        },
        WorkTime = new HrisUpdateEmploymentRequestDtoWorkTime() {
            Duration = "P0Y0M0DT8H0M0S",
            DurationUnit = new HrisUpdateEmploymentRequestDtoDurationUnit() {
                Value = HrisUpdateEmploymentRequestDtoWorkTimeValue.Month,
            },
        },
        PayrollCode = "PC1",
        Passthrough = new Dictionary<string, object>() {
            { "other_known_names", "John Doe" },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `XAccountId`                                                                                | *string*                                                                                    | :heavy_check_mark:                                                                          | The account identifier                                                                      |
| `Id`                                                                                        | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `SubResourceId`                                                                             | *string*                                                                                    | :heavy_check_mark:                                                                          | N/A                                                                                         |
| `HrisUpdateEmploymentRequestDto`                                                            | [HrisUpdateEmploymentRequestDto](../../Models/Components/HrisUpdateEmploymentRequestDto.md) | :heavy_check_mark:                                                                          | N/A                                                                                         |

### Response

**[HrisUpdateEmployeeEmploymentResponse](../../Models/Requests/HrisUpdateEmployeeEmploymentResponse.md)**

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